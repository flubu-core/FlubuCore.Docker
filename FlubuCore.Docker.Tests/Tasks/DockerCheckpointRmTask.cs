
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerCheckpointRmTask : ExternalProcessTaskBase<DockerCheckpointRmTask>
     {
        private string _container;
private string _checkpoint;

        
        public DockerCheckpointRmTask(string container,  string checkpoint)
        {
            ExecutablePath = "docker";
            WithArguments("checkpoint rm");
_container = container;
_checkpoint = checkpoint;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Use a custom checkpoint storage directory
        /// </summary>
        public DockerCheckpointRmTask CheckpointDir(string checkpointDir)
        {
            WithArgumentsValueRequired("checkpoint-dir", checkpointDir.ToString());
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
