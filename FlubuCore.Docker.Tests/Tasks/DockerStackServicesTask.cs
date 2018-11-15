
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStackServicesTask : ExternalProcessTaskBase<DockerStackServicesTask>
     {
        private string _stack;

        
        public DockerStackServicesTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("stack services");
_stack = stack;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerStackServicesTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print services using a Go template
        /// </summary>
        public DockerStackServicesTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        public DockerStackServicesTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_stack);

            return base.DoExecute(context);
        }

     }
}
