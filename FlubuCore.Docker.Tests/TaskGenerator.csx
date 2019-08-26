#r ".\..\lib\YamlDotNet.dll"
#r ".\..\lib\Newtonsoft.Json.dll"
#r ".\..\lib\FlubuCore.TaskGenerator.dll"
#r ".\..\lib\FlubuCore.Docker.dll"
var reader = new FlubuCore.Docker.DockerReader();
var azureItems = reader.Read();
var parser = new FlubuCore.Docker.DockerParser();
var tasks = parser.Parse(azureItems);
var generator = new FlubuCore.TaskGenerator.TaskGenerator(Context);
//generator.GenerateTasks(tasks);
//var extensions = parser.ToTaskExtensions(tasks);
//var ext = new FlubuCore.TaskGenerator.TaskExtensionsGenerator(Context);
//ext.GenerateTaskExtension(extensions);

//var terminal = new FlubuCore.TaskGenerator.FlubuConsoleTaskGenerator(Context);
//terminal.GenerateTasks(tasks, "DockerTerminal");