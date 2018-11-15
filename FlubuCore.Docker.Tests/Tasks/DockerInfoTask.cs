
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerInfoTask : ExternalProcessTaskBase<DockerInfoTask>
     {
        
        
        public DockerInfoTask()
        {
            ExecutablePath = "docker";
            WithArguments("info");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerInfoTask Format(string format)
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
