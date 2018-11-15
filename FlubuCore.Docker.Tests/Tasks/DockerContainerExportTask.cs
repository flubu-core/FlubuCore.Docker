
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerExportTask : ExternalProcessTaskBase<DockerContainerExportTask>
     {
        private string _container;

        
        public DockerContainerExportTask(string container)
        {
            ExecutablePath = "docker";
            WithArguments("container export");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Write to a file, instead of STDOUT
        /// </summary>
        public DockerContainerExportTask Output(string output)
        {
            WithArgumentsValueRequired("output", output.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
