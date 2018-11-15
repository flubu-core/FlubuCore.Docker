
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmJoinTask : ExternalProcessTaskBase<DockerSwarmJoinTask>
     {
        private string _host;

        
        public DockerSwarmJoinTask(string host)
        {
            ExecutablePath = "docker";
            WithArguments("swarm join");
_host = host;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Advertised address (format: <ip|interface>[:port])
        /// </summary>
        public DockerSwarmJoinTask AdvertiseAddr(string advertiseAddr)
        {
            WithArgumentsValueRequired("advertise-addr", advertiseAddr.ToString());
            return this;
        }

        /// <summary>
        /// Availability of the node ("active"|"pause"|"drain")
        /// </summary>
        public DockerSwarmJoinTask Availability(string availability)
        {
            WithArgumentsValueRequired("availability", availability.ToString());
            return this;
        }

        /// <summary>
        /// Address or interface to use for data path traffic (format: <ip|interface>)

        /// </summary>
        public DockerSwarmJoinTask DataPathAddr(string dataPathAddr)
        {
            WithArgumentsValueRequired("data-path-addr", dataPathAddr.ToString());
            return this;
        }

        /// <summary>
        /// Listen address (format: <ip|interface>[:port])
        /// </summary>
        public DockerSwarmJoinTask ListenAddr(string listenAddr)
        {
            WithArgumentsValueRequired("listen-addr", listenAddr.ToString());
            return this;
        }

        /// <summary>
        /// Token for entry into the swarm
        /// </summary>
        public DockerSwarmJoinTask Token(string token)
        {
            WithArgumentsValueRequired("token", token.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_host);

            return base.DoExecute(context);
        }

     }
}
