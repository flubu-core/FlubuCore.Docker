
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmJoinTokenTask : ExternalProcessTaskBase<DockerSwarmJoinTokenTask>
     {
        private string _worker;

        
        public DockerSwarmJoinTokenTask(string worker)
        {
            ExecutablePath = "docker";
            WithArguments("swarm join-token");
_worker = worker;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Only display token
        /// </summary>
        public DockerSwarmJoinTokenTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Rotate join token
        /// </summary>
        public DockerSwarmJoinTokenTask Rotate()
        {
            WithArguments("rotate");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_worker);

            return base.DoExecute(context);
        }

     }
}