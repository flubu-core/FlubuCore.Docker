
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSystemInfoTask : ExternalProcessTaskBase<DockerSystemInfoTask>
     {
        
        
        public DockerSystemInfoTask()
        {
            ExecutablePath = "docker";
            WithArguments("system info");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerSystemInfoTask Format(string format)
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