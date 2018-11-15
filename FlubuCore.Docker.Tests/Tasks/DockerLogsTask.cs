
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerLogsTask : ExternalProcessTaskBase<DockerLogsTask>
     {
        private string _container;

        
        public DockerLogsTask(string container)
        {
            ExecutablePath = "docker";
            WithArguments("logs");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show extra details provided to logs
        /// </summary>
        public DockerLogsTask Details()
        {
            WithArguments("details");
            return this;
        }

        /// <summary>
        /// Follow log output
        /// </summary>
        public DockerLogsTask Follow()
        {
            WithArguments("follow");
            return this;
        }

        /// <summary>
        /// Show logs since timestamp (e.g. 2013-01-02T13:23:37) or relative (e.g. 42m for 42 minutes)

        /// </summary>
        public DockerLogsTask Since(string since)
        {
            WithArgumentsValueRequired("since", since.ToString());
            return this;
        }

        /// <summary>
        /// Number of lines to show from the end of the logs
        /// </summary>
        public DockerLogsTask Tail(string tail)
        {
            WithArgumentsValueRequired("tail", tail.ToString());
            return this;
        }

        /// <summary>
        /// Show timestamps
        /// </summary>
        public DockerLogsTask Timestamps()
        {
            WithArguments("timestamps");
            return this;
        }

        /// <summary>
        /// Show logs before a timestamp (e.g. 2013-01-02T13:23:37) or relative (e.g. 42m for 42 minutes)

        /// </summary>
        public DockerLogsTask Until(string until)
        {
            WithArgumentsValueRequired("until", until.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}