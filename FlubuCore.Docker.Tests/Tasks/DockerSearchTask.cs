
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSearchTask : ExternalProcessTaskBase<DockerSearchTask>
     {
        private string _term;

        
        public DockerSearchTask(string term)
        {
            ExecutablePath = "docker";
            WithArguments("search");
_term = term;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Only show automated builds
        /// </summary>
        public DockerSearchTask Automated()
        {
            WithArguments("automated");
            return this;
        }

        /// <summary>
        /// Filter output based on conditions provided
        /// </summary>
        public DockerSearchTask Filter(string filter)
        {
            WithArgumentsValueRequired("filter", filter.ToString());
            return this;
        }

        /// <summary>
        /// Pretty-print search using a Go template
        /// </summary>
        public DockerSearchTask Format(string format)
        {
            WithArgumentsValueRequired("format", format.ToString());
            return this;
        }

        /// <summary>
        /// Max number of search results
        /// </summary>
        public DockerSearchTask Limit(int limit)
        {
            WithArgumentsValueRequired("limit", limit.ToString());
            return this;
        }

        /// <summary>
        /// Don't truncate output
        /// </summary>
        public DockerSearchTask NoTrunc()
        {
            WithArguments("no-trunc");
            return this;
        }

        /// <summary>
        /// Only displays with at least x stars
        /// </summary>
        public DockerSearchTask Stars(uint stars)
        {
            WithArgumentsValueRequired("stars", stars.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_term);

            return base.DoExecute(context);
        }

     }
}
