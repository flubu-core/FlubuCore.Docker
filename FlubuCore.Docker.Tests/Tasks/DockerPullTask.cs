
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerPullTask : ExternalProcessTaskBase<DockerPullTask>
     {
        private string _name;

        
        public DockerPullTask(string name)
        {
            ExecutablePath = "docker";
            WithArguments("pull");
_name = name;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Download all tagged images in the repository
        /// </summary>
        public DockerPullTask AllTags()
        {
            WithArguments("all-tags");
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        public DockerPullTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }

        /// <summary>
        /// Set platform if server is multi-platform capable
        /// </summary>
        public DockerPullTask Platform(string platform)
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
