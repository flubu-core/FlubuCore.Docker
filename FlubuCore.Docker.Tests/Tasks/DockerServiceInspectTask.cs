
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerServiceInspectTask : ExternalProcessTaskBase<DockerServiceInspectTask>
     {
        private string[] _service;

        
        public DockerServiceInspectTask(params string[] service)
        {
            ExecutablePath = "docker";
            WithArguments("service inspect");
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerServiceInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        public DockerServiceInspectTask Pretty()
        {
            WithArguments("pretty");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_service);

            return base.DoExecute(context);
        }

     }
}
