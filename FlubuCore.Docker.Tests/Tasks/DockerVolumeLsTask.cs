
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerVolumeLsTask : ExternalProcessTaskBase<DockerVolumeLsTask>
     {
        
        
        public DockerVolumeLsTask()
        {
            ExecutablePath = "docker";
            WithArguments("volume ls");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Provide filter values (e.g. 'dangling=true')
        /// </summary>
        public DockerVolumeLsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print volumes using a Go template
        /// </summary>
        public DockerVolumeLsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Only display volume names
        /// </summary>
        public DockerVolumeLsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}