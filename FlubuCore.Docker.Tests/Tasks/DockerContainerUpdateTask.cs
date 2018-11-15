
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerContainerUpdateTask : ExternalProcessTaskBase<DockerContainerUpdateTask>
     {
        private string[] _container;

        
        public DockerContainerUpdateTask(params string[] container)
        {
            ExecutablePath = "docker";
            WithArguments("container update");
_container = container;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Block IO (relative weight), between 10 and 1000, or 0 to disable (default 0)

        /// </summary>
        public DockerContainerUpdateTask BlkioWeight(string blkioWeight)
        {
            WithArgumentsValueRequired("blkio-weight", blkioWeight.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) period
        /// </summary>
        public DockerContainerUpdateTask CpuPeriod(long cpuPeriod)
        {
            WithArgumentsValueRequired("cpu-period", cpuPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit CPU CFS (Completely Fair Scheduler) quota
        /// </summary>
        public DockerContainerUpdateTask CpuQuota(long cpuQuota)
        {
            WithArgumentsValueRequired("cpu-quota", cpuQuota.ToString());
            return this;
        }

        /// <summary>
        /// Limit the CPU real-time period in microseconds
        /// </summary>
        public DockerContainerUpdateTask CpuRtPeriod(long cpuRtPeriod)
        {
            WithArgumentsValueRequired("cpu-rt-period", cpuRtPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit the CPU real-time runtime in microseconds
        /// </summary>
        public DockerContainerUpdateTask CpuRtRuntime(long cpuRtRuntime)
        {
            WithArgumentsValueRequired("cpu-rt-runtime", cpuRtRuntime.ToString());
            return this;
        }

        /// <summary>
        /// CPU shares (relative weight)
        /// </summary>
        public DockerContainerUpdateTask CpuShares(long cpuShares)
        {
            WithArgumentsValueRequired("cpu-shares", cpuShares.ToString());
            return this;
        }

        /// <summary>
        /// Number of CPUs
        /// </summary>
        public DockerContainerUpdateTask Cpus(decimal cpus)
        {
            WithArgumentsValueRequired("cpus", cpus.ToString());
            return this;
        }

        /// <summary>
        /// CPUs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerContainerUpdateTask CpusetCpus(string cpusetCpus)
        {
            WithArgumentsValueRequired("cpuset-cpus", cpusetCpus.ToString());
            return this;
        }

        /// <summary>
        /// MEMs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerContainerUpdateTask CpusetMems(string cpusetMems)
        {
            WithArgumentsValueRequired("cpuset-mems", cpusetMems.ToString());
            return this;
        }

        /// <summary>
        /// Kernel memory limit
        /// </summary>
        public DockerContainerUpdateTask KernelMemory(string kernelMemory)
        {
            WithArgumentsValueRequired("kernel-memory", kernelMemory.ToString());
            return this;
        }

        /// <summary>
        /// Memory limit
        /// </summary>
        public DockerContainerUpdateTask Memory(string memory)
        {
            WithArgumentsValueRequired("memory", memory.ToString());
            return this;
        }

        /// <summary>
        /// Memory soft limit
        /// </summary>
        public DockerContainerUpdateTask MemoryReservation(string memoryReservation)
        {
            WithArgumentsValueRequired("memory-reservation", memoryReservation.ToString());
            return this;
        }

        /// <summary>
        /// Swap limit equal to memory plus swap: '-1' to enable unlimited swap

        /// </summary>
        public DockerContainerUpdateTask MemorySwap(string memorySwap)
        {
            WithArgumentsValueRequired("memory-swap", memorySwap.ToString());
            return this;
        }

        /// <summary>
        /// Restart policy to apply when a container exits
        /// </summary>
        public DockerContainerUpdateTask Restart(string restart)
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
