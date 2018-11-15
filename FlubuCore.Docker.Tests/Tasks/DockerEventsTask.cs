
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerEventsTask : ExternalProcessTaskBase<DockerEventsTask>
     {
        
        
        public DockerEventsTask()
        {
            ExecutablePath = "docker";
            WithArguments("events");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerEventsTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Format the output using the given Go template
        /// </summary>
        public DockerEventsTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Show all events created since timestamp
        /// </summary>
        public DockerEventsTask Since(string since)
        {
            WithArgumentsValueRequired("since", since.ToString());
            return this;
        }

        /// <summary>
        /// Stream events until this timestamp
        /// </summary>
        public DockerEventsTask Until(string until)
        {
            WithArgumentsValueRequired("until", until.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
