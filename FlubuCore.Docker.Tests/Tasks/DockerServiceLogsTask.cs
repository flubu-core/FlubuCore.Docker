
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerServiceLogsTask : ExternalProcessTaskBase<DockerServiceLogsTask>
     {
        private string _service;

        
        public DockerServiceLogsTask(string service)
        {
            ExecutablePath = "docker";
            WithArguments("service logs");
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Show extra details provided to logs
        /// </summary>
        public DockerServiceLogsTask Details()
        {
            WithArguments("details");
            return this;
        }

        /// <summary>
        /// Follow log output
        /// </summary>
        public DockerServiceLogsTask Follow()
        {
            WithArguments("follow");
            return this;
        }

        /// <summary>
        /// Do not map IDs to Names in output
        /// </summary>
        public DockerServiceLogsTask NoResolve()
        {
            WithArguments("no-resolve");
            return this;
        }

        /// <summary>
        /// Do not include task IDs in output
        /// </summary>
        public DockerServiceLogsTask NoTaskIds()
        {
            WithArguments("no-task-ids");
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        public DockerServiceLogsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Do not neatly format logs
        /// </summary>
        public DockerServiceLogsTask Raw()
        {
            WithArguments("raw");
            return this;
        }

        /// <summary>
        /// Show logs since timestamp (e.g. 2013-01-02T13:23:37) or relative (e.g. 42m for 42 minutes)

        /// </summary>
        public DockerServiceLogsTask Since(string since)
        {
            WithArgumentsValueRequired("since", since.ToString());
            return this;
        }

        /// <summary>
        /// Number of lines to show from the end of the logs
        /// </summary>
        public DockerServiceLogsTask Tail(string tail)
        {
            WithArgumentsValueRequired("tail", tail.ToString());
            return this;
        }

        /// <summary>
        /// Show timestamps
        /// </summary>
        public DockerServiceLogsTask Timestamps()
        {
            WithArguments("timestamps");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_service);

            return base.DoExecute(context);
        }

     }
}
