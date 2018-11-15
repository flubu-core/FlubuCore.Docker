
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginEnableTask : ExternalProcessTaskBase<DockerPluginEnableTask>
     {
        private string _plugin;

        
        public DockerPluginEnableTask(string plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin enable");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// HTTP client timeout (in seconds)
        /// </summary>
        public DockerPluginEnableTask Timeout(int timeout)
        {
            WithArgumentsValueRequired("timeout", timeout.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
