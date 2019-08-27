
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Tasks.Docker.Manifest;

namespace FlubuCore.Context.FluentInterface.Docker
{
    public class Manifest
    {  
        
            
        /// <summary>
        /// Add additional information to a local image manifest
        /// </summary>
            public DockerManifestAnnotateTask ManifestAnnotate(string manifest_list ,  string manifest)
            {
                return new DockerManifestAnnotateTask(manifest_list,  manifest);
            }


            
        /// <summary>
        /// Create a local manifest list for annotating and pushing to a registry
        /// </summary>
            public DockerManifestCreateTask ManifestCreate(string manifest_list ,  params string[] manifest)
            {
                return new DockerManifestCreateTask(manifest_list,  manifest);
            }


            
        /// <summary>
        /// Display an image manifest, or manifest list
        /// </summary>
            public DockerManifestInspectTask ManifestInspect(string manifest_list = null ,  string manifest)
            {
                return new DockerManifestInspectTask(manifest_list,  manifest);
            }


            
        /// <summary>
        /// Push a manifest list to a repository
        /// </summary>
            public DockerManifestPushTask ManifestPush(string manifest_list)
            {
                return new DockerManifestPushTask(manifest_list);
            }

        
    }
}

