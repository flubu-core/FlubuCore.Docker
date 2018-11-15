
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerTrustSignTask : ExternalProcessTaskBase<DockerTrustSignTask>
     {
        private string _image;

        
        public DockerTrustSignTask(string image)
        {
            ExecutablePath = "docker";
            WithArguments("trust sign");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Sign a locally tagged image
        /// </summary>
        public DockerTrustSignTask Local()
        {
            WithArguments("local");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
