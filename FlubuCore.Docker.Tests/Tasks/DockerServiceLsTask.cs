
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerServiceLsTask : ExternalProcessTaskBase<DockerServiceLsTask>
     {
        
        
        public DockerServiceLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("service ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerServiceLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print services using a Go template
        /// </summary>
        public DockerServiceLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        public DockerServiceLsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
