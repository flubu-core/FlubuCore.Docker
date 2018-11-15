
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerLoginTask : ExternalProcessTaskBase<DockerLoginTask>
     {
        private string _server;

        
        public DockerLoginTask(string server)
        {
            ExecutablePath = "docker";
            WithArguments("login");
_server = server;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Password
        /// </summary>
        public DockerLoginTask Password(string password)
        {
            WithArgumentsValueRequired("password", password.ToString());
            return this;
        }

        /// <summary>
        /// Take the password from stdin
        /// </summary>
        public DockerLoginTask PasswordStdin()
        {
            WithArguments("password-stdin");
            return this;
        }

        /// <summary>
        /// Username
        /// </summary>
        public DockerLoginTask Username(string username)
        {
            WithArgumentsValueRequired("username", username.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_server);

            return base.DoExecute(context);
        }

     }
}
