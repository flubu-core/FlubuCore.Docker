using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using YamlDotNet.Serialization;

namespace FlubuCore.Docker
{
    public class DockerReader
    {
        public List<Models.Docker> Read(string directory = "docs")
        {
            var files = Directory.GetFiles(directory, "*.yaml", SearchOption.AllDirectories);

            List<string> Ymls = new List<string>();
            List<object> YmlObjects = new List<object>();
            foreach (var file in files)
            {
                Ymls.Add(File.ReadAllText(file));
            }

            var deserializer = new Deserializer();

            foreach (var yml in Ymls)
            {
                var ret = new StringReader(yml);
                YmlObjects.Add(deserializer.Deserialize(ret));
            }

            Newtonsoft.Json.JsonSerializer js = new Newtonsoft.Json.JsonSerializer();
            List<Models.Docker> dockerCommands = new List<Models.Docker>();
            foreach (var ymlObject in YmlObjects)
            {
                var w = new StringWriter();
                js.Serialize(w, ymlObject);
                string jsonText = w.ToString();
                dockerCommands.Add(Models.Docker.FromJson(jsonText));
            }

            return dockerCommands.Where(x => x.Usage != null).ToList();
        }
    }
}
