
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmLeaveTask : ExternalProcessTaskBase<DockerSwarmLeaveTask>
     {
        
        
        public DockerSwarmLeaveTask()
        {
            ExecutablePath = "docker";
            WithArguments("swarm leave");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force this node to leave the swarm, ignoring warnings
        /// </summary>
        public DockerSwarmLeaveTask Force()
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