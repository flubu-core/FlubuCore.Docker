
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerNetworkInspectTask : ExternalProcessTaskBase<DockerNetworkInspectTask>
     {
        private string[] _network;

        
        public DockerNetworkInspectTask(params string[] network)
        {
            ExecutablePath = "docker";
            WithArguments("network inspect");
_network = network;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerNetworkInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Verbose output for diagnostics
        /// </summary>
        public DockerNetworkInspectTask Verbose()
        {
            WithArguments("verbose");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_network);

            return base.DoExecute(context);
        }

     }
}
