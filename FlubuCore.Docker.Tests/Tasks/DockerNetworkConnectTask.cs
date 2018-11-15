
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerNetworkConnectTask : ExternalProcessTaskBase<DockerNetworkConnectTask>
     {
        private string _network;
private string _container;

        
        public DockerNetworkConnectTask(string network,  string container)
        {
            ExecutablePath = "docker";
            WithArguments("network connect");
_network = network;
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add network-scoped alias for the container
        /// </summary>
        public DockerNetworkConnectTask Alias(string alias)
        {
            WithArgumentsValueRequired("alias", alias.ToString());
            return this;
        }

        /// <summary>
        /// IPv4 address (e.g., 172.30.100.104)
        /// </summary>
        public DockerNetworkConnectTask Ip(string ip)
        {
            WithArgumentsValueRequired("ip", ip.ToString());
            return this;
        }

        /// <summary>
        /// IPv6 address (e.g., 2001:db8::33)
        /// </summary>
        public DockerNetworkConnectTask Ip6(string ip6)
        {
            WithArgumentsValueRequired("ip6", ip6.ToString());
            return this;
        }

        /// <summary>
        /// Add link to another container
        /// </summary>
        public DockerNetworkConnectTask Link(string link)
        {
            WithArgumentsValueRequired("link", link.ToString());
            return this;
        }

        /// <summary>
        /// Add a link-local address for the container
        /// </summary>
        public DockerNetworkConnectTask LinkLocalIp(string linkLocalIp)
        {
            WithArgumentsValueRequired("link-local-ip", linkLocalIp.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_network);
 WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
