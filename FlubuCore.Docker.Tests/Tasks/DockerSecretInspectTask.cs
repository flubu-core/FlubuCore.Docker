
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSecretInspectTask : ExternalProcessTaskBase<DockerSecretInspectTask>
     {
        private string[] _secret;

        
        public DockerSecretInspectTask(params string[] secret)
        {
            ExecutablePath = "docker";
            WithArguments("secret inspect");
_secret = secret;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerSecretInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        public DockerSecretInspectTask Pretty()
        {
            WithArguments("pretty");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_secret);

            return base.DoExecute(context);
        }

     }
}
