using System;
using System.Collections.Generic;
using System.Text;

namespace HockeyPlayoffs.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class PlayoffPossibility
    {
        public int PlayoffPossibilityId { get; set; }

        #region Round One

        //Central
        [StringLength(3)]
        public string Central1Winner { get; set; }
        public int Central1Games { get; set; }

        [StringLength(3)]
        public string Central2Winner { get; set; }
        public int Central2Games { get; set; }

        //Pacific
        [StringLength(3)]
        public string Pacific1Winner { get; set; }
        public int Pacific1Games { get; set; }

        [StringLength(3)]
        public string Pacific2Winner { get; set; }
        public int Pacific2Games { get; set; }

        //Atlantic
        [StringLength(3)]
        public string Atlantic1Winner { get; set; }
        public int Atlantic1Games { get; set; }

        [StringLength(3)]
        public string Atlantic2Winner { get; set; }
        public int Atlantic2Games { get; set; }

        //Metro
        [StringLength(3)]
        public string Metro1Winner { get; set; }
        public int Metro1Games { get; set; }

        [StringLength(3)]
        public string Metro2Winner { get; set; }
        public int Metro2Games { get; set; }

        #endregion

        #region Round Two
        //Central
        [StringLength(3)]
        public string CentralWinner { get; set; }
        public int CentralGames { get; set; }

        //Pacific
        [StringLength(3)]
        public string PacificWinner { get; set; }
        public int PacificGames { get; set; }

        //Atlantic
        [StringLength(3)]
        public string AtlanticWinner { get; set; }
        public int AtlanticGames { get; set; }

        //Metro
        [StringLength(3)]
        public string MetroWinner { get; set; }
        public int MetroGames { get; set; }

        #endregion

        #region Round Three

        //Western
        [StringLength(3)]
        public string WesternWinner { get; set; }
        public int WesternGames { get; set; }

        //Eastern
        [StringLength(3)]
        public string EasternWinner { get; set; }
        public int EasternGames { get; set; }

        #endregion

        #region Finals

        //Finals
        [StringLength(3)]
        public string ChampionshipsWinner { get; set; }
        public int ChampionshipsGames { get; set; }

        #endregion

    }
}
