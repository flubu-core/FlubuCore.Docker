
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStartTask : ExternalProcessTaskBase<DockerStartTask>
     {
        private string[] _container;

        
        public DockerStartTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("start");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Attach STDOUT/STDERR and forward signals
        /// </summary>
        public DockerStartTask Attach()
        {
            WithArguments("attach");
            return this;
        }

        /// <summary>
        /// Restore from this checkpoint
        /// </summary>
        public DockerStartTask Checkpoint(string checkpoint)
        {
            WithArgumentsValueRequired("checkpoint", checkpoint.ToString());
            return this;
        }

        /// <summary>
        /// Use a custom checkpoint storage directory
        /// </summary>
        public DockerStartTask CheckpointDir(string checkpointDir)
        {
            WithArgumentsValueRequired("checkpoint-dir", checkpointDir.ToString());
            return this;
        }

        /// <summary>
        /// Override the key sequence for detaching a container
        /// </summary>
        public DockerStartTask DetachKeys(string detachKeys)
        {
            WithArgumentsValueRequired("detach-keys", detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Attach container's STDIN
        /// </summary>
        public DockerStartTask Interactive()
        {
            WithArguments("interactive");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
