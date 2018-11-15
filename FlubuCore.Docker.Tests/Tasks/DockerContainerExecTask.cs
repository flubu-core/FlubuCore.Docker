
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerExecTask : ExternalProcessTaskBase<DockerContainerExecTask>
     {
        private string _container;
private string _command;
private string[] _arg;

        
        public DockerContainerExecTask(string container,  string command,  params string[] arg)
        {
            ExecutablePath = "docker";
            WithArguments("container exec");
_container = container;
_command = command;
_arg = arg;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Detached mode: run command in the background
        /// </summary>
        public DockerContainerExecTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Override the key sequence for detaching a container
        /// </summary>
        public DockerContainerExecTask DetachKeys(string detachKeys)
        {
            WithArgumentsValueRequired("detach-keys", detachKeys.ToString());
            return this;
        }

        /// <summary>
        /// Set environment variables
        /// </summary>
        public DockerContainerExecTask Env(string env)
        {
            WithArgumentsValueRequired("env", env.ToString());
            return this;
        }

        /// <summary>
        /// Keep STDIN open even if not attached
        /// </summary>
        public DockerContainerExecTask Interactive()
        {
            WithArguments("interactive");
            return this;
        }

        /// <summary>
        /// Give extended privileges to the command
        /// </summary>
        public DockerContainerExecTask Privileged()
        {
            WithArguments("privileged");
            return this;
        }

        /// <summary>
        /// Allocate a pseudo-TTY
        /// </summary>
        public DockerContainerExecTask Tty()
        {
            WithArguments("tty");
            return this;
        }

        /// <summary>
        /// Username or UID (format: <name|uid>[:<group|gid>])
        /// </summary>
        public DockerContainerExecTask User(string user)
        {
            WithArgumentsValueRequired("user", user.ToString());
            return this;
        }

        /// <summary>
        /// Working directory inside the container
        /// </summary>
        public DockerContainerExecTask Workdir(string workdir)
        {
            WithArgumentsValueRequired("workdir", workdir.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);
 WithArguments(_command);
 WithArguments(_arg);

            return base.DoExecute(context);
        }

     }
}
