
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerRestartTask : ExternalProcessTaskBase<DockerContainerRestartTask>
     {
        private string[] _container;

        
        public DockerContainerRestartTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("container restart");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Seconds to wait for stop before killing the container
        /// </summary>
        public DockerContainerRestartTask Time(int time)
        {
            WithArgumentsValueRequired("time", time.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
