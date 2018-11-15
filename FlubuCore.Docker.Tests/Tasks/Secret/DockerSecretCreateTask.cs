
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Secret
{
     public partial class DockerSecretCreateTask : ExternalProcessTaskBase<DockerSecretCreateTask>
     {
        private string _secret;
private string _file;

        
        public DockerSecretCreateTask(string secret,  string file)
        {
            ExecutablePath = "docker";
            WithArguments("secret create");
_secret = secret;
_file = file;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Secret driver
        /// </summary>
        public DockerSecretCreateTask Driver(string driver)
        {
            WithArgumentsValueRequired("driver", driver.ToString());
            return this;
        }

        /// <summary>
        /// Secret labels
        /// </summary>
        public DockerSecretCreateTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Template driver
        /// </summary>
        public DockerSecretCreateTask TemplateDriver(string templateDriver)
        {
            WithArgumentsValueRequired("template-driver", templateDriver.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_secret);
 WithArguments(_file);

            return base.DoExecute(context);
        }

     }
}