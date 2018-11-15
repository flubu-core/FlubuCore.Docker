
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginInstallTask : ExternalProcessTaskBase<DockerPluginInstallTask>
     {
        private string _plugin;

        
        public DockerPluginInstallTask(string plugin)
        {
            ExecutablePath = "docker";
            WithArguments("plugin install");
_plugin = plugin;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Local name for plugin
        /// </summary>
        public DockerPluginInstallTask Alias(string alias)
        {
            WithArgumentsValueRequired("alias", alias.ToString());
            return this;
        }

        /// <summary>
        /// Do not enable the plugin on install
        /// </summary>
        public DockerPluginInstallTask Disable()
        {
            WithArguments("disable");
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        public DockerPluginInstallTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }

        /// <summary>
        /// Grant all permissions necessary to run the plugin
        /// </summary>
        public DockerPluginInstallTask GrantAllPermissions()
        {
            WithArguments("grant-all-permissions");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);

            return base.DoExecute(context);
        }

     }
}
