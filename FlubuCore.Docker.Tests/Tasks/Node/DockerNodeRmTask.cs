
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Node
{
     public partial class DockerNodeRmTask : ExternalProcessTaskBase<DockerNodeRmTask>
     {
        private string[] _node;

        
        public DockerNodeRmTask(params string[] node)
        {
            ExecutablePath = "docker";
            WithArguments("node rm");
_node = node;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Force remove a node from the swarm
        /// </summary>
        public DockerNodeRmTask Force()
        {
            WithArguments("force");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_node);

            return base.DoExecute(context);
        }

     }
}