
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStatsTask : ExternalProcessTaskBase<DockerStatsTask>
     {
        private string[] _container;

        
        public DockerStatsTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("stats");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        public DockerStatsTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Pretty-print images using a Go template
        /// </summary>
        public DockerStatsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Disable streaming stats and only pull the first result
        /// </summary>
        public DockerStatsTask NoStream()
        {
            WithArguments("no-stream");
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        public DockerStatsTask NoTrunc()
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
