
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerStatsTask : ExternalProcessTaskBase<DockerContainerStatsTask>
     {
        private string[] _container;

        
        public DockerContainerStatsTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("container stats");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        public DockerContainerStatsTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerContainerStatsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Disable streaming stats and only pull the first result
        /// </summary>
        public DockerContainerStatsTask NoStream()
        {
            WithArguments("no-stream");
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        public DockerContainerStatsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
