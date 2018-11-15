
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginLsTask : ExternalProcessTaskBase<DockerPluginLsTask>
     {
        
        
        public DockerPluginLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("plugin ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Provide filter values (e.g. 'enabled=true')
        /// </summary>
        public DockerPluginLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print plugins using a Go template
        /// </summary>
        public DockerPluginLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerPluginLsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display plugin IDs
        /// </summary>
        public DockerPluginLsTask Quiet()
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