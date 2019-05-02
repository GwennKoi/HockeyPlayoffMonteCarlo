using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Common
{
    public class Bracket
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public KeyValuePair<string, int> CentralFirstSeed { get; set; }
        public KeyValuePair<string, int> CentralSecondSeed { get; set; }
        public KeyValuePair<string, int> PacificFirstSeed { get; set; }
        public KeyValuePair<string, int> PacificSecondSeed { get; set; }
        public KeyValuePair<string, int> AtlanticFirstSeed { get; set; }
        public KeyValuePair<string, int> AtlanticSecondSeed { get; set; }
        public KeyValuePair<string, int> MetroFirstSeed { get; set; }
        public KeyValuePair<string, int> MetroSecondSeed { get; set; }

        public KeyValuePair<string, int> CentralTitle { get; set; }
        public KeyValuePair<string, int> PacificTitle { get; set; }
        public KeyValuePair<string, int> AtlanticTitle { get; set; }
        public KeyValuePair<string, int> MetroTitle { get; set; }

        public KeyValuePair<string, int> WesternTitle { get; set; }
        public KeyValuePair<string, int> EasterTitle { get; set; }

        public KeyValuePair<string, int> StanleyCupChampion { get; set; }

    }
}
