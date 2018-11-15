using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FlubuCore.Docker.Models;
using FlubuCore.TaskGenerator.Models;

namespace FlubuCore.Docker
{
    public class DockerParser
    {
        public List<Task> Parse(List<Models.Docker> dockers)
        {
            var tasks = new List<TaskGenerator.Models.Task>();

            foreach (Models.Docker docker in dockers)
            {
                TaskGenerator.Models.Task task = new TaskGenerator.Models.Task()
                {
                    Namespace = "FlubuCore.Tasks.Docker",
                    ProjectName = "FlubuCore",
                    Methods = new List<Method>(),
                }; 
                
                task.Constructor = new Constructor
                {
                    Arguments = new List<ConstructorArgument>(),
                };

                var splitedCommands = docker.Command.Split(' ', '-');

                if (splitedCommands.Contains("cp"))
                {
                    continue;
                }

                task.ExecutablePath = splitedCommands[0];
                var splitedName = splitedCommands.Select(x => x.FirstCharToUpper()).ToList();
                task.Constructor.Arguments.Add(new ConstructorArgument
                {
                    ArgumentKey = docker.Command.Substring(6).TrimStart(),
                });

                task.TaskName = $"{string.Join(string.Empty, splitedName)}Task";
                task.FileName = $"Tasks\\{task.TaskName}.cs";
                if (docker.Options == null)
                {
                    continue;
                }

                ParseCommandsAndAddCommands(docker, task);
                ParseOptions(docker, task);

                tasks.Add(task);
            }

            return tasks;
        }

        private static void ParseOptions(Models.Docker docker, Task task)
        {
            foreach (var option in docker.Options)
            {
                Method method = new Method();
                var splitedOptionName = option.OptionOption.Split('-');
                method.MethodName = string.Join(string.Empty,
                    splitedOptionName.Select(x => x.FirstCharToUpper()).ToList());
                method.MethodSummary = option.Description;

                method.Argument = new Argument
                {
                    ArgumentKey = option.OptionOption.FirstCharToLower(),
                    HasArgumentValue = !option.ValueType.Equals("bool"),
                };

                if (!method.Argument.HasArgumentValue)
                {
                    task.Methods.Add(method);
                    continue;
                }

                string parameterType;
                switch (option.ValueType)
                {
                    case "double":
                    case "decimal":
                    case "int":
                    case "uint":
                    case "short":
                    case "float":
                    {
                        parameterType = option.ValueType;
                        break;
                    }

                    case "int32":
                    {
                        parameterType = "int";
                        break;
                    }

                    case "int64":
                    {
                        parameterType = "long";
                        break;
                    }

                    case "uint32":
                    {
                        parameterType = "uint";
                        break;
                    }

                    case "uint64":
                    {
                        parameterType = "ulong";

                        break;
                    }

                    default:
                    {
                        parameterType = "string";
                        break;
                    }
                }

                method.Argument.Parameter = new Parameter
                {
                    ParameterType = parameterType,
                    ParameterName = string.Join(string.Empty,
                            splitedOptionName.Select(x => x.FirstCharToUpper()).ToList())
                        .FirstCharToLower()
                };

                task.Methods.Add(method);
            }
        }

        public DockerCommands ParseCommandsAndAddCommands(Models.Docker docker, Task task)
        {
            var dockerCommands = new DockerCommands();

            var mainCommands = docker.Command.Split(' ').ToList();
            var allCommands = docker.Usage.Split(' ').ToList();
            
            bool foundOption = !allCommands.Contains(DockerCommands.OptionKey);
            for (var i = 0; i < allCommands.Count; i++)
            {
                if (mainCommands.Contains(allCommands[i]))
                {
                    continue;
                }

                var command = allCommands[i];
                if (command == DockerCommands.OptionKey)
                {
                    foundOption = true;
                    continue;
                }

                string paramName = command;

                ConstructorArgument argument = new ConstructorArgument()
                {
                    Parameter = new Parameter(),
                };

                if (paramName.TrimStart().StartsWith("|"))
                {
                    if (allCommands[i + 2] == "|")
                    {
                        var arg = task.Constructor.Arguments.Last();
                        arg.Parameter.ParameterName = $"{arg.Parameter.ParameterName}Or{allCommands[i + 1].FirstCharToUpper()}";
                        i = i + 2;
                    }
                    else
                    {
                        continue;
                    }
                }

                if (paramName.StartsWith("[") && paramName.EndsWith("]"))
                {
                    argument.Parameter.IsOptional = true;
                    paramName = command.Remove(0, 1);
                    paramName = paramName.Remove(paramName.Length - 1, 1);
                }

                if (i != allCommands.Count -1 && allCommands[i + 1].Contains(paramName))
                {
                    i++;
                    argument.Parameter.AsParams = true;
                }

                if (paramName.EndsWith(".."))
                {
                    argument.Parameter.AsParams = true;
                    paramName = paramName.TrimEnd('.');
                }

                if (paramName.Contains("|"))
                {
                    var splited = paramName.Split('|');
                    paramName = splited[0];
                }

                if (paramName.Contains("[:"))
                {
                    var splited = paramName.Split('[');
                    paramName = splited[0];
                }

                if (paramName.Contains(":"))
                {
                    var splited = paramName.Split(':');
                    paramName = splited[0];
                }

                if (paramName.Contains("-"))
                {
                    paramName = paramName.Replace("-", string.Empty);
                }

                if (paramName.Contains("="))
                {
                    continue;
                }

                paramName = paramName.Trim('(', ')');
                argument.Parameter.ParameterName = paramName.ToLowerInvariant();
                argument.Parameter.ParameterType = "string";

                if (foundOption)
                {
                    argument.AfterOptions = true;
                }

                if (!string.IsNullOrEmpty(argument.Parameter.ParameterName))
                {
                    task.Constructor.Arguments.Add(argument);
                }
            }

            return dockerCommands;
        }
    }
}
