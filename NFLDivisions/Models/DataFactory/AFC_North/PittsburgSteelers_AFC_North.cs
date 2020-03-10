
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class PittsburgSteelers_AFC_North
    {
        private const string _teamName = "Pittsburgh Steelers";
        private const string _city = "Pittsburgh";
        private const string _state = "Pennsylvania";
        private const string _stadiumName = "Heinz Field";

        public static TeamInformation GetPittsburghSteelersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_North],
                Colors = new List<string> { "Black", "Gold", "White" },
                SeasonSchedule = GetPittsburghSteelersSchedule(year),
                Players = GetPittsburghSteelersRoster(year),
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

        public static List<TeamMember> GetPittsburghSteelersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "James", LastName = "Washington", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 13, Height = "5-11", Weight = 213, Age = 23, CollegeName = "Oklahoma State" },
                new TeamMember { FirstName = "Alejandro", LastName = "Villanueva", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 78, Height = "6-9", Weight = 320, Age = 31, CollegeName = "Army" },
                new TeamMember { FirstName = "Ramon", LastName = "Foster", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 73, Height = "6-5", Weight = 328, Age = 33, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "B.J.", LastName = "Finney", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 67, Height = "6-4", Weight = 318, Age = 28, CollegeName = "Kansas State" },
                new TeamMember { FirstName = "David", LastName = "DeCastro", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 66, Height = "6-5", Weight = 316, Age = 29, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Matt", LastName = "Feiler", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-6", Weight = 330, Age = 27, CollegeName = "Bloomsburg" },
                new TeamMember { FirstName = "Vance", LastName = "McDonald", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 89, Height = "6-4", Weight = 267, Age = 29, CollegeName = "Rice" },
                new TeamMember { FirstName = "James", LastName = "Conner", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 30, Height = "6-1", Weight = 233, Age = 24, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Trey", LastName = "Edmunds", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 33, Height = "6-2", Weight = 223, Age = 24, CollegeName = "Maryland" },
                new TeamMember { FirstName = "Mason", LastName = "Rudolph", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 2, Height = "6-5", Weight = 235, Age = 24, CollegeName = "Oklahoma State" },
                new TeamMember { FirstName = "JuJu", LastName = "Smith-Schuster", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 19, Height = "6-1", Weight = 215, Age = 23, CollegeName = "USC" },
                // Defense
                new TeamMember { FirstName = "Cameron", LastName = "Heyward", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 97, Height = "6-5", Weight = 295, Age = 30, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Javon", LastName = "Hargrave", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 79, Height = "6-2", Weight = 305, Age = 26, CollegeName = "South Carolina State" },
                new TeamMember { FirstName = "Tyson", LastName = "Alualu", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 94, Height = "6-3", Weight = 304, Age = 32, CollegeName = "California" },
                new TeamMember { FirstName = "T.J.", LastName = "Watt", Position = Constants.Positions[Enums.PositionEnum.Left_Outside_Linebacker], JerseyNumber = 90, Height = "6-4", Weight = 252, Age = 25, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Mark", LastName = "Barron", Position = Constants.Positions[Enums.PositionEnum.Left_Inside_Linebacker], JerseyNumber = 26, Height = "6-2", Weight = 230, Age = 30, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Vince", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Right_Inside_Linebacker], JerseyNumber = 98, Height = "6-1", Weight = 233, Age = 29, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Bud", LastName = "Dupree", Position = Constants.Positions[Enums.PositionEnum.Right_Outside_Linebacker], JerseyNumber = 48, Height = "6-4", Weight = 269, Age = 26, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Joe", LastName = "Haden", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 23, Height = "5-11", Weight = 195, Age = 30, CollegeName = "Florida" },
                new TeamMember { FirstName = "Minkah", LastName = "Fitzpatrick", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 39, Height = "6-1", Weight = 207, Age = 23, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Terrell", LastName = "Edmunds", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 34, Height = "6-1", Weight = 217, Age = 22, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Stevens", LastName = "Nelson", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 22, Height = "5-11", Weight = 194, Age = 26, CollegeName = "Oregon State" },
                new TeamMember { FirstName = "Mike", LastName = "Hilton", Position = Constants.Positions[Enums.PositionEnum.NickelBack], JerseyNumber = 28, Height = "5-9", Weight = 184, Age = 25, CollegeName = "Mississippi" },
                // Kicker
                new TeamMember { FirstName = "Chris", LastName = "Boswell", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 9, Height = "6-2", Weight = 185, Age = 28, CollegeName = "Rice" },
                new TeamMember { FirstName = "Jordan", LastName = "Berry", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 4, Height = "6-5", Weight = 195, Age = 28, CollegeName = "Eastern Kentucky" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Mike", LastName = "Tomlin", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Randy", LastName = "Fichtner", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Keith", LastName = "Butler", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Danny", LastName = "Smith", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetPittsburghSteelersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
