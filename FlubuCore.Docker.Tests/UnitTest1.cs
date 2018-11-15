using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Xunit;
using YamlDotNet.Serialization;

namespace FlubuCore.Docker.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void GetJsonFromYaml()
        {
            var yml = File.ReadAllText("docker_config_ls.yaml");
            var deserializer = new Deserializer();
            var ret = new StringReader(yml);
            var ymlObject = deserializer.Deserialize(ret);

            var w = new StringWriter();
            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
            js.Serialize(w, ymlObject);
            string jsonText = w.ToString();
            File.WriteAllText("docker_run.json", jsonText);
        }

        [Fact]
        public void DockerReaderTest()
        {
            var reader = new DockerReader();
            var docker = reader.Read(AppDomain.CurrentDomain.SetupInformation.ApplicationBase + "\\docs").ToList();
            docker = docker.Where(x => x.Command == "docker build").ToList();
            var parser = new DockerParser();
             parser.Parse(docker);
        }
    }
}
