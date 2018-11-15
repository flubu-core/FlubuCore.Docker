
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStackPsTask : ExternalProcessTaskBase<DockerStackPsTask>
     {
        private string _stack;

        
        public DockerStackPsTask(string stack)
        {
            ExecutablePath = "docker";
            WithArguments("stack ps");
_stack = stack;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerStackPsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print tasks using a Go template
        /// </summary>
        public DockerStackPsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Do not map IDs to Names
        /// </summary>
        public DockerStackPsTask NoResolve()
        {
            WithArguments("no-resolve");
            return this;
        }

        /// <summary>
        /// Do not truncate output
        /// </summary>
        public DockerStackPsTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only display task IDs
        /// </summary>
        public DockerStackPsTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_stack);

            return base.DoExecute(context);
        }

     }
}
