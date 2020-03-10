

using System;

namespace SPA_Angular_Demo.Models
{
    [Serializable]
    public class TeamRankingInformation
    {
        public int Ranking { get; set; }
        public string TeamName { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }
        public int Ties { get; set; }
        public int SeasonGameCount { get; set; }
    }
}
