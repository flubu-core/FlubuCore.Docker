
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImagePushTask : ExternalProcessTaskBase<DockerImagePushTask>
     {
        private string _name;

        
        public DockerImagePushTask(string name)
        {
            ExecutablePath = "docker";
            WithArguments("image push");
_name = name;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Skip image signing
        /// </summary>
        public DockerImagePushTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_name);

            return base.DoExecute(context);
        }

     }
}
