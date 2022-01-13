using Newtonsoft.Json;
using System;

namespace MVP.Core.Entities
{
    public class User
    {
        [JsonProperty("IdUser")]
        public int IdUser { get; set; }

        [JsonProperty("Name")]
        public string Name { get; set; }

        [JsonProperty("BirthDate")]
        public DateTime BirthDate { get; set; }

        [JsonProperty("Active")]
        public bool Active { get; set; }
    }
}