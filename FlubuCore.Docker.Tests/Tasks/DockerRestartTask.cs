
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerRestartTask : ExternalProcessTaskBase<DockerRestartTask>
     {
        private string[] _container;

        
        public DockerRestartTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("restart");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Seconds to wait for stop before killing the container
        /// </summary>
        public DockerRestartTask Time(int time)
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
