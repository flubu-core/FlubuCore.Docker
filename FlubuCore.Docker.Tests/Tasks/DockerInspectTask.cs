
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerInspectTask : ExternalProcessTaskBase<DockerInspectTask>
     {
        private string[] _name;

        
        public DockerInspectTask(params string[] name)
        {
            ExecutablePath = "docker";
            WithArguments("inspect");
_name = name;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerInspectTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Display total file sizes if the type is container
        /// </summary>
        public DockerInspectTask Size()
        {
            WithArguments("size");
            return this;
        }

        /// <summary>
        /// Return JSON for specified type
        /// </summary>
        public DockerInspectTask Type(string type)
        {
            WithArgumentsValueRequired("type", type.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_name);

            return base.DoExecute(context);
        }

     }
}
