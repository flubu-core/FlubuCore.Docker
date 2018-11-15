
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerImagePullTask : ExternalProcessTaskBase<DockerImagePullTask>
     {
        private string _name;

        
        public DockerImagePullTask(string name)
        {
            ExecutablePath = "docker";
            WithArguments("image pull");
_name = name;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Download all tagged images in the repository
        /// </summary>
        public DockerImagePullTask AllTags()
        {
            WithArguments("all-tags");
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        public DockerImagePullTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }

        /// <summary>
        /// Set platform if server is multi-platform capable
        /// </summary>
        public DockerImagePullTask Platform(string platform)
        {
            WithArgumentsValueRequired("platform", platform.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_name);

            return base.DoExecute(context);
        }

     }
}
