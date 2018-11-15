
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerServicePsTask : ExternalProcessTaskBase<DockerServicePsTask>
     {
        private string[] _service;

        
        public DockerServicePsTask(params string[] service)
        {
            ExecutablePath = "docker";
            WithArguments("service ps");
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerServicePsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print tasks using a Go template
        /// </summary>
        public DockerServicePsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Do not map IDs to Names
        /// </summary>
        public DockerServicePsTask NoResolve()
        {
            WithArguments("no-resolve");
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        public DockerServicePsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display task IDs
        /// </summary>
        public DockerServicePsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_service);

            return base.DoExecute(context);
        }

     }
}
