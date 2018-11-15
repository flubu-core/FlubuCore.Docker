
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmCaTask : ExternalProcessTaskBase<DockerSwarmCaTask>
     {
        
        
        public DockerSwarmCaTask()
        {
            ExecutablePath = "docker";
            WithArguments("swarm ca");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Path to the PEM-formatted root CA certificate to use for the new cluster

        /// </summary>
        public DockerSwarmCaTask CaCert(string caCert)
        {
            WithArgumentsValueRequired("ca-cert", caCert.ToString());
            return this;
        }

        /// <summary>
        /// Path to the PEM-formatted root CA key to use for the new cluster

        /// </summary>
        public DockerSwarmCaTask CaKey(string caKey)
        {
            WithArgumentsValueRequired("ca-key", caKey.ToString());
            return this;
        }

        /// <summary>
        /// Validity period for node certificates (ns|us|ms|s|m|h)
        /// </summary>
        public DockerSwarmCaTask CertExpiry(string certExpiry)
        {
            WithArgumentsValueRequired("cert-expiry", certExpiry.ToString());
            return this;
        }

        /// <summary>
        /// Exit immediately instead of waiting for the root rotation to converge

        /// </summary>
        public DockerSwarmCaTask Detach()
        {
            WithArguments("detach");
            return this;
        }

        /// <summary>
        /// Specifications of one or more certificate signing endpoints
        /// </summary>
        public DockerSwarmCaTask ExternalCa(string externalCa)
        {
            WithArgumentsValueRequired("external-ca", externalCa.ToString());
            return this;
        }

        /// <summary>
        /// Suppress progress output
        /// </summary>
        public DockerSwarmCaTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Rotate the swarm CA - if no certificate or key are provided, new ones will be generated

        /// </summary>
        public DockerSwarmCaTask Rotate()
        {
            WithArguments("rotate");
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
