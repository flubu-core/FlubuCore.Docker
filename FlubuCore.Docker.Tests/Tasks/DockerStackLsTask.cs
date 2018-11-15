
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStackLsTask : ExternalProcessTaskBase<DockerStackLsTask>
     {
        
        
        public DockerStackLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("stack ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Pretty-print stacks using a Go template
        /// </summary>
        public DockerStackLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
