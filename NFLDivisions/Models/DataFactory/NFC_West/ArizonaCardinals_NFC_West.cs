using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class ArizonaCardinals_NFC_West
    {
        private const string _teamName = "Arizona Cardinals";
        private const string _city = "Phoenix";
        private const string _state = "Arizona";
        private const string _stadiumName = "University Of Phoenix Stadium";

        public static TeamInformation GetArizonaCardinalsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_West],
                Colors = new List<string> { "Black", "Cardinal", "White" },
                SeasonSchedule = GetArizonaCardinalsSchedule(year),
                Players = GetArizonaCardinalsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 3,
                    TotalLosses = 7,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetArizonaCardinalsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Larry", LastName = "Fitzgerald", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 11, Height = "6-3", Weight = 218, Age = 36, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "D.J.", LastName = "Humphries", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 74, Height = "6-5", Weight = 307, Age = 25, CollegeName = "Florida" },
                new TeamMember { FirstName = "Justin", LastName = "Pugh", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 67, Height = "6-5", Weight = 311, Age = 29, CollegeName = "Syracuse" },
                new TeamMember { FirstName = "A.Q.", LastName = "Shipley", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 53, Height = "6-1", Weight = 307, Age = 33, CollegeName = "Penn State" },
                new TeamMember { FirstName = "J.R.", LastName = "Sweezy", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 64, Height = "6-5", Weight = 310, Age = 30, CollegeName = "North Carolina State" },
                new TeamMember { FirstName = "Justin", LastName = "Murray", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-5", Weight = 315, Age = 26, CollegeName = "Cincinnati" },
                new TeamMember { FirstName = "Charles", LastName = "Clay", Position = Constants.Positions[Enums.PositionEnum.Tight_End_1], JerseyNumber = 85, Height = "6-3", Weight = 246, Age = 30, CollegeName = "Tulsa" },
                new TeamMember { FirstName = "Christian", LastName = "Kirk", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 13, Height = "5-11", Weight = 200, Age = 23, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Maxx", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Tight_End_2], JerseyNumber = 87, Height = "6-4", Weight = 252, Age = 25, CollegeName = "Minnesota" },
                new TeamMember { FirstName = "Kyler", LastName = "Murray", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 1, Height = "5-10", Weight = 207, Age = 22, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "David", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 31, Height = "6-1", Weight = 224, Age = 27, CollegeName = "Northern Iowa" },
                // Defense
                new TeamMember { FirstName = "Johnathan", LastName = "Bullard", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 90, Height = "6-3", Weight = 296, Age = 26, CollegeName = "Florida" },
                new TeamMember { FirstName = "Corey", LastName = "Peters", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 98, Height = "6-3", Weight = 335, Age = 31, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Rodney", LastName = "Gunter", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 95, Height = "6-5", Weight = 305, Age = 27, CollegeName = "Delaware  State" },
                new TeamMember { FirstName = "Chandler", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 55, Height = "6-5", Weight = 265, Age = 29, CollegeName = "Syracuse" },
                new TeamMember { FirstName = "Haason", LastName = "Reddick", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 43, Height = "6-1", Weight = 235, Age = 25, CollegeName = "Temple" },
                new TeamMember { FirstName = "Jordan", LastName = "Hicks", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 58, Height = "6-1", Weight = 236, Age = 27, CollegeName = "Texas" },
                new TeamMember { FirstName = "Terrell", LastName = "Suggs", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 56, Height = "6-3", Weight = 265, Age = 37, CollegeName = "Arizona State" },
                new TeamMember { FirstName = "Byron", LastName = "Murphy Jr.", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 33, Height = "5-11", Weight = 190, Age = 21, CollegeName = "Washington" },
                new TeamMember { FirstName = "Patrick", LastName = "Peterson", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 21, Height = "6-1", Weight = 203, Age = 29, CollegeName = "LSU" },
                new TeamMember { FirstName = "Jalen", LastName = "Thompson", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 34, Height = "5-11", Weight = 190, Age = 21, CollegeName = "Washington State" },
                new TeamMember { FirstName = "Budda", LastName = "Baker", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 32, Height = "5-10", Weight = 195, Age = 23, CollegeName = "Washington" },
                // Kicker
                new TeamMember { FirstName = "Zane", LastName = "Gonzalez", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 5, Height = "6-0", Weight = 202, Age = 24, CollegeName = "Arizona State" },
                new TeamMember { FirstName = "Andy", LastName = "Lee", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 4, Height = "6-1", Weight = 185, Age = 37, CollegeName = "Pittsburgh" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Kliff", LastName = "Kingsbury", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Tom", LastName = "Clements", Title = Constants.Positions[Enums.PositionEnum.Pass_Game_Coordinator] },
                new Coach { FirstName = "Vance", LastName = "Joseph", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Jeff", LastName = "Rodgers", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetArizonaCardinalsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
