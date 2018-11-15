
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerNetworkPruneTask : ExternalProcessTaskBase<DockerNetworkPruneTask>
     {
        
        
        public DockerNetworkPruneTask()
        {
            ExecutablePath = "docker";
            WithArguments("network prune");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Provide filter values (e.g. 'until=<timestamp>')
        /// </summary>
        public DockerNetworkPruneTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation
        /// </summary>
        public DockerNetworkPruneTask Force()
        {
            WithArguments("force");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
