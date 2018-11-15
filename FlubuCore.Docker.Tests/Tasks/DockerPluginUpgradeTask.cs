
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPluginUpgradeTask : ExternalProcessTaskBase<DockerPluginUpgradeTask>
     {
        private string _plugin;
private string _remote;

        
        public DockerPluginUpgradeTask(string plugin,  string remote)
        {
            ExecutablePath = "docker";
            WithArguments("plugin upgrade");
_plugin = plugin;
_remote = remote;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Skip image verification
        /// </summary>
        public DockerPluginUpgradeTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }

        /// <summary>
        /// Grant all permissions necessary to run the plugin
        /// </summary>
        public DockerPluginUpgradeTask GrantAllPermissions()
        {
            WithArguments("grant-all-permissions");
            return this;
        }

        /// <summary>
        /// Do not check if specified remote plugin matches existing plugin image

        /// </summary>
        public DockerPluginUpgradeTask SkipRemoteCheck()
        {
            WithArguments("skip-remote-check");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_plugin);
 WithArguments(_remote);

            return base.DoExecute(context);
        }

     }
}