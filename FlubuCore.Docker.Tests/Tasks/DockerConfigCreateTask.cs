
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerConfigCreateTask : ExternalProcessTaskBase<DockerConfigCreateTask>
     {
        private string _config;
private string _file;

        
        public DockerConfigCreateTask(string config,  string file)
        {
            ExecutablePath = "docker";
            WithArguments("config create");
_config = config;
_file = file;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Config labels
        /// </summary>
        public DockerConfigCreateTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Template driver
        /// </summary>
        public DockerConfigCreateTask TemplateDriver(string templateDriver)
        {
            WithArgumentsValueRequired("template-driver", templateDriver.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_config);
 WithArguments(_file);

            return base.DoExecute(context);
        }

     }
}
