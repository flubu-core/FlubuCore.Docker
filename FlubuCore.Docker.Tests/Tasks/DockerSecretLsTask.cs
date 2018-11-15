
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSecretLsTask : ExternalProcessTaskBase<DockerSecretLsTask>
     {
        
        
        public DockerSecretLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("secret ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerSecretLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print secrets using a Go template
        /// </summary>
        public DockerSecretLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Only display IDs
        /// </summary>
        public DockerSecretLsTask Quiet()
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
