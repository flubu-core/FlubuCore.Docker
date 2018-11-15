
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImageRmTask : ExternalProcessTaskBase<DockerImageRmTask>
     {
        private string[] _image;

        
        public DockerImageRmTask(params string[] image)
        {
            ExecutablePath = "docker";
            WithArguments("image rm");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force removal of the image
        /// </summary>
        public DockerImageRmTask Force()
        {
            WithArguments("force");
            return this;
        }

        /// <summary>
        /// Do not delete untagged parents
        /// </summary>
        public DockerImageRmTask NoPrune()
        {
            WithArguments("no-prune");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
