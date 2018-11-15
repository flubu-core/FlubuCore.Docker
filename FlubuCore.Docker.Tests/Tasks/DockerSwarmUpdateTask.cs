
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerSwarmUpdateTask : ExternalProcessTaskBase<DockerSwarmUpdateTask>
     {
        
        
        public DockerSwarmUpdateTask()
        {
            ExecutablePath = "docker";
            WithArguments("swarm update");

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Change manager autolocking setting (true|false)
        /// </summary>
        public DockerSwarmUpdateTask Autolock()
        {
            WithArguments("autolock");
            return this;
        }

        /// <summary>
        /// Validity period for node certificates (ns|us|ms|s|m|h)
        /// </summary>
        public DockerSwarmUpdateTask CertExpiry(string certExpiry)
        {
            WithArgumentsValueRequired("cert-expiry", certExpiry.ToString());
            return this;
        }

        /// <summary>
        /// Dispatcher heartbeat period (ns|us|ms|s|m|h)
        /// </summary>
        public DockerSwarmUpdateTask DispatcherHeartbeat(string dispatcherHeartbeat)
        {
            WithArgumentsValueRequired("dispatcher-heartbeat", dispatcherHeartbeat.ToString());
            return this;
        }

        /// <summary>
        /// Specifications of one or more certificate signing endpoints
        /// </summary>
        public DockerSwarmUpdateTask ExternalCa(string externalCa)
        {
            WithArgumentsValueRequired("external-ca", externalCa.ToString());
            return this;
        }

        /// <summary>
        /// Number of additional Raft snapshots to retain
        /// </summary>
        public DockerSwarmUpdateTask MaxSnapshots(ulong maxSnapshots)
        {
            WithArgumentsValueRequired("max-snapshots", maxSnapshots.ToString());
            return this;
        }

        /// <summary>
        /// Number of log entries between Raft snapshots
        /// </summary>
        public DockerSwarmUpdateTask SnapshotInterval(ulong snapshotInterval)
        {
            WithArgumentsValueRequired("snapshot-interval", snapshotInterval.ToString());
            return this;
        }

        /// <summary>
        /// Task history retention limit
        /// </summary>
        public DockerSwarmUpdateTask TaskHistoryLimit(long taskHistoryLimit)
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
