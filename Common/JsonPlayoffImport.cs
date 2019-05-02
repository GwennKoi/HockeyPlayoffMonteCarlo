using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Common
{
    using Newtonsoft.Json;

    public class JsonPlayoffImport
    {
        [JsonProperty(PropertyName = "east")]
        public JsonEasternConference EasternConference { get; set; }
        [JsonProperty(PropertyName = "west")]
        public JsonWesternConference WesternConference { get; set; }
    }

    public class JsonEasternConference
    {
        [JsonProperty(PropertyName = "atlantic")]
        public JsonDivision Atlantic { get; set; }

        [JsonProperty(PropertyName = "metropolitan")]
        public JsonDivision Metro { get; set; }
    }

    public class JsonWesternConference
    {
        [JsonProperty(PropertyName = "central")]
        public JsonDivision Central { get; set; }

        [JsonProperty(PropertyName = "pacific")]
        public JsonDivision Pacific { get; set; }
    }

    public class JsonDivision
    {
        [JsonProperty(PropertyName = "1")]
        public JsonMatchup FirstSeed { get; set; }

        [JsonProperty(PropertyName = "2")]
        public JsonMatchup SecondSeed { get; set; }
    }

    public class JsonMatchup
    {
        public Team Home { get; set; }
        public Team Away { get; set; }
    }
}
