
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImagePruneTask : ExternalProcessTaskBase<DockerImagePruneTask>
     {
        
        
        public DockerImagePruneTask()
        {
            ExecutablePath = "docker";
            WithArguments("image prune");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Remove all unused images, not just dangling ones
        /// </summary>
        public DockerImagePruneTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Provide filter values (e.g. 'until=<timestamp>')
        /// </summary>
        public DockerImagePruneTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation
        /// </summary>
        public DockerImagePruneTask Force()
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
