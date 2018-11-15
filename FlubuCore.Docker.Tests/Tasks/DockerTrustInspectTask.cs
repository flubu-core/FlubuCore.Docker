
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerTrustInspectTask : ExternalProcessTaskBase<DockerTrustInspectTask>
     {
        private string[] _image;

        
        public DockerTrustInspectTask(params string[] image)
        {
            ExecutablePath = "docker";
            WithArguments("trust inspect");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Print the information in a human friendly format
        /// </summary>
        public DockerTrustInspectTask Pretty()
        {
            WithArguments("pretty");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
