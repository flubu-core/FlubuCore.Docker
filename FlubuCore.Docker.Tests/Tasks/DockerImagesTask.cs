
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImagesTask : ExternalProcessTaskBase<DockerImagesTask>
     {
        private string _repository;

        
        public DockerImagesTask(string repository)
        {
            ExecutablePath = "docker";
            WithArguments("images");
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all images (default hides intermediate images)
        /// </summary>
        public DockerImagesTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Show digests
        /// </summary>
        public DockerImagesTask Digests()
        {
            WithArguments("digests");
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerImagesTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerImagesTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerImagesTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only show numeric IDs
        /// </summary>
        public DockerImagesTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}
