
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class KansasCityChiefs_AFC_West
    {
        private const string _teamName = "Kansas City Chiefs";
        private const string _city = "Kansas City";
        private const string _state = "Kansas";
        private const string _stadiumName = "Arrowhead Stadium";

        public static TeamInformation GetKansasCityChiefsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_West],
                Colors = new List<string> { "Red", "Gold" },
                SeasonSchedule = GetKansasCityChiefsSchedule(year),
                Players = GetKansasCityChiefsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 7,
                    TotalLosses = 4,
                    Ties = 0
                }
            };
        }

        private static List<TeamMember> GetKansasCityChiefsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Tyreek", LastName = "Hill", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 10, Height = "5-10", Weight = 185, Age = 25, CollegeName = "West Alabama" },
                new TeamMember { FirstName = "Eric", LastName = "Fisher", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 72, Height = "6-7", Weight = 315, Age = 28, CollegeName = "Central Michigan" },
                new TeamMember { FirstName = "Andrew", LastName = "Wylie", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 77, Height = "6-6", Weight = 309, Age = 25, CollegeName = "Easter Michigan" },
                new TeamMember { FirstName = "Austin", LastName = "Reiter", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 62, Height = "6-3", Weight = 300, Age = 28, CollegeName = "South Florida" },
                new TeamMember { FirstName = "Laurent", LastName = "Duvernay-Tardif", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 76, Height = "6-5", Weight = 321, Age = 28, CollegeName = "McGill (Canada)" },
                new TeamMember { FirstName = "Mitchell", LastName = "Schwartz", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-5", Weight = 320, Age = 30, CollegeName = "California" },
                new TeamMember { FirstName = "Travis", LastName = "Kelce", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 87, Height = "6-5", Weight = 260, Age = 30, CollegeName = "Cincinnati" },
                new TeamMember { FirstName = "Sammy", LastName = "Watkins", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 14, Height = "6-1", Weight = 211, Age = 26, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Patrick", LastName = "Mahomes", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 15, Height = "6-3", Weight = 230, Age = 24, CollegeName = "Texas Tech" },
                new TeamMember { FirstName = "Damien", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 26, Height = "5-11", Weight = 224, Age = 27, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Anthony", LastName = "Sherman", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 42, Height = "5-10", Weight = 242, Age = 30, CollegeName = "Connecticut" },
                // Defense
                new TeamMember { FirstName = "Alex", LastName = "Okafor", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 97, Height = "6-4", Weight = 261, Age = 28, CollegeName = "Texas" },
                new TeamMember { FirstName = "Chris", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_Tackle], JerseyNumber = 95, Height = "6-6", Weight = 310, Age = 25, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Derrick", LastName = "Nnadi", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_Tackle], JerseyNumber = 91, Height = "6-1", Weight = 312, Age = 23, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Frank", LastName = "Clark", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 55, Height = "6-3", Weight = 260, Age = 26, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Anthony", LastName = "Hitchens", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], JerseyNumber = 53, Height = "6-0", Weight = 235, Age = 27, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Damien", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], JerseyNumber = 54, Height = "6-0", Weight = 245, Age = 26, CollegeName = "Minnesota" },
                new TeamMember { FirstName = "Charvarius", LastName = "Ward", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 35, Height = "6-1", Weight = 196, Age = 23, CollegeName = "Middle Tennessee State" },
                new TeamMember { FirstName = "Bashaud", LastName = "Breeland", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 21, Height = "5-11", Weight = 195, Age = 27, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Kendall", LastName = "Fuller", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 29, Height = "5-11", Weight = 198, Age = 24, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Juan", LastName = "Thornhill", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 22, Height = "6-0", Weight = 205, Age = 24, CollegeName = "Virginia" },
                new TeamMember { FirstName = "Tyrann", LastName = "Mathieu", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 32, Height = "5-9", Weight = 190, Age = 27, CollegeName = "LSU" },
                // Kicker
                new TeamMember { FirstName = "Harrison", LastName = "Butker", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 7, Height = "6-4", Weight = 205, Age = 24, CollegeName = "Georgia Tech" },
                new TeamMember { FirstName = "Dustin", LastName = "Colquitt", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 2, Height = "6-3", Weight = 210, Age = 37, CollegeName = "Tennessee" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Andy", LastName = "Reid", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Eric", LastName = "Bieniemy", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Steve", LastName = "Spagnuolo", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Dave", LastName = "Toub", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetKansasCityChiefsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
