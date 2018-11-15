
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPsTask : ExternalProcessTaskBase<DockerPsTask>
     {
        
        
        public DockerPsTask()
        {
            ExecutablePath = "docker";
            WithArguments("ps");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show all containers (default shows just running)
        /// </summary>
        public DockerPsTask All()
        {
            WithArguments("all");
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerPsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print containers using a Go template
        /// </summary>
        public DockerPsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Show n last created containers (includes all states)
        /// </summary>
        public DockerPsTask Last(int last)
        {
            WithArgumentsValueRequired("last", last.ToString());
            return this;
        }

        /// <summary>
        /// Show the latest created container (includes all states)
        /// </summary>
        public DockerPsTask Latest()
        {
            WithArguments("latest");
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerPsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display numeric IDs
        /// </summary>
        public DockerPsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Display total file sizes
        /// </summary>
        public DockerPsTask Size()
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
