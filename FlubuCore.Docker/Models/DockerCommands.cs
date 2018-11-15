using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlubuCore.Docker.Models
{
    public class DockerCommands
    {
        public const string OptionKey = "[OPTIONS]";

        public List<string> BeforeOptions { get; set; } = new List<string>();

        public List<string> AfterOptions { get; set; } = new List<string>();
    }
}
