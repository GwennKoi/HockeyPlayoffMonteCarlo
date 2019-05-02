using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Services
{
    using System.IO;
    using System.Linq;
    using System.Reflection.Metadata;
    using Common;
    using Newtonsoft.Json;

    public static class PlayoffService
    {
        public static Playoff PopulatePlayoff(string path)
        {
            Playoff playoff = new Playoff();
            Team firstTeam, lastTeam;

            JsonPlayoffImport import = JsonConvert.DeserializeObject<JsonPlayoffImport>(File.ReadAllText(path));

            //Central 1st Seed Game
            firstTeam = import.WesternConference.Central.FirstSeed.Home;
            lastTeam = import.WesternConference.Central.FirstSeed.Away;
            playoff.CentralFirstSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Central 2nd Seed Game
            firstTeam = import.WesternConference.Central.SecondSeed.Home;
            lastTeam = import.WesternConference.Central.SecondSeed.Away;
            playoff.CentralSecondSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Pacific 1st Seed Game
            firstTeam = import.WesternConference.Pacific.FirstSeed.Home;
            lastTeam = import.WesternConference.Pacific.FirstSeed.Away;
            playoff.PacificFirstSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Pacific 2nd Seed Game
            firstTeam = import.WesternConference.Pacific.SecondSeed.Home;
            lastTeam = import.WesternConference.Pacific.SecondSeed.Away;
            playoff.PacificSecondSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Atlantic 1st Seed Game
            firstTeam = import.EasternConference.Atlantic.FirstSeed.Home;
            lastTeam = import.EasternConference.Atlantic.FirstSeed.Away;
            playoff.AtlanticFirstSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Atlantic 2nd Seed Game
            firstTeam = import.EasternConference.Atlantic.SecondSeed.Home;
            lastTeam = import.EasternConference.Atlantic.SecondSeed.Away;
            playoff.AtlanticSecondSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Metro 1st Seed Game
            firstTeam = import.EasternConference.Metro.FirstSeed.Home;
            lastTeam = import.EasternConference.Metro.FirstSeed.Away;
            playoff.MetroFirstSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            //Metro 2nd Seed Game
            firstTeam = import.EasternConference.Metro.SecondSeed.Home;
            lastTeam = import.EasternConference.Metro.SecondSeed.Away;
            playoff.MetroSecondSeed = SeriesService.SetupSeries(firstTeam, lastTeam);

            return playoff;
        }

        public static Playoff RunPlayoffs(Playoff bracket)
        {
            //Atlantic Division
            bracket.AtlanticFirstSeed.PlaySeries();
            bracket.AtlanticSecondSeed.PlaySeries();
            if (bracket.AtlanticTitle == null)
            {
                bracket.AtlanticTitle = SeriesService.SeedSeries(
                    bracket.AtlanticFirstSeed.WinningTeam,
                    bracket.AtlanticSecondSeed.WinningTeam
                );
            }
            bracket.AtlanticTitle.PlaySeries();

            //Pacific Division
            bracket.PacificFirstSeed.PlaySeries();
            bracket.PacificSecondSeed.PlaySeries();
            if (bracket.PacificTitle == null)
            {
                bracket.PacificTitle = SeriesService.SeedSeries(
                    bracket.PacificFirstSeed.WinningTeam,
                    bracket.PacificSecondSeed.WinningTeam
                );
            }
            bracket.PacificTitle.PlaySeries();

            //Central Division
            bracket.CentralFirstSeed.PlaySeries();
            bracket.CentralSecondSeed.PlaySeries();
            if (bracket.CentralTitle == null)
            {
                bracket.CentralTitle = SeriesService.SeedSeries(
                    bracket.CentralFirstSeed.WinningTeam,
                    bracket.CentralSecondSeed.WinningTeam
                );
            }
            bracket.CentralTitle.PlaySeries();

            //Metro Division
            bracket.MetroFirstSeed.PlaySeries();
            bracket.MetroSecondSeed.PlaySeries();
            if (bracket.MetroTitle == null)
            {
                bracket.MetroTitle = SeriesService.SeedSeries(
                    bracket.MetroFirstSeed.WinningTeam,
                    bracket.MetroSecondSeed.WinningTeam
                );
            }
            bracket.MetroTitle.PlaySeries();

            //Eastern Title
            if (bracket.EasternTitle == null)
            {
                bracket.EasternTitle = SeriesService.SeedSeries(bracket.AtlanticTitle.WinningTeam, bracket.MetroTitle.WinningTeam);
            }
            bracket.EasternTitle.PlaySeries();

            //Western Title
            if (bracket.WesternTitle == null)
            {
                bracket.WesternTitle = SeriesService.SeedSeries(bracket.CentralTitle.WinningTeam, bracket.PacificTitle.WinningTeam);
            }
            bracket.WesternTitle.PlaySeries();

            //Stanley Cup Finals
            if (bracket.Championship == null)
            {
                bracket.Championship = SeriesService.SeedSeries(bracket.EasternTitle.WinningTeam, bracket.WesternTitle.WinningTeam);
            }
            bracket.Championship.PlaySeries();

            return bracket;
        }

    }
}
