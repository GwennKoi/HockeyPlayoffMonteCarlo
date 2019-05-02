using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Services
{
    using System.Xml;
    using Common;

    public static class SeriesService
    {
        public static Series SeedSeries(Team first, Team second)
        {
            //Yeah, I don't have tie-breakers, but this sim isn't smart enough to even need this check
            if (first.Points > second.Points)
            {
                return new Series(first, second);
            }
            return new Series(second,first);
        }

        public static Series SetupSeries(Team home, Team away)
        {
            return new Series(home, away);
        }

    }
}
