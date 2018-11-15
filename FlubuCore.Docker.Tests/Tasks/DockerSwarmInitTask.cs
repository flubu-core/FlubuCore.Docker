
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmInitTask : ExternalProcessTaskBase<DockerSwarmInitTask>
     {
        
        
        public DockerSwarmInitTask()
        {
            ExecutablePath = "docker";
            WithArguments("swarm init");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Advertised address (format: <ip|interface>[:port])
        /// </summary>
        public DockerSwarmInitTask AdvertiseAddr(string advertiseAddr)
        {
            WithArgumentsValueRequired("advertise-addr", advertiseAddr.ToString());
            return this;
        }

        /// <summary>
        /// Enable manager autolocking (requiring an unlock key to start a stopped manager)

        /// </summary>
        public DockerSwarmInitTask Autolock()
        {
            WithArguments("autolock");
            return this;
        }

        /// <summary>
        /// Availability of the node ("active"|"pause"|"drain")
        /// </summary>
        public DockerSwarmInitTask Availability(string availability)
        {
            WithArgumentsValueRequired("availability", availability.ToString());
            return this;
        }

        /// <summary>
        /// Validity period for node certificates (ns|us|ms|s|m|h)
        /// </summary>
        public DockerSwarmInitTask CertExpiry(string certExpiry)
        {
            WithArgumentsValueRequired("cert-expiry", certExpiry.ToString());
            return this;
        }

        /// <summary>
        /// Address or interface to use for data path traffic (format: <ip|interface>)

        /// </summary>
        public DockerSwarmInitTask DataPathAddr(string dataPathAddr)
        {
            WithArgumentsValueRequired("data-path-addr", dataPathAddr.ToString());
            return this;
        }

        /// <summary>
        /// Dispatcher heartbeat period (ns|us|ms|s|m|h)
        /// </summary>
        public DockerSwarmInitTask DispatcherHeartbeat(string dispatcherHeartbeat)
        {
            WithArgumentsValueRequired("dispatcher-heartbeat", dispatcherHeartbeat.ToString());
            return this;
        }

        /// <summary>
        /// Specifications of one or more certificate signing endpoints
        /// </summary>
        public DockerSwarmInitTask ExternalCa(string externalCa)
        {
            WithArgumentsValueRequired("external-ca", externalCa.ToString());
            return this;
        }

        /// <summary>
        /// Force create a new cluster from current state
        /// </summary>
        public DockerSwarmInitTask ForceNewCluster()
        {
            WithArguments("force-new-cluster");
            return this;
        }

        /// <summary>
        /// Listen address (format: <ip|interface>[:port])
        /// </summary>
        public DockerSwarmInitTask ListenAddr(string listenAddr)
        {
            WithArgumentsValueRequired("listen-addr", listenAddr.ToString());
            return this;
        }

        /// <summary>
        /// Number of additional Raft snapshots to retain
        /// </summary>
        public DockerSwarmInitTask MaxSnapshots(ulong maxSnapshots)
        {
            WithArgumentsValueRequired("max-snapshots", maxSnapshots.ToString());
            return this;
        }

        /// <summary>
        /// Number of log entries between Raft snapshots
        /// </summary>
        public DockerSwarmInitTask SnapshotInterval(ulong snapshotInterval)
        {
            WithArgumentsValueRequired("snapshot-interval", snapshotInterval.ToString());
            return this;
        }

        /// <summary>
        /// Task history retention limit
        /// </summary>
        public DockerSwarmInitTask TaskHistoryLimit(long taskHistoryLimit)
        {
            WithArgumentsValueRequired("task-history-limit", taskHistoryLimit.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
