
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerRmTask : ExternalProcessTaskBase<DockerContainerRmTask>
     {
        private string[] _container;

        
        public DockerContainerRmTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("container rm");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force the removal of a running container (uses SIGKILL)
        /// </summary>
        public DockerContainerRmTask Force()
        {
            WithArguments("force");
            return this;
        }

        /// <summary>
        /// Remove the specified link
        /// </summary>
        public DockerContainerRmTask Link()
        {
            WithArguments("link");
            return this;
        }

        /// <summary>
        /// Remove the volumes associated with the container
        /// </summary>
        public DockerContainerRmTask Volumes()
        {
            WithArguments("volumes");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
