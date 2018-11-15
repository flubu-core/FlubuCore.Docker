
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerManifestAnnotateTask : ExternalProcessTaskBase<DockerManifestAnnotateTask>
     {
        private string _manifest_list;
private string _manifest;

        
        public DockerManifestAnnotateTask(string manifest_list,  string manifest)
        {
            ExecutablePath = "docker";
            WithArguments("manifest annotate");
_manifest_list = manifest_list;
_manifest = manifest;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Set architecture
        /// </summary>
        public DockerManifestAnnotateTask Arch(string arch)
        {
            WithArgumentsValueRequired("arch", arch.ToString());
            return this;
        }

        /// <summary>
        /// Set operating system
        /// </summary>
        public DockerManifestAnnotateTask Os(string os)
        {
            WithArgumentsValueRequired("os", os.ToString());
            return this;
        }

        /// <summary>
        /// Set operating system feature
        /// </summary>
        public DockerManifestAnnotateTask OsFeatures(string osFeatures)
        {
            WithArgumentsValueRequired("os-features", osFeatures.ToString());
            return this;
        }

        /// <summary>
        /// Set architecture variant
        /// </summary>
        public DockerManifestAnnotateTask Variant(string variant)
        {
            WithArgumentsValueRequired("variant", variant.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_manifest_list);
 WithArguments(_manifest);

            return base.DoExecute(context);
        }

     }
}
