using System;

namespace HockeyPlayoffs
{
    using System.Data;
    using Common;
    using Data;
    using Services;

    class Program
    {
        static void Main(string[] args)
        {
            HockeyContext dbContext = new HockeyContext();
            Playoff cleanBracket = PlayoffService.PopulatePlayoff("playoffs.json");
            Playoff bracket;
            ////Start Current Standings
            //// ** First Round **
            ////NSH vs DAL
            //cleanBracket.CentralFirstSeed.HomeScore = 3;
            //cleanBracket.CentralFirstSeed.AwayScore = 4;
            //// WPG vs STL
            //cleanBracket.CentralSecondSeed.HomeScore = 2;
            //cleanBracket.CentralSecondSeed.AwayScore = 4;
            //// CGY vs COL
            //cleanBracket.PacificFirstSeed.HomeScore = 1;
            //cleanBracket.PacificFirstSeed.AwayScore = 4;
            //// SJS vs VGK
            //cleanBracket.PacificSecondSeed.HomeScore = 4;
            //cleanBracket.PacificSecondSeed.AwayScore = 3;
            //// TBL 0 vs CBJ 4
            //cleanBracket.AtlanticFirstSeed.AwayScore = 4;
            //// BOS vs TOR
            //cleanBracket.AtlanticSecondSeed.HomeScore = 4;
            //cleanBracket.AtlanticSecondSeed.AwayScore = 3;
            //// WSH vs CAR
            //cleanBracket.MetroFirstSeed.HomeScore = 3;
            //cleanBracket.MetroFirstSeed.AwayScore = 3;
            //// NYI 4 vs PIT 0
            //cleanBracket.MetroSecondSeed.HomeScore = 4;
            ////End Current Standings
            for (int i = 1; i <= 250000; i++)
            {
                bracket = cleanBracket.DeepCopy();
                PlayoffService.RunPlayoffs(bracket);

                PlayoffPossibility chance = new PlayoffPossibility();

                #region Round One

                chance.Central1Winner = bracket.CentralFirstSeed.WinningTeam.ToString();
                chance.Central1Games = bracket.CentralFirstSeed.GamesPlayed;
                chance.Central2Winner = bracket.CentralSecondSeed.WinningTeam.ToString();
                chance.Central2Games = bracket.CentralSecondSeed.GamesPlayed;

                chance.Pacific1Winner = bracket.PacificFirstSeed.WinningTeam.ToString();
                chance.Pacific1Games = bracket.PacificFirstSeed.GamesPlayed;
                chance.Pacific2Winner = bracket.PacificSecondSeed.WinningTeam.ToString();
                chance.Pacific2Games = bracket.PacificSecondSeed.GamesPlayed;

                chance.Atlantic1Winner = bracket.AtlanticFirstSeed.WinningTeam.ToString();
                chance.Atlantic1Games = bracket.AtlanticFirstSeed.GamesPlayed;
                chance.Atlantic2Winner = bracket.AtlanticSecondSeed.WinningTeam.ToString();
                chance.Atlantic2Games = bracket.AtlanticSecondSeed.GamesPlayed;

                chance.Metro1Winner = bracket.MetroFirstSeed.WinningTeam.ToString();
                chance.Metro1Games = bracket.MetroFirstSeed.GamesPlayed;
                chance.Metro2Winner = bracket.MetroSecondSeed.WinningTeam.ToString();
                chance.Metro2Games = bracket.MetroSecondSeed.GamesPlayed;


                #endregion

                #region Round Two

                chance.CentralWinner = bracket.CentralTitle.WinningTeam.ToString();
                chance.CentralGames = bracket.CentralTitle.GamesPlayed;

                chance.PacificWinner = bracket.PacificTitle.WinningTeam.ToString();
                chance.PacificGames = bracket.PacificTitle.GamesPlayed;

                chance.AtlanticWinner = bracket.AtlanticTitle.WinningTeam.ToString();
                chance.AtlanticGames = bracket.AtlanticTitle.GamesPlayed;

                chance.MetroWinner = bracket.MetroTitle.WinningTeam.ToString();
                chance.MetroGames = bracket.MetroTitle.GamesPlayed;


                #endregion

                #region Round Three

                chance.WesternWinner = bracket.WesternTitle.WinningTeam.ToString();
                chance.WesternGames = bracket.WesternTitle.GamesPlayed;

                chance.EasternWinner = bracket.EasternTitle.WinningTeam.ToString();
                chance.EasternGames = bracket.EasternTitle.GamesPlayed;

                #endregion

                #region Finals
                chance.ChampionshipsWinner = bracket.Championship.WinningTeam.ToString();
                chance.ChampionshipsGames = bracket.Championship.GamesPlayed;

                #endregion

                Console.WriteLine($"{i}");

                dbContext.PlayoffPossibilities.Add(chance);
                if (i % 5000 == 0)
                {
                    Console.WriteLine("Saving...");
                    dbContext.SaveChanges();
                }
            }

            dbContext.SaveChanges();
        }

    }
}

