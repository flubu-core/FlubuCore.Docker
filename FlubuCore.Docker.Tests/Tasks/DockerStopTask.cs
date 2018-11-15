
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStopTask : ExternalProcessTaskBase<DockerStopTask>
     {
        private string[] _container;

        
        public DockerStopTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("stop");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Seconds to wait for stop before killing it
        /// </summary>
        public DockerStopTask Time(int time)
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
