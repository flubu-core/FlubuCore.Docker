
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerVolumeRmTask : ExternalProcessTaskBase<DockerVolumeRmTask>
     {
        private string[] _volume;

        
        public DockerVolumeRmTask(params string[] volume)
        {
            ExecutablePath = "docker";
            WithArguments("volume rm");
_volume = volume;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force the removal of one or more volumes
        /// </summary>
        public DockerVolumeRmTask Force()
        {
            WithArguments("force");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_volume);

            return base.DoExecute(context);
        }

     }
}
