
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerVolumeCreateTask : ExternalProcessTaskBase<DockerVolumeCreateTask>
     {
        private string _volume;

        
        public DockerVolumeCreateTask(string volume)
        {
            ExecutablePath = "docker";
            WithArguments("volume create");
_volume = volume;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Specify volume driver name
        /// </summary>
        public DockerVolumeCreateTask Driver(string driver)
        {
            WithArgumentsValueRequired("driver", driver.ToString());
            return this;
        }

        /// <summary>
        /// Set metadata for a volume
        /// </summary>
        public DockerVolumeCreateTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Specify volume name
        /// </summary>
        public DockerVolumeCreateTask Name(string name)
        {
            WithArgumentsValueRequired("name", name.ToString());
            return this;
        }

        /// <summary>
        /// Set driver specific options
        /// </summary>
        public DockerVolumeCreateTask Opt(string opt)
        {
            WithArgumentsValueRequired("opt", opt.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_volume);

            return base.DoExecute(context);
        }

     }
}
