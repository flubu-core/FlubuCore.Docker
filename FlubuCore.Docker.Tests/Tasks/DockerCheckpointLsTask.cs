
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerCheckpointLsTask : ExternalProcessTaskBase<DockerCheckpointLsTask>
     {
        private string _container;

        
        public DockerCheckpointLsTask(string container)
        {
            ExecutablePath = "docker";
            WithArguments("checkpoint ls");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Use a custom checkpoint storage directory
        /// </summary>
        public DockerCheckpointLsTask CheckpointDir(string checkpointDir)
        {
            WithArgumentsValueRequired("checkpoint-dir", checkpointDir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}