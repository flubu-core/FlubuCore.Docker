
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSystemPruneTask : ExternalProcessTaskBase<DockerSystemPruneTask>
     {
        
        
        public DockerSystemPruneTask()
        {
            ExecutablePath = "docker";
            WithArguments("system prune");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Remove all unused images not just dangling ones
        /// </summary>
        public DockerSystemPruneTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Provide filter values (e.g. 'label=<key>=<value>')
        /// </summary>
        public DockerSystemPruneTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation
        /// </summary>
        public DockerSystemPruneTask Force()
        {
            WithArguments("force");
            return this;
        }

        /// <summary>
        /// Prune volumes
        /// </summary>
        public DockerSystemPruneTask Volumes()
        {
            WithArguments("volumes");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}