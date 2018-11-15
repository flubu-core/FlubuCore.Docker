
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginDisableTask : ExternalProcessTaskBase<DockerPluginDisableTask>
     {
        private string _plugin;

        
        public DockerPluginDisableTask(string plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin disable");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force the disable of an active plugin
        /// </summary>
        public DockerPluginDisableTask Force()
        {
            WithArguments("force");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
