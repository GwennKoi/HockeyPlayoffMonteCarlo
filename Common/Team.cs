namespace HockeyPlayoffs.Common
{
    using System;
    using Newtonsoft.Json;

    public class Team
    {
        public Team()
        {
        }

        [JsonConstructor]
        public Team(string name, int points,int strength)
        {
            Name = name;
            Points = points;
            Strength = strength;
        }

        public string Name { get; set; }

        public int Strength { get; set; }

        internal Team DeepCopy()
        {
            Team other = (Team)this.MemberwiseClone();

            other.Name = string.Copy(Name);

            return other;
        }

        public int Points { get; set; }

        public string ToString()
        {
            return Name ?? string.Empty;
        }
    }
}
