
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerInspectTask : ExternalProcessTaskBase<DockerContainerInspectTask>
     {
        private string[] _container;

        
        public DockerContainerInspectTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("container inspect");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerContainerInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Display total file sizes
        /// </summary>
        public DockerContainerInspectTask Size()
        {
            WithArguments("size");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
