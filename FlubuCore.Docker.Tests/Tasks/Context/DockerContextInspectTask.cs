
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

namespace FlubuCore.Tasks.Docker.Context
{
     public partial class DockerContextInspectTask : ExternalProcessTaskBase<int, DockerContextInspectTask>
     {
        private string[] _context;

        
        public DockerContextInspectTask(params string[] context)
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();
_context = context;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        [ArgKey("format")]
        public DockerContextInspectTask Format(string format)
        {
            WithArgumentsKeyFromAttribute(format.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_context);

            return base.DoExecute(context);
        }

     }
}
