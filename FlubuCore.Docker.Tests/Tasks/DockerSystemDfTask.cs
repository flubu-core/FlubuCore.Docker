
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSystemDfTask : ExternalProcessTaskBase<DockerSystemDfTask>
     {
        
        
        public DockerSystemDfTask()
        {
            ExecutablePath = "docker";
            WithArguments("system df");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerSystemDfTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Show detailed information on space usage
        /// </summary>
        public DockerSystemDfTask Verbose()
        {
            WithArguments("verbose");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
