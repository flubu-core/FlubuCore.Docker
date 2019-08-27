
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Volume;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Volume
    {  
        
            
        /// <summary>
        /// Create a volume
        /// </summary>
            public DockerVolumeCreateTask VolumeCreate(string volume = null)
            {
                return new DockerVolumeCreateTask(volume);
            }


            
        /// <summary>
        /// Display detailed information on one or more volumes
        /// </summary>
            public DockerVolumeInspectTask VolumeInspect(params string[] volume)
            {
                return new DockerVolumeInspectTask(volume);
            }


            
        /// <summary>
        /// List volumes
        /// </summary>
            public DockerVolumeLsTask VolumeLs()
            {
                return new DockerVolumeLsTask();
            }


            
        /// <summary>
        /// Remove all unused local volumes
        /// </summary>
            public DockerVolumePruneTask VolumePrune()
            {
                return new DockerVolumePruneTask();
            }


            
        /// <summary>
        /// Remove one or more volumes
        /// </summary>
            public DockerVolumeRmTask VolumeRm(params string[] volume)
            {
                return new DockerVolumeRmTask(volume);
            }

        
    }
}

