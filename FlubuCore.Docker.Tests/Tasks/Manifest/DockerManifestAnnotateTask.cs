
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Manifest
{
     public partial class DockerManifestAnnotateTask : ExternalProcessTaskBase<int, DockerManifestAnnotateTask>
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
        [ArgKey("--arch")]
        public DockerManifestAnnotateTask Arch(string arch)
        {
            WithArgumentsKeyFromAttribute(arch.ToString());
            return this;
        }

        /// <summary>
        /// Set operating system
        /// </summary>
        [ArgKey("--os")]
        public DockerManifestAnnotateTask Os(string os)
        {
            WithArgumentsKeyFromAttribute(os.ToString());
            return this;
        }

        /// <summary>
        /// Set operating system feature
        /// </summary>
        [ArgKey("--os-features")]
        public DockerManifestAnnotateTask OsFeatures(string osFeatures)
        {
            WithArgumentsKeyFromAttribute(osFeatures.ToString());
            return this;
        }

        /// <summary>
        /// Set architecture variant
        /// </summary>
        [ArgKey("--variant")]
        public DockerManifestAnnotateTask Variant(string variant)
        {
            WithArgumentsKeyFromAttribute(variant.ToString());
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
