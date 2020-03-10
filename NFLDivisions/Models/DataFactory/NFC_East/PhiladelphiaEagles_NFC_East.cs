using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class PhiladelphiaEagles_NFC_East
    {
        private const string _teamName = "Philadelphia Eagles";
        private const string _city = "Philadelphia";
        private const string _state = "Pennsylvannia";
        private const string _stadiumName = "";
        public static TeamInformation GetPhiladelphiaEaglesInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_East],
                Colors = new List<string> { "Black", "White", "Silver", "Charcoal", "Midnight Green" },
                SeasonSchedule = GetPhiladelphiaEaglesSchedule(year),
                Players = GetPhiladelphiaEaglesRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 5,
                    TotalLosses = 5,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetPhiladelphiaEaglesRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Alshon", LastName = "Jeffery", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 17, Height = "6-3", Weight = 218, Age = 29, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Jason", LastName = "Peters", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 71, Height = "6-4", Weight = 328, Age = 37, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Isaac", LastName = "Seumalo", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 73, Height = "6-4", Weight = 303, Age = 26, CollegeName = "Oregon State" },
                new TeamMember { FirstName = "Jason", LastName = "Kelce", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 62, Height = "6-3", Weight = 295, Age = 32, CollegeName = "Cincinnati" },
                new TeamMember { FirstName = "Brandon", LastName = "Brooks", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 79, Height = "6-5", Weight = 335, Age = 30, CollegeName = "Miami (Ohio)" },
                new TeamMember { FirstName = "Lane", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 65, Height = "6-6", Weight = 317, Age = 29, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Zach", LastName = "Ertz", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 86, Height = "6-5", Weight = 250, Age = 29, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Nelson", LastName = "Agholor", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 13, Height = "6-0", Weight = 198, Age = 26, CollegeName = "USC" },
                new TeamMember { FirstName = "Mack", LastName = "Hollins", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 16, Height = "6-4", Weight = 221, Age = 26, CollegeName = "North Carolina" },
                new TeamMember { FirstName = "Jordan", LastName = "Howard", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 24, Height = "6-0", Weight = 224, Age = 25, CollegeName = "Indiana" },
                new TeamMember { FirstName = "Carson", LastName = "Wentz", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 11, Height = "6-5", Weight = 237, Age = 26, CollegeName = "North Dakota State" },
                // Defense
                new TeamMember { FirstName = "Derek", LastName = "Barnett", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 96, Height = "6-3", Weight = 259, Age = 23, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Tim", LastName = "Jernigan", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_Tackle], JerseyNumber = 93, Height = "6-2", Weight = 295, Age = 27, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Fletcher", LastName = "Cox", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_Tackle], JerseyNumber = 91, Height = "6-4", Weight = 310, Age = 28, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Brandon", LastName = "Graham", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 55, Height = "6-2", Weight = 265, Age = 31, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Kamu", LastName = "Grugler-Hill", Position = Constants.Positions[Enums.PositionEnum.Right_Outside_Linebacker], JerseyNumber = 54, Height = "6-2", Weight = 230, Age = 25, CollegeName = "Eastern Illinois" },
                new TeamMember { FirstName = "Nigel", LastName = "Bradham", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 53, Height = "6-2", Weight = 241, Age = 30, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Nathan", LastName = "Gerry", Position = Constants.Positions[Enums.PositionEnum.Left_Outside_Linebacker], JerseyNumber = 47, Height = "6-2", Weight = 230, Age = 24, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Jalen", LastName = "Mills", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 31, Height = "6-0", Weight = 191, Age = 25, CollegeName = "LSU" },
                new TeamMember { FirstName = "Ronald", LastName = "Darby", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 21, Height = "5-11", Weight = 193, Age = 25, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Rodney", LastName = "McLeod", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 23, Height = "5-10", Weight = 195, Age = 29, CollegeName = "Virginia" },
                new TeamMember { FirstName = "Malcolm", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 27, Height = "6-0", Weight = 204, Age = 31, CollegeName = "Ohio State" },
                // Kicker
                new TeamMember { FirstName = "Jake", LastName = "Elliot", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "5-9", Weight = 167, Age = 24, CollegeName = "Memphis" },
                new TeamMember { FirstName = "Cameron", LastName = "Johnston", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 1, Height = "5-11", Weight = 194, Age = 27, CollegeName = "Ohio State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Doug", LastName = "Pederson", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Mike", LastName = "Groh", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Jim", LastName = "Schwartz", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Dave", LastName = "Fipp", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] },
                new Coach { FirstName = "Duce", LastName = "Staley", Title = Constants.Positions[Enums.PositionEnum.Assistant_Coach] }
            };
        }

        private static List<Schedule> GetPhiladelphiaEaglesSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
