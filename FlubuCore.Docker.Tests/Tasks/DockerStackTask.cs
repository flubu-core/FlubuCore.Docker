
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerStackTask : ExternalProcessTaskBase<DockerStackTask>
     {
        
        
        public DockerStackTask()
        {
            ExecutablePath = "docker";
            WithArguments("stack");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Kubernetes config file
        /// </summary>
        public DockerStackTask Kubeconfig(string kubeconfig)
        {
            WithArgumentsValueRequired("kubeconfig", kubeconfig.ToString());
            return this;
        }

        /// <summary>
        /// Kubernetes namespace to use
        /// </summary>
        public DockerStackTask Namespace(string @namespace)
        {
            WithArgumentsValueRequired("namespace", @namespace.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
