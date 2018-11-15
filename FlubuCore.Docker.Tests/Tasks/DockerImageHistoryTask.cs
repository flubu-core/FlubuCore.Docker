
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImageHistoryTask : ExternalProcessTaskBase<DockerImageHistoryTask>
     {
        private string _image;

        
        public DockerImageHistoryTask(string image)
        {
            ExecutablePath = "docker";
            WithArguments("image history");
_image = image;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerImageHistoryTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Print sizes and dates in human readable format
        /// </summary>
        public DockerImageHistoryTask Human()
        {
            WithArguments("human");
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerImageHistoryTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only show numeric IDs
        /// </summary>
        public DockerImageHistoryTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_image);

            return base.DoExecute(context);
        }

     }
}
