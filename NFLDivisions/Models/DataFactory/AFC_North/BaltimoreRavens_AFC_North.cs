
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class BaltimoreRavens_AFC_North
    {
        private const string _teamName = "Baltimore Ravens";
        private const string _city = "Baltimore";
        private const string _state = "Maryland";
        private const string _stadiumName = "M&T Bank Stadium";

        public static TeamInformation GetBaltimoreRavensInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_North],
                Colors = new List<string> { "Black", "Purple", "White", "Gold" },
                SeasonSchedule = GetBaltimoreRavensSchedule(year),
                Players = GetBaltimoreRavensRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 8,
                    TotalLosses = 2,
                    Ties = 0
                }
            };
        }

        private static List<TeamMember> GetBaltimoreRavensRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Marquise", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 15, Height = "5-9", Weight = 170, Age = 22, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Miles", LastName = "Boykin", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 80, Height = "6-4", Weight = 220, Age = 23, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Ronnie", LastName = "Stanley", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 79, Height = "6-6", Weight = 315, Age = 25, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Bradley", LastName = "Bozeman", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 77, Height = "6-5", Weight = 317, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Matt", LastName = "Skura", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 68, Height = "6-3", Weight = 313, Age = 26, CollegeName = "Duke" },
                new TeamMember { FirstName = "Marshal", LastName = "Yanda", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 73, Height = "6-3", Weight = 305, Age = 35, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Orlando", LastName = "Brown Jr", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 78, Height = "6-8", Weight = 345, Age = 23, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Nick", LastName = "Boyle", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 86, Height = "6-4", Weight = 270, Age = 26, CollegeName = "Delaware" },
                new TeamMember { FirstName = "Lamar", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 8, Height = "6-2", Weight = 212, Age = 22, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Patrick", LastName = "Ricard", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 42, Height = "6-3", Weight = 311, Age = 25, CollegeName = "Maine" },
                new TeamMember { FirstName = "Mark", LastName = "Ingram II", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 21, Height = "5-9", Weight = 215, Age = 29, CollegeName = "Alabama" },
                // Defense
                new TeamMember { FirstName = "Brandon", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 98, Height = "6-1", Weight = 336, Age = 30, CollegeName = "Missouri Southern State" },
                new TeamMember { FirstName = "Michael", LastName = "Pierce", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 97, Height = "6-0", Weight = 340, Age = 27, CollegeName = "Samford" },
                new TeamMember { FirstName = "Chris", LastName = "Wormley", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 93, Height = "6-5", Weight = 300, Age = 26, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Jaylon", LastName = "Ferguson", Position = Constants.Positions[Enums.PositionEnum.Rush], JerseyNumber = 45, Height = "6-5", Weight = 275, Age = 23, CollegeName = "Louisiana Tech" },
                new TeamMember { FirstName = "Josh", LastName = "Bynes", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 57, Height = "6-1", Weight = 235, Age = 30, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Patrick", LastName = "Onwuasor", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 48, Height = "6-0", Weight = 227, Age = 27, CollegeName = "Portland State" },
                new TeamMember { FirstName = "Matthew", LastName = "Judon", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 99, Height = "6-3", Weight = 261, Age = 27, CollegeName = "Grand Valley State" },
                new TeamMember { FirstName = "Marlon", LastName = "Humphrey", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 44, Height = "6-0", Weight = 197, Age = 23, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Chuck", LastName = "Clark", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 36, Height = "6-0", Weight = 205, Age = 24, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Earl", LastName = "Thomas III", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 29, Height = "5-10", Weight = 202, Age = 30, CollegeName = "Texas" },
                new TeamMember { FirstName = "Brandon", LastName = "Carr", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 39, Height = "6-0", Weight = 210, Age = 33, CollegeName = "Grand Valley State" },
                // Kicker
                new TeamMember { FirstName = "Justin", LastName = "Tucker", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 9, Height = "6-1", Weight = 183, Age = 30, CollegeName = "Texas" },
                new TeamMember { FirstName = "Sam", LastName = "Koch", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 4, Height = "6-1", Weight = 222, Age = 37, CollegeName = "Nebraska" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Josh", LastName = "Harbaugh", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Greg", LastName = "Roman", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Don", LastName = "Martindale", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "David", LastName = "Culley", Title = Constants.Positions[Enums.PositionEnum.Assistant_Coach] }
            };
        }

        private static List<Schedule> GetBaltimoreRavensSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
