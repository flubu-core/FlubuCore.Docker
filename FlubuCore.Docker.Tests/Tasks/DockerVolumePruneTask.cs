
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerVolumePruneTask : ExternalProcessTaskBase<DockerVolumePruneTask>
     {
        
        
        public DockerVolumePruneTask()
        {
            ExecutablePath = "docker";
            WithArguments("volume prune");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Provide filter values (e.g. 'label=<label>')
        /// </summary>
        public DockerVolumePruneTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Do not prompt for confirmation
        /// </summary>
        public DockerVolumePruneTask Force()
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
