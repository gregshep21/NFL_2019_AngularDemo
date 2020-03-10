
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class OaklandRaiders_AFC_West
    {
        private const string _teamName = "Oakland Raiders";
        private const string _city = "Oakland";
        private const string _state = "California";
        private const string _stadiumName = "Oakland-Alameda County Coliseum";

        public static TeamInformation GetOaklandRaidersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_West],
                Colors = new List<string> { "Black", "Silver", "White" },
                SeasonSchedule = GetOaklandRaidersSchedule(year),
                Players = GetOaklandRaidersRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 6,
                    TotalLosses = 4,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetOaklandRaidersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Trevor", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 11, Height = "6-1", Weight = 188, Age = 26, CollegeName = "California" },
                new TeamMember { FirstName = "Kolton", LastName = "Miller", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 74, Height = "6-8", Weight = 325, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Richie", LastName = "Incognito", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 64, Height = "6-3", Weight = 325, Age = 36, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Rodney", LastName = "Hudson", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 61, Height = "6-2", Weight = 315, Age = 30, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Gabe", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 66, Height = "6-3", Weight = 335, Age = 38, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Trent", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 77, Height = "6-8", Weight = 380, Age = 26, CollegeName = "Florida" },
                new TeamMember { FirstName = "Darren", LastName = "Waller", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 83, Height = "6-6", Weight = 255, Age = 27, CollegeName = "Georgia Tech" },
                new TeamMember { FirstName = "Tyrell", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 16, Height = "6-4", Weight = 205, Age = 27, CollegeName = "Western Oregon" },
                new TeamMember { FirstName = "Derek", LastName = "Carr", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 4, Height = "6-3", Weight = 210, Age = 28, CollegeName = "Fresno State" },
                new TeamMember { FirstName = "Josh", LastName = "Jacobs", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 28, Height = "5-10", Weight = 220, Age = 21, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Alec", LastName = "Ingold", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 45, Height = "6-1", Weight = 240, Age = 23, CollegeName = "Wisconsin" },
                // Defense
                new TeamMember { FirstName = "Clelin", LastName = "Ferrell", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 96, Height = "6-4", Weight = 265, Age = 22, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Maurice", LastName = "Hurst", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 73, Height = "6-2", Weight = 291, Age = 24, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Johnathan", LastName = "Hankins", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 90, Height = "6-3", Weight = 340, Age = 27, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Maxx", LastName = "Crosby", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 98, Height = "6-5", Weight = 255, Age = 22, CollegeName = "Eastern Michigan" },
                new TeamMember { FirstName = "Tahir", LastName = "Whitehead", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 59, Height = "6-2", Weight = 241, Age = 29, CollegeName = "Temple" },
                new TeamMember { FirstName = "Will", LastName = "Compton", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 51, Height = "6-1", Weight = 235, Age = 30, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Nicholas", LastName = "Marrow", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 50, Height = "6-0", Weight = 225, Age = 24, CollegeName = "Greenville College" },
                new TeamMember { FirstName = "Daryl", LastName = "Worley", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 20, Height = "6-1", Weight = 215, Age = 24, CollegeName = "West Virginia" },
                new TeamMember { FirstName = "Trayvon", LastName = "Mullen", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 27, Height = "6-2", Weight = 200, Age = 22, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Lamarcus", LastName = "Joyner", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 29, Height = "5-8", Weight = 185, Age = 29, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Erik", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 25, Height = "6-2", Weight = 220, Age = 29, CollegeName = "California (PA)" },
                // Kicker
                new TeamMember { FirstName = "Daniel", LastName = "Carlson", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 8, Height = "6-5", Weight = 215, Age = 24, CollegeName = "Auburn" },
                new TeamMember { FirstName = "AJ", LastName = "Cole", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-4", Weight = 220, Age = 24, CollegeName = "NC State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Jon", LastName = "Gruden", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Greg", LastName = "Olson", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Paul", LastName = "Guenther", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Rich", LastName = "Bisaccia", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetOaklandRaidersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
