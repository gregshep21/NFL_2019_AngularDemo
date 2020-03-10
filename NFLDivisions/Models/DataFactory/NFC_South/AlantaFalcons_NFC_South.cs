using System;
using System.Collections.Generic;
namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class AlantaFalcons_NFC_South
    {
        private const string _teamName = "Alanta Falcons";
        private const string _city = "Alanta";
        private const string _state = "Georgia";
        private const string _stadiumName = "Mercedes-Benz Stadium";

        public static TeamInformation GetAlantaFalconsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_South],
                Colors = new List<string> { "Black", "Red", "White", "Silver" },
                SeasonSchedule = GetAlantaFalconsSchedule(year),
                Players = GetAlantaFalconsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 3,
                    TotalLosses = 7,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetAlantaFalconsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Julio", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 11, Height = "6-3", Weight = 220, Age = 30, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Jake", LastName = "Matthews", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 70, Height = "6-5", Weight = 309, Age = 27, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "James", LastName = "Carpenter", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 77, Height = "6-5", Weight = 321, Age = 30, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Alex", LastName = "Mack", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 51, Height = "6-4", Weight = 311, Age = 34, CollegeName = "California" },
                new TeamMember { FirstName = "Jamon", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 68, Height = "6-4", Weight = 340, Age = 26, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Kaleb", LastName = "McGray", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 76, Height = "6-6", Weight = 306, Age = 24, CollegeName = "Washington" },
                new TeamMember { FirstName = "Austin", LastName = "Hooper", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 81, Height = "6-4", Weight = 254, Age = 25, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Calvin", LastName = "Ridley", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 18, Height = "6-1", Weight = 190, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Matt", LastName = "Ryan", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 2, Height = "6-4", Weight = 217, Age = 34, CollegeName = "Boston College" },
                new TeamMember { FirstName = "Devonta", LastName = "Freeman", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 24, Height = "5-8", Weight = 206, Age = 27, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Keith", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 40, Height = "6-0", Weight = 240, Age = 27, CollegeName = "San Jose State" },
                // Defense
                new TeamMember { FirstName = "Takkarist", LastName = "McKinley", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 98, Height = "6-2", Weight = 265, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Grady", LastName = "Jarrett", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 97, Height = "6-0", Weight = 305, Age = 26, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Tyeler", LastName = "Davison", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 96, Height = "6-2", Weight = 309, Age = 27, CollegeName = "Fresno State" },
                new TeamMember { FirstName = "Allen", LastName = "Bailey", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 93, Height = "6-3", Weight = 288, Age = 30, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Vic", LastName = "Beasley Jr.", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_3], JerseyNumber = 44, Height = "6-3", Weight = 246, Age = 27, CollegeName = "Clemson" },
                new TeamMember { FirstName = "De'Vondre", LastName = "Campbell", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], JerseyNumber = 59, Height = "6-4", Weight = 232, Age = 26, CollegeName = "Minnesota" },
                new TeamMember { FirstName = "Deion", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], JerseyNumber = 45, Height = "6-1", Weight = 227, Age = 25, CollegeName = "LSU" },
                new TeamMember { FirstName = "Isaiah", LastName = "Oliver", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 26, Height = "6-0", Weight = 210, Age = 23, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Desmond", LastName = "Trufant", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 21, Height = "6-0", Weight = 190, Age = 29, CollegeName = "Washington" },
                new TeamMember { FirstName = "Kemal", LastName = "Ishmael", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 36, Height = "6-0", Weight = 206, Age = 28, CollegeName = "Central Florida" },
                new TeamMember { FirstName = "Ricardo", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 37, Height = "5-9", Weight = 186, Age = 27, CollegeName = "Purdue" },
                // Kicker
                new TeamMember { FirstName = "Younghoe", LastName = "Koo", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 7, Height = "5-9", Weight = 185, Age = 25, CollegeName = "Georgia Southern" },
                new TeamMember { FirstName = "Josh", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Long_Snapper], JerseyNumber = 47, Height = "6-1", Weight = 224, Age = 30, CollegeName = "Auburn" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Dan", LastName = "Quinn", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Dirk", LastName = "Koetter", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Jerome", LastName = "Henderson", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Ben", LastName = "Kotwica", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] },
            };
        }

        private static List<Schedule> GetAlantaFalconsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
