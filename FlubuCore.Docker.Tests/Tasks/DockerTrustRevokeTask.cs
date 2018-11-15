
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerTrustRevokeTask : ExternalProcessTaskBase<DockerTrustRevokeTask>
     {
        private string _image;

        
        public DockerTrustRevokeTask(string image)
        {
            ExecutablePath = "docker";
            WithArguments("trust revoke");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Do not prompt for confirmation
        /// </summary>
        public DockerTrustRevokeTask Yes()
        {
            WithArguments("yes");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
