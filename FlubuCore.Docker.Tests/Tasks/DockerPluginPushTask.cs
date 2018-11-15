
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginPushTask : ExternalProcessTaskBase<DockerPluginPushTask>
     {
        private string _plugin;

        
        public DockerPluginPushTask(string plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin push");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Skip image signing
        /// </summary>
        public DockerPluginPushTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
