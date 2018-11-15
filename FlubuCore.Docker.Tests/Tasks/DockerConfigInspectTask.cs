
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerConfigInspectTask : ExternalProcessTaskBase<DockerConfigInspectTask>
     {
        private string[] _config;

        
        public DockerConfigInspectTask(params string[] config)
        {
            ExecutablePath = "docker";
            WithArguments("config inspect");
_config = config;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerConfigInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        public DockerConfigInspectTask Pretty()
        {
            WithArguments("pretty");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_config);

            return base.DoExecute(context);
        }

     }
}
