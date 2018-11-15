
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerCommitTask : ExternalProcessTaskBase<DockerContainerCommitTask>
     {
        private string _container;
private string _repository;

        
        public DockerContainerCommitTask(string container,  string repository)
        {
            ExecutablePath = "docker";
            WithArguments("container commit");
_container = container;
_repository = repository;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Author (e.g., "John Hannibal Smith <hannibal@a-team.com>")
        /// </summary>
        public DockerContainerCommitTask Author(string author)
        {
            WithArgumentsValueRequired("author", author.ToString());
            return this;
        }

        /// <summary>
        /// Apply Dockerfile instruction to the created image
        /// </summary>
        public DockerContainerCommitTask Change(string change)
        {
            WithArgumentsValueRequired("change", change.ToString());
            return this;
        }

        /// <summary>
        /// Commit message
        /// </summary>
        public DockerContainerCommitTask Message(string message)
        {
            WithArgumentsValueRequired("message", message.ToString());
            return this;
        }

        /// <summary>
        /// Pause container during commit
        /// </summary>
        public DockerContainerCommitTask Pause()
        {
            WithArguments("pause");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);
 WithArguments(_repository);

            return base.DoExecute(context);
        }

     }
}
