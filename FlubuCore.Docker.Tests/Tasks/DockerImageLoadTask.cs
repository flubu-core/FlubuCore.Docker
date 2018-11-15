
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImageLoadTask : ExternalProcessTaskBase<DockerImageLoadTask>
     {
        
        
        public DockerImageLoadTask()
        {
            ExecutablePath = "docker";
            WithArguments("image load");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Read from tar archive file, instead of STDIN
        /// </summary>
        public DockerImageLoadTask Input(string input)
        {
            WithArgumentsValueRequired("input", input.ToString());
            return this;
        }

        /// <summary>
        /// Suppress the load output
        /// </summary>
        public DockerImageLoadTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
