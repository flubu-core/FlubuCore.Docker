
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Service
{
     public partial class DockerServiceRollbackTask : ExternalProcessTaskBase<DockerServiceRollbackTask>
     {
        private string _service;

        
        public DockerServiceRollbackTask(string service)
        {
            ExecutablePath = "docker";
            WithArguments("service rollback");
_service = service;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Exit immediately instead of waiting for the service to converge

        /// </summary>
        public DockerServiceRollbackTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Suppress progress output
        /// </summary>
        public DockerServiceRollbackTask Quiet()
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