
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

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerExportTask : ExternalProcessTaskBase<int, DockerExportTask>
     {
        private string _container;

        
        public DockerExportTask(string container)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Write to a file, instead of STDOUT
        /// </summary>
        [ArgKey("output")]
        public DockerExportTask Output(string output)
        {
            WithArgumentsKeyFromAttribute(output.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
