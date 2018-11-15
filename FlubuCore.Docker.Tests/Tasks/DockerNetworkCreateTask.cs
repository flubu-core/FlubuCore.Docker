
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerNetworkCreateTask : ExternalProcessTaskBase<DockerNetworkCreateTask>
     {
        private string _network;

        
        public DockerNetworkCreateTask(string network)
        {
            ExecutablePath = "docker";
            WithArguments("network create");
_network = network;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Enable manual container attachment
        /// </summary>
        public DockerNetworkCreateTask Attachable()
        {
            WithArguments("attachable");
            return this;
        }

        /// <summary>
        /// Auxiliary IPv4 or IPv6 addresses used by Network driver
        /// </summary>
        public DockerNetworkCreateTask AuxAddress(string auxAddress)
        {
            WithArgumentsValueRequired("aux-address", auxAddress.ToString());
            return this;
        }

        /// <summary>
        /// The network from which copying the configuration
        /// </summary>
        public DockerNetworkCreateTask ConfigFrom(string configFrom)
        {
            WithArgumentsValueRequired("config-from", configFrom.ToString());
            return this;
        }

        /// <summary>
        /// Create a configuration only network
        /// </summary>
        public DockerNetworkCreateTask ConfigOnly()
        {
            WithArguments("config-only");
            return this;
        }

        /// <summary>
        /// Driver to manage the Network
        /// </summary>
        public DockerNetworkCreateTask Driver(string driver)
        {
            WithArgumentsValueRequired("driver", driver.ToString());
            return this;
        }

        /// <summary>
        /// IPv4 or IPv6 Gateway for the master subnet
        /// </summary>
        public DockerNetworkCreateTask Gateway(string gateway)
        {
            WithArgumentsValueRequired("gateway", gateway.ToString());
            return this;
        }

        /// <summary>
        /// Create swarm routing-mesh network
        /// </summary>
        public DockerNetworkCreateTask Ingress()
        {
            WithArguments("ingress");
            return this;
        }

        /// <summary>
        /// Restrict external access to the network
        /// </summary>
        public DockerNetworkCreateTask Internal()
        {
            WithArguments("internal");
            return this;
        }

        /// <summary>
        /// Allocate container ip from a sub-range
        /// </summary>
        public DockerNetworkCreateTask IpRange(string ipRange)
        {
            WithArgumentsValueRequired("ip-range", ipRange.ToString());
            return this;
        }

        /// <summary>
        /// IP Address Management Driver
        /// </summary>
        public DockerNetworkCreateTask IpamDriver(string ipamDriver)
        {
            WithArgumentsValueRequired("ipam-driver", ipamDriver.ToString());
            return this;
        }

        /// <summary>
        /// Set IPAM driver specific options
        /// </summary>
        public DockerNetworkCreateTask IpamOpt(string ipamOpt)
        {
            WithArgumentsValueRequired("ipam-opt", ipamOpt.ToString());
            return this;
        }

        /// <summary>
        /// Enable IPv6 networking
        /// </summary>
        public DockerNetworkCreateTask Ipv6()
        {
            WithArguments("ipv6");
            return this;
        }

        /// <summary>
        /// Set metadata on a network
        /// </summary>
        public DockerNetworkCreateTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Set driver specific options
        /// </summary>
        public DockerNetworkCreateTask Opt(string opt)
        {
            WithArgumentsValueRequired("opt", opt.ToString());
            return this;
        }

        /// <summary>
        /// Control the network's scope
        /// </summary>
        public DockerNetworkCreateTask Scope(string scope)
        {
            WithArgumentsValueRequired("scope", scope.ToString());
            return this;
        }

        /// <summary>
        /// Subnet in CIDR format that represents a network segment
        /// </summary>
        public DockerNetworkCreateTask Subnet(string subnet)
        {
            WithArgumentsValueRequired("subnet", subnet.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_network);

            return base.DoExecute(context);
        }

     }
}