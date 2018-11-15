
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerNodeUpdateTask : ExternalProcessTaskBase<DockerNodeUpdateTask>
     {
        private string _node;

        
        public DockerNodeUpdateTask(string node)
        {
            ExecutablePath = "docker";
            WithArguments("node update");
_node = node;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Availability of the node ("active"|"pause"|"drain")
        /// </summary>
        public DockerNodeUpdateTask Availability(string availability)
        {
            WithArgumentsValueRequired("availability", availability.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a node label (key=value)
        /// </summary>
        public DockerNodeUpdateTask LabelAdd(string labelAdd)
        {
            WithArgumentsValueRequired("label-add", labelAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a node label if exists
        /// </summary>
        public DockerNodeUpdateTask LabelRm(string labelRm)
        {
            WithArgumentsValueRequired("label-rm", labelRm.ToString());
            return this;
        }

        /// <summary>
        /// Role of the node ("worker"|"manager")
        /// </summary>
        public DockerNodeUpdateTask Role(string role)
        {
            WithArgumentsValueRequired("role", role.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_node);

            return base.DoExecute(context);
        }

     }
}
