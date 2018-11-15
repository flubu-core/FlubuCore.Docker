
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerLsTask : ExternalProcessTaskBase<DockerContainerLsTask>
     {
        
        
        public DockerContainerLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("container ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        public DockerContainerLsTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerContainerLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print containers using a Go template
        /// </summary>
        public DockerContainerLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Show n last created containers (includes all states)
        /// </summary>
        public DockerContainerLsTask Last(int last)
        {
            WithArgumentsValueRequired("last", last.ToString());
            return this;
        }

        /// <summary>
        /// Show the latest created container (includes all states)
        /// </summary>
        public DockerContainerLsTask Latest()
        {
            WithArguments("latest");
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerContainerLsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display numeric IDs
        /// </summary>
        public DockerContainerLsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Display total file sizes
        /// </summary>
        public DockerContainerLsTask Size()
        {
            WithArguments("size");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
