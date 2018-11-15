
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerManifestPushTask : ExternalProcessTaskBase<DockerManifestPushTask>
     {
        private string _manifest_list;

        
        public DockerManifestPushTask(string manifest_list)
        {
            ExecutablePath = "docker";
            WithArguments("manifest push");
_manifest_list = manifest_list;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Allow push to an insecure registry
        /// </summary>
        public DockerManifestPushTask Insecure()
        {
            WithArguments("insecure");
            return this;
        }

        /// <summary>
        /// Remove the local manifest list after push
        /// </summary>
        public DockerManifestPushTask Purge()
        {
            WithArguments("purge");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_manifest_list);

            return base.DoExecute(context);
        }

     }
}
