
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker
{
     public partial class DockerBuildTask : ExternalProcessTaskBase<DockerBuildTask>
     {
        private string _pathOrURL;

        
        public DockerBuildTask(string pathOrURL)
        {
            ExecutablePath = "docker";
            WithArguments("build");
_pathOrURL = pathOrURL;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Add a custom host-to-IP mapping (host:ip)
        /// </summary>
        public DockerBuildTask AddHost(string addHost)
        {
            WithArgumentsValueRequired("add-host", addHost.ToString());
            return this;
        }

        /// <summary>
        /// Set build-time variables
        /// </summary>
        public DockerBuildTask BuildArg(string buildArg)
        {
            WithArgumentsValueRequired("build-arg", buildArg.ToString());
            return this;
        }

        /// <summary>
        /// Images to consider as cache sources
        /// </summary>
        public DockerBuildTask CacheFrom(string cacheFrom)
        {
            WithArgumentsValueRequired("cache-from", cacheFrom.ToString());
            return this;
        }

        /// <summary>
        /// Optional parent cgroup for the container
        /// </summary>
        public DockerBuildTask CgroupParent(string cgroupParent)
        {
            WithArgumentsValueRequired("cgroup-parent", cgroupParent.ToString());
            return this;
        }

        /// <summary>
        /// Compress the build context using gzip
        /// </summary>
        public DockerBuildTask Compress()
        {
            WithArguments("compress");
            return this;
        }

        /// <summary>
        /// Limit the CPU CFS (Completely Fair Scheduler) period
        /// </summary>
        public DockerBuildTask CpuPeriod(long cpuPeriod)
        {
            WithArgumentsValueRequired("cpu-period", cpuPeriod.ToString());
            return this;
        }

        /// <summary>
        /// Limit the CPU CFS (Completely Fair Scheduler) quota
        /// </summary>
        public DockerBuildTask CpuQuota(long cpuQuota)
        {
            WithArgumentsValueRequired("cpu-quota", cpuQuota.ToString());
            return this;
        }

        /// <summary>
        /// CPU shares (relative weight)
        /// </summary>
        public DockerBuildTask CpuShares(long cpuShares)
        {
            WithArgumentsValueRequired("cpu-shares", cpuShares.ToString());
            return this;
        }

        /// <summary>
        /// CPUs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerBuildTask CpusetCpus(string cpusetCpus)
        {
            WithArgumentsValueRequired("cpuset-cpus", cpusetCpus.ToString());
            return this;
        }

        /// <summary>
        /// MEMs in which to allow execution (0-3, 0,1)
        /// </summary>
        public DockerBuildTask CpusetMems(string cpusetMems)
        {
            WithArgumentsValueRequired("cpuset-mems", cpusetMems.ToString());
            return this;
        }

        /// <summary>
        /// Skip image verification
        /// </summary>
        public DockerBuildTask DisableContentTrust()
        {
            WithArguments("disable-content-trust");
            return this;
        }

        /// <summary>
        /// Name of the Dockerfile (Default is 'PATH/Dockerfile')
        /// </summary>
        public DockerBuildTask File(string file)
        {
            WithArgumentsValueRequired("file", file.ToString());
            return this;
        }

        /// <summary>
        /// Always remove intermediate containers
        /// </summary>
        public DockerBuildTask ForceRm()
        {
            WithArguments("force-rm");
            return this;
        }

        /// <summary>
        /// Write the image ID to the file
        /// </summary>
        public DockerBuildTask Iidfile(string iidfile)
        {
            WithArgumentsValueRequired("iidfile", iidfile.ToString());
            return this;
        }

        /// <summary>
        /// Container isolation technology
        /// </summary>
        public DockerBuildTask Isolation(string isolation)
        {
            WithArgumentsValueRequired("isolation", isolation.ToString());
            return this;
        }

        /// <summary>
        /// Set metadata for an image
        /// </summary>
        public DockerBuildTask Label(string label)
        {
            WithArgumentsValueRequired("label", label.ToString());
            return this;
        }

        /// <summary>
        /// Memory limit
        /// </summary>
        public DockerBuildTask Memory(string memory)
        {
            WithArgumentsValueRequired("memory", memory.ToString());
            return this;
        }

        /// <summary>
        /// Swap limit equal to memory plus swap: '-1' to enable unlimited swap

        /// </summary>
        public DockerBuildTask MemorySwap(string memorySwap)
        {
            WithArgumentsValueRequired("memory-swap", memorySwap.ToString());
            return this;
        }

        /// <summary>
        /// Set the networking mode for the RUN instructions during build

        /// </summary>
        public DockerBuildTask Network(string network)
        {
            WithArgumentsValueRequired("network", network.ToString());
            return this;
        }

        /// <summary>
        /// Do not use cache when building the image
        /// </summary>
        public DockerBuildTask NoCache()
        {
            WithArguments("no-cache");
            return this;
        }

        /// <summary>
        /// Set platform if server is multi-platform capable
        /// </summary>
        public DockerBuildTask Platform(string platform)
        {
            WithArgumentsValueRequired("platform", platform.ToString());
            return this;
        }

        /// <summary>
        /// Always attempt to pull a newer version of the image
        /// </summary>
        public DockerBuildTask Pull()
        {
            WithArguments("pull");
            return this;
        }

        /// <summary>
        /// Suppress the build output and print image ID on success
        /// </summary>
        public DockerBuildTask Quiet()
        {
            WithArguments("quiet");
            return this;
        }

        /// <summary>
        /// Remove intermediate containers after a successful build
        /// </summary>
        public DockerBuildTask Rm()
        {
            WithArguments("rm");
            return this;
        }

        /// <summary>
        /// Security options
        /// </summary>
        public DockerBuildTask SecurityOpt(string securityOpt)
        {
            WithArgumentsValueRequired("security-opt", securityOpt.ToString());
            return this;
        }

        /// <summary>
        /// Size of /dev/shm
        /// </summary>
        public DockerBuildTask ShmSize(string shmSize)
        {
            WithArgumentsValueRequired("shm-size", shmSize.ToString());
            return this;
        }

        /// <summary>
        /// Squash newly built layers into a single new layer
        /// </summary>
        public DockerBuildTask Squash()
        {
            WithArguments("squash");
            return this;
        }

        /// <summary>
        /// Stream attaches to server to negotiate build context
        /// </summary>
        public DockerBuildTask Stream()
        {
            WithArguments("stream");
            return this;
        }

        /// <summary>
        /// Name and optionally a tag in the 'name:tag' format
        /// </summary>
        public DockerBuildTask Tag(string tag)
        {
            WithArgumentsValueRequired("tag", tag.ToString());
            return this;
        }

        /// <summary>
        /// Set the target build stage to build.
        /// </summary>
        public DockerBuildTask Target(string target)
        {
            WithArgumentsValueRequired("target", target.ToString());
            return this;
        }

        /// <summary>
        /// Ulimit options
        /// </summary>
        public DockerBuildTask Ulimit(string ulimit)
        {
            WithArgumentsValueRequired("ulimit", ulimit.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_pathOrURL);

            return base.DoExecute(context);
        }

     }
}
