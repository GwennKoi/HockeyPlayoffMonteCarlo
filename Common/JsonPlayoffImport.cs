using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Common
{
    using Newtonsoft.Json;

    public class JsonPlayoffImport
    {
        [JsonProperty(PropertyName = "a")]
        public JsonEasternConference EasternConference { get; set; }
        [JsonProperty(PropertyName = "b")]
        public JsonWesternConference WesternConference { get; set; }
    }

    public class JsonEasternConference
    {
        [JsonProperty(PropertyName = "east")]
        public JsonDivision Atlantic { get; set; }

        [JsonProperty(PropertyName = "central")]
        public JsonDivision Metro { get; set; }
    }

    public class JsonWesternConference
    {
        [JsonProperty(PropertyName = "west")]
        public JsonDivision Central { get; set; }

        [JsonProperty(PropertyName = "north")]
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
        [JsonProperty(PropertyName = "home")]
        public Team Home { get; set; }
        [JsonProperty(PropertyName = "away")]
        public Team Away { get; set; }
    }
}
