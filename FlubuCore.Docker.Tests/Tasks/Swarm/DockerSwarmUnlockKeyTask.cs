
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Swarm
{
     public partial class DockerSwarmUnlockKeyTask : ExternalProcessTaskBase<DockerSwarmUnlockKeyTask>
     {
        
        
        public DockerSwarmUnlockKeyTask()
        {
            ExecutablePath = "docker";
            WithArguments("swarm unlock-key");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Only display token
        /// </summary>
        public DockerSwarmUnlockKeyTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Rotate unlock key
        /// </summary>
        public DockerSwarmUnlockKeyTask Rotate()
        {
            WithArguments("rotate");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}