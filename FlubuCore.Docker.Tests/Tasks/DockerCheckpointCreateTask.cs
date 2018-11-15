
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerCheckpointCreateTask : ExternalProcessTaskBase<DockerCheckpointCreateTask>
     {
        private string _container;
private string _checkpoint;

        
        public DockerCheckpointCreateTask(string container,  string checkpoint)
        {
            ExecutablePath = "docker";
            WithArguments("checkpoint create");
_container = container;
_checkpoint = checkpoint;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Use a custom checkpoint storage directory
        /// </summary>
        public DockerCheckpointCreateTask CheckpointDir(string checkpointDir)
        {
            WithArgumentsValueRequired("checkpoint-dir", checkpointDir.ToString());
            return this;
        }

        /// <summary>
        /// Leave the container running after checkpoint
        /// </summary>
        public DockerCheckpointCreateTask LeaveRunning()
        {
            WithArguments("leave-running");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);
 WithArguments(_checkpoint);

            return base.DoExecute(context);
        }

     }
}
