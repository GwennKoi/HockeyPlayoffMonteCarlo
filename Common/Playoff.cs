namespace HockeyPlayoffs.Common
{
    public class Playoff
    {
        public Playoff DeepCopy()
        {
            Playoff other = new Playoff();

            other.CentralFirstSeed = CentralFirstSeed?.DeepCopy();
            other.CentralSecondSeed = CentralSecondSeed?.DeepCopy();

            other.PacificFirstSeed = PacificFirstSeed?.DeepCopy();
            other.PacificSecondSeed = PacificSecondSeed?.DeepCopy();

            other.AtlanticFirstSeed = AtlanticFirstSeed?.DeepCopy();
            other.AtlanticSecondSeed = AtlanticSecondSeed?.DeepCopy();

            other.MetroFirstSeed = MetroFirstSeed?.DeepCopy();
            other.MetroSecondSeed = MetroSecondSeed?.DeepCopy();

            other.CentralTitle = CentralTitle?.DeepCopy();
            other.PacificTitle = PacificTitle?.DeepCopy();
            other.AtlanticTitle = AtlanticTitle?.DeepCopy();
            other.MetroTitle = MetroTitle?.DeepCopy();

            other.WesternTitle = WesternTitle?.DeepCopy();
            other.EasternTitle = EasternTitle?.DeepCopy();

            other.Championship = Championship?.DeepCopy();

            return other;
        }
        

        public Series Championship { get; set; }

        public Series WesternTitle { get; set; }

        public Series CentralTitle { get; set; }
        public Series CentralFirstSeed { get; set; }
        public Series CentralSecondSeed { get; set; }

        public Series PacificTitle { get; set; }
        public Series PacificFirstSeed { get; set; }
        public Series PacificSecondSeed { get; set; }

        public Series EasternTitle { get; set; }

        public Series AtlanticTitle { get; set; }
        public Series AtlanticFirstSeed { get; set; }
        public Series AtlanticSecondSeed { get; set; }

        public Series MetroTitle { get; set; }
        public Series MetroFirstSeed { get; set; }
        public Series MetroSecondSeed { get; set; }
    }
}
