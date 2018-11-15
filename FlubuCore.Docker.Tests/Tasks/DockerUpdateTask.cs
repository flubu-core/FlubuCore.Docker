
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerUpdateTask : ExternalProcessTaskBase<DockerUpdateTask>
     {
        private string[] _container;

        
        public DockerUpdateTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("update");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Block IO (relative weight), between 10 and 1000, or 0 to disable (default 0)

        /// </summary>
        public DockerUpdateTask BlkioWeight(string blkioWeight)
        {
            WithArgumentsValueRequired("blkio-weight", blkioWeight.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) period
        /// </summary>
        public DockerUpdateTask CpuPeriod(long cpuPeriod)
        {
            WithArgumentsValueRequired("cpu-period", cpuPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) quota
        /// </summary>
        public DockerUpdateTask CpuQuota(long cpuQuota)
        {
            WithArgumentsValueRequired("cpu-quota", cpuQuota.ToString());
            return this;
        }

        /// <summary>
        /// Limit the CPU real-time period in microseconds
        /// </summary>
        public DockerUpdateTask CpuRtPeriod(long cpuRtPeriod)
        {
            WithArgumentsValueRequired("cpu-rt-period", cpuRtPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit the CPU real-time runtime in microseconds
        /// </summary>
        public DockerUpdateTask CpuRtRuntime(long cpuRtRuntime)
        {
            WithArgumentsValueRequired("cpu-rt-runtime", cpuRtRuntime.ToString());
            return this;
        }

        /// <summary>
        /// CPU shares (relative weight)
        /// </summary>
        public DockerUpdateTask CpuShares(long cpuShares)
        {
            WithArgumentsValueRequired("cpu-shares", cpuShares.ToString());
            return this;
        }

        /// <summary>
        /// Number of CPUs
        /// </summary>
        public DockerUpdateTask Cpus(decimal cpus)
        {
            WithArgumentsValueRequired("cpus", cpus.ToString());
            return this;
        }

        /// <summary>
        /// CPUs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerUpdateTask CpusetCpus(string cpusetCpus)
        {
            WithArgumentsValueRequired("cpuset-cpus", cpusetCpus.ToString());
            return this;
        }

        /// <summary>
        /// MEMs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerUpdateTask CpusetMems(string cpusetMems)
        {
            WithArgumentsValueRequired("cpuset-mems", cpusetMems.ToString());
            return this;
        }

        /// <summary>
        /// Kernel memory limit
        /// </summary>
        public DockerUpdateTask KernelMemory(string kernelMemory)
        {
            WithArgumentsValueRequired("kernel-memory", kernelMemory.ToString());
            return this;
        }

        /// <summary>
        /// Memory limit
        /// </summary>
        public DockerUpdateTask Memory(string memory)
        {
            WithArgumentsValueRequired("memory", memory.ToString());
            return this;
        }

        /// <summary>
        /// Memory soft limit
        /// </summary>
        public DockerUpdateTask MemoryReservation(string memoryReservation)
        {
            WithArgumentsValueRequired("memory-reservation", memoryReservation.ToString());
            return this;
        }

        /// <summary>
        /// Swap limit equal to memory plus swap: '-1' to enable unlimited swap

        /// </summary>
        public DockerUpdateTask MemorySwap(string memorySwap)
        {
            WithArgumentsValueRequired("memory-swap", memorySwap.ToString());
            return this;
        }

        /// <summary>
        /// Restart policy to apply when a container exits
        /// </summary>
        public DockerUpdateTask Restart(string restart)
        {
            WithArgumentsValueRequired("restart", restart.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_container);

            return base.DoExecute(context);
        }

     }
}
