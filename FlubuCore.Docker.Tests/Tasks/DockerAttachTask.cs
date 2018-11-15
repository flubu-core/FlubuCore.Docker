
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerAttachTask : ExternalProcessTaskBase<DockerAttachTask>
     {
        private string _container;

        
        public DockerAttachTask(string container)
        {
            ExecutablePath = "docker";
            WithArguments("attach");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Override the key sequence for detaching a container
        /// </summary>
        public DockerAttachTask DetachKeys(string detachKeys)
        {
            WithArgumentsValueRequired("detach-keys", detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Do not attach STDIN
        /// </summary>
        public DockerAttachTask NoStdin()
        {
            WithArguments("no-stdin");
            return this;
        }

        /// <summary>
        /// Proxy all received signals to the process
        /// </summary>
        public DockerAttachTask SigProxy()
        {
            WithArguments("sig-proxy");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
