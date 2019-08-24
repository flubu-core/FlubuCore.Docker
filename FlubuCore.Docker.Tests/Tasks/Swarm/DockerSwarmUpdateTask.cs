
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Swarm
{
     public partial class DockerSwarmUpdateTask : ExternalProcessTaskBase<int, DockerSwarmUpdateTask>
     {
        
        
        public DockerSwarmUpdateTask()
        {
            ExecutablePath = "docker";
            WithArgumentsKeyFromAttribute();

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Change manager autolocking setting (true|false)
        /// </summary>
        [ArgKey("autolock")]
        public DockerSwarmUpdateTask Autolock()
        {
            WithArgumentsKeyFromAttribute();
            return this;
        }

        /// <summary>
        /// Validity period for node certificates (ns|us|ms|s|m|h)
        /// </summary>
        [ArgKey("cert-expiry")]
        public DockerSwarmUpdateTask CertExpiry(string certExpiry)
        {
            WithArgumentsKeyFromAttribute(certExpiry.ToString());
            return this;
        }

        /// <summary>
        /// Dispatcher heartbeat period (ns|us|ms|s|m|h)
        /// </summary>
        [ArgKey("dispatcher-heartbeat")]
        public DockerSwarmUpdateTask DispatcherHeartbeat(string dispatcherHeartbeat)
        {
            WithArgumentsKeyFromAttribute(dispatcherHeartbeat.ToString());
            return this;
        }

        /// <summary>
        /// Specifications of one or more certificate signing endpoints
        /// </summary>
        [ArgKey("external-ca")]
        public DockerSwarmUpdateTask ExternalCa(string externalCa)
        {
            WithArgumentsKeyFromAttribute(externalCa.ToString());
            return this;
        }

        /// <summary>
        /// Number of additional Raft snapshots to retain
        /// </summary>
        [ArgKey("max-snapshots")]
        public DockerSwarmUpdateTask MaxSnapshots(ulong maxSnapshots)
        {
            WithArgumentsKeyFromAttribute(maxSnapshots.ToString());
            return this;
        }

        /// <summary>
        /// Number of log entries between Raft snapshots
        /// </summary>
        [ArgKey("snapshot-interval")]
        public DockerSwarmUpdateTask SnapshotInterval(ulong snapshotInterval)
        {
            WithArgumentsKeyFromAttribute(snapshotInterval.ToString());
            return this;
        }

        /// <summary>
        /// Task history retention limit
        /// </summary>
        [ArgKey("task-history-limit")]
        public DockerSwarmUpdateTask TaskHistoryLimit(long taskHistoryLimit)
        {
            WithArgumentsKeyFromAttribute(taskHistoryLimit.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
            
            return base.DoExecute(context);
        }

     }
}
