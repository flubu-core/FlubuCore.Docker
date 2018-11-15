
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerKillTask : ExternalProcessTaskBase<DockerKillTask>
     {
        private string[] _container;

        
        public DockerKillTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("kill");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Signal to send to the container
        /// </summary>
        public DockerKillTask Signal(string signal)
        {
            WithArgumentsValueRequired("signal", signal.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}