
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerExportTask : ExternalProcessTaskBase<DockerExportTask>
     {
        private string _container;

        
        public DockerExportTask(string container)
        {
            ExecutablePath = "docker";
            WithArguments("export");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Write to a file, instead of STDOUT
        /// </summary>
        public DockerExportTask Output(string output)
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
