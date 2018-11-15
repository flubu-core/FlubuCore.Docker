
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImageSaveTask : ExternalProcessTaskBase<DockerImageSaveTask>
     {
        private string[] _image;

        
        public DockerImageSaveTask(params string[] image)
        {
            ExecutablePath = "docker";
            WithArguments("image save");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Write to a file, instead of STDOUT
        /// </summary>
        public DockerImageSaveTask Output(string output)
        {
            WithArgumentsValueRequired("output", output.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
