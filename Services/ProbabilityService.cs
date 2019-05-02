using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs
{
    using Common;

    public static class ProbabilityService
    {
        public static Team RandomTeamWinByStrength(Team home, Team away)
        {
            int chance = (int)Math.Pow(home.Strength, 2) + (int)Math.Pow(away.Strength, 2);
            Random prob = new Random();

            return prob.Next(1, chance) <= (int)Math.Pow(home.Strength, 2) ? home : away;
        }
    }
}
