
using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    [Serializable]
    public class TeamInformation
    {
        public string TeamName { get; set; }
        public string Division { get; set; }
        public List<Schedule> SeasonSchedule { get; set; }
        public List<TeamMember> Players { get; set; }
        public List<Coach> Coaches { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public List<string> Colors { get; set; }
        public string StadiumName { get; set; }
        public TeamRankingInformation RankingInformation { get; set; }
    }
}
