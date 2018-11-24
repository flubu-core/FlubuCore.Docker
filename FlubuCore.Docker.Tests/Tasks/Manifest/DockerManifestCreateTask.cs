
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Manifest
{
     public partial class DockerManifestCreateTask : ExternalProcessTaskBase<DockerManifestCreateTask>
     {
        private string _manfest_list;
private string[] _manifest;

        
        public DockerManifestCreateTask(string manfest_list,  params string[] manifest)
        {
            ExecutablePath = "docker";
            WithArguments("manifest create");
_manfest_list = manfest_list;
_manifest = manifest;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Amend an existing manifest list
        /// </summary>
        public DockerManifestCreateTask Amend()
        {
            WithArguments("amend");
            return this;
        }

        /// <summary>
        /// allow communication with an insecure registry
        /// </summary>
        public DockerManifestCreateTask Insecure()
        {
            WithArguments("insecure");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_manfest_list);
 WithArguments(_manifest);

            return base.DoExecute(context);
        }

     }
}
