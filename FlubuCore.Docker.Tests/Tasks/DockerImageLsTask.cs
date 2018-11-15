
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImageLsTask : ExternalProcessTaskBase<DockerImageLsTask>
     {
        private string _repository;

        
        public DockerImageLsTask(string repository)
        {
            ExecutablePath = "docker";
            WithArguments("image ls");
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all images (default hides intermediate images)
        /// </summary>
        public DockerImageLsTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Show digests
        /// </summary>
        public DockerImageLsTask Digests()
        {
            WithArguments("digests");
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerImageLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerImageLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerImageLsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only show numeric IDs
        /// </summary>
        public DockerImageLsTask Quiet()
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
