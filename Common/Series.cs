namespace HockeyPlayoffs.Common
{
    using System;
    using Services;

    public class Series
    {
        public Series()
        {

        }

        public Series(Team homeTeam, Team awayTeam)
        {
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }

        internal Series DeepCopy()
        {
            Series other = new Series();

            other.HomeTeam = HomeTeam.DeepCopy();
            other.HomeScore = HomeScore;
            other.AwayTeam = AwayTeam.DeepCopy();
            other.AwayScore = AwayScore;

            return other;
        }

        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public Team WinningTeam
        {
            get
            {
                if (HomeScore == 4)
                {
                    return HomeTeam;
                } else if (AwayScore == 4)
                {
                    return AwayTeam;
                }

                return null;
            }
        }

        public int HomeScore { get; set; }
        public int AwayScore { get; set; }

        public int GamesPlayed
        {
            get { return HomeScore + AwayScore; }
        }

        public void PlaySeries()
        {
            while (WinningTeam == null)
            {
                 PlayGame();
            }
        }

        private void PlayGame()
        {
            Team winningTeam = ProbabilityService.RandomTeamWinByStrength(HomeTeam, AwayTeam);
            if (winningTeam.Name == HomeTeam.Name)
            {
                HomeScore++;
            }
            else
            {
                AwayScore++;
            }
        }

        public string ToString()
        {
            if (WinningTeam == null)
            {
                return string.Format($"{HomeTeam.Name} {HomeScore} - {AwayTeam.Name} {AwayScore}");
            }

            return string.Format($"{WinningTeam.Name} {GamesPlayed}");
        }

    }
}
