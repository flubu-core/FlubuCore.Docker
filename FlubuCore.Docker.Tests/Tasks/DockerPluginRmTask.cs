
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginRmTask : ExternalProcessTaskBase<DockerPluginRmTask>
     {
        private string[] _plugin;

        
        public DockerPluginRmTask(params string[] plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin rm");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force the removal of an active plugin
        /// </summary>
        public DockerPluginRmTask Force()
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
