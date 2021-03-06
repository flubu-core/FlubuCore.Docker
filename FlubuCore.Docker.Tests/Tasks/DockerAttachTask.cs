
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerAttachTask : ExternalProcessTaskBase<int, DockerAttachTask>
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
        [ArgKey("--detach-keys")]
        public DockerAttachTask DetachKeys(string detachKeys)
        {
            WithArgumentsKeyFromAttribute(detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Do not attach STDIN
        /// </summary>
        [ArgKey("--no-stdin")]
        public DockerAttachTask NoStdin()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Proxy all received signals to the process
        /// </summary>
        [ArgKey("--sig-proxy")]
        public DockerAttachTask SigProxy()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
