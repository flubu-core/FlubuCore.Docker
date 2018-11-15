// To parse this JSON data, add NuGet 'Newtonsoft.Json' then do:
//
//    using QuickType;
//
//    var docker = Docker.FromJson(jsonString);

using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FlubuCore.Docker.Models
{
    public partial class Docker
    {
        [JsonProperty("command")]
        public string Command { get; set; }

        [JsonProperty("short")]
        public string Short { get; set; }

        [JsonProperty("long")]
        public string Long { get; set; }

        [JsonProperty("usage")]
        public string Usage { get; set; }

        [JsonProperty("pname")]
        public string Pname { get; set; }

        [JsonProperty("plink")]
        public string Plink { get; set; }

        [JsonProperty("options")]
        public List<Option> Options { get; set; }

        [JsonProperty("examples")]
        public string Examples { get; set; }

        [JsonProperty("deprecated")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Deprecated { get; set; }

        [JsonProperty("experimental")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Experimental { get; set; }

        [JsonProperty("experimentalcli")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Experimentalcli { get; set; }

        [JsonProperty("kubernetes")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Kubernetes { get; set; }

        [JsonProperty("swarm")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Swarm { get; set; }
    }

    public partial class Option
    {
        [JsonProperty("option")]
        public string OptionOption { get; set; }

        [JsonProperty("value_type")]
        public string ValueType { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("deprecated")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Deprecated { get; set; }

        [JsonProperty("experimental")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Experimental { get; set; }

        [JsonProperty("experimentalcli")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Experimentalcli { get; set; }

        [JsonProperty("kubernetes")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Kubernetes { get; set; }

        [JsonProperty("swarm")]
        [JsonConverter(typeof(ParseStringConverter))]
        public bool Swarm { get; set; }

        [JsonProperty("shorthand", NullValueHandling = NullValueHandling.Ignore)]
        public string Shorthand { get; set; }

        [JsonProperty("default_value", NullValueHandling = NullValueHandling.Ignore)]
        public string DefaultValue { get; set; }

        [JsonProperty("min_api_version", NullValueHandling = NullValueHandling.Ignore)]
        public string MinApiVersion { get; set; }
    }

    public partial class Docker
    {
        public static Docker FromJson(string json) => JsonConvert.DeserializeObject<Docker>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this Docker self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ParseStringConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(bool) || t == typeof(bool?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            bool b;
            if (Boolean.TryParse(value, out b))
            {
                return b;
            }
            throw new Exception("Cannot unmarshal type bool");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (bool)untypedValue;
            var boolString = value ? "true" : "false";
            serializer.Serialize(writer, boolString);
            return;
        }

        public static readonly ParseStringConverter Singleton = new ParseStringConverter();
    }
}
