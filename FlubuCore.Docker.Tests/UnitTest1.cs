using System;
using System.IO;
using Xunit;
using YamlDotNet.Serialization;

namespace FlubuCore.Docker.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var yml = File.ReadAllText("docker_run.yaml");
            var deserializer = new Deserializer();
            var ret = new StringReader(yml);
            var ymlObject = deserializer.Deserialize(ret);

            var w = new StringWriter();
            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
            js.Serialize(w, ymlObject);
            string jsonText = w.ToString();
            File.WriteAllText("docker_run.json", jsonText);
        }
    }
}
