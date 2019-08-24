
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

namespace FlubuCore.Tasks.Docker.Container
{
     public partial class DockerContainerLogsTask : ExternalProcessTaskBase<int, DockerContainerLogsTask>
     {
        private string _container;

        
        public DockerContainerLogsTask(string container)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show extra details provided to logs
        /// </summary>
        [ArgKey("details")]
        public DockerContainerLogsTask Details()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Follow log output
        /// </summary>
        [ArgKey("follow")]
        public DockerContainerLogsTask Follow()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Show logs since timestamp (e.g. 2013-01-02T13:23:37) or relative (e.g. 42m for 42 minutes)

        /// </summary>
        [ArgKey("since")]
        public DockerContainerLogsTask Since(string since)
        {
            WithArgumentsKeyFromAttribute(since.ToString());
            return this;
        }

        /// <summary>
        /// Number of lines to show from the end of the logs
        /// </summary>
        [ArgKey("tail")]
        public DockerContainerLogsTask Tail(string tail)
        {
            WithArgumentsKeyFromAttribute(tail.ToString());
            return this;
        }

        /// <summary>
        /// Show timestamps
        /// </summary>
        [ArgKey("timestamps")]
        public DockerContainerLogsTask Timestamps()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Show logs before a timestamp (e.g. 2013-01-02T13:23:37) or relative (e.g. 42m for 42 minutes)

        /// </summary>
        [ArgKey("until")]
        public DockerContainerLogsTask Until(string until)
        {
            WithArgumentsKeyFromAttribute(until.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
