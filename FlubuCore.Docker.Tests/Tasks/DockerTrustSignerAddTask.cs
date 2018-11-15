
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerTrustSignerAddTask : ExternalProcessTaskBase<DockerTrustSignerAddTask>
     {
        private string _options;
private string _name;
private string[] _repository;

        
        public DockerTrustSignerAddTask(string options,  string name,  params string[] repository)
        {
            ExecutablePath = "docker";
            WithArguments("trust signer add");
_options = options;
_name = name;
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to the signer's public key file
        /// </summary>
        public DockerTrustSignerAddTask Key(string key)
        {
            WithArgumentsValueRequired("key", key.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_options);
 WithArguments(_name);
 WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}
