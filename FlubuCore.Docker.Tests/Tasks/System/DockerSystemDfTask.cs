
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.System
{
     public partial class DockerSystemDfTask : ExternalProcessTaskBase<int, DockerSystemDfTask>
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
        [ArgKey("--format")]
        public DockerSystemDfTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }

        /// <summary>
        /// Show detailed information on space usage
        /// </summary>
        [ArgKey("--verbose")]
        public DockerSystemDfTask Verbose()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
