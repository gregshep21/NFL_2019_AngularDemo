
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class TennesseeTitans_AFC_South
    {
        private const string _teamName = "TennesseeTitans";
        private const string _city = "Nashville";
        private const string _state = "Tennessee";
        private const string _stadiumName = "Nissan Stadium";

        public static TeamInformation GetTennesseeTitansInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_South],
                Colors = new List<string> { "White", "Red", "Navy Blue", "Silver", "Titan Blue" },
                SeasonSchedule = GetTennesseeTitansSchedule(year),
                Players = GetTennesseeTitansRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 3,
                    TotalWins = 5,
                    TotalLosses = 5,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetTennesseeTitansRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Corey", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 84, Height = "6-3", Weight = 209, Age = 24, CollegeName = "Western Michigan" },
                new TeamMember { FirstName = "Delanie", LastName = "Walker", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 82, Height = "6-2", Weight = 248, Age = 35, CollegeName = "Central Missouri State" },
                new TeamMember { FirstName = "Taylor", LastName = "Lewan", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 77, Height = "6-7", Weight = 309, Age = 28, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Rodger", LastName = "Saffold III", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 76, Height = "6-5", Weight = 325, Age = 31, CollegeName = "Indiana" },
                new TeamMember { FirstName = "Ben", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 60, Height = "6-3", Weight = 308, Age = 30, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Nate", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 64, Height = "6-3", Weight = 316, Age = 23, CollegeName = "Charlotte" },
                new TeamMember { FirstName = "Jack", LastName = "Conklin", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 78, Height = "6-6", Weight = 308, Age = 25, CollegeName = "Michigan State" },
                new TeamMember { FirstName = "Adam", LastName = "Humphries", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 10, Height = "5-11", Weight = 195, Age = 26, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Tajae", LastName = "Sharpe", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 19, Height = "6-2", Weight = 194, Age = 24, CollegeName = "Massachusetts" },
                new TeamMember { FirstName = "Ryan", LastName = "Tannehill", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 17, Height = "6-4", Weight = 307, Age = 31, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Derrick", LastName = "Henry", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 22, Height = "6-3", Weight = 247, Age = 25, CollegeName = "Alabama" },
                // Defense
                new TeamMember { FirstName = "Jeffery", LastName = "Simmons", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 98, Height = "6-4", Weight = 301, Age = 22, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "DaQuan", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 90, Height = "6-4", Weight = 322, Age = 27, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Jurrell", LastName = "Casey", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 99, Height = "6-1", Weight = 305, Age = 29, CollegeName = "USC" },
                new TeamMember { FirstName = "Cameron", LastName = "Wake", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 91, Height = "6-3", Weight = 263, Age = 37, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Rashaan", LastName = "Evans", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 54, Height = "6-2", Weight = 232, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Jayon", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 55, Height = "6-0", Weight = 226, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Harold", LastName = "Landry III", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 58, Height = "6-2", Weight = 252, Age = 23, CollegeName = "Boston College" },
                new TeamMember { FirstName = "Logan", LastName = "Ryan", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 26, Height = "5-11", Weight = 195, Age = 28, CollegeName = "Rutgers" },
                new TeamMember { FirstName = "Kenny", LastName = "Vaccaro", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 24, Height = "6-0", Weight = 214, Age = 28, CollegeName = "Texas" },
                new TeamMember { FirstName = "Kevin", LastName = "Byard", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 31, Height = "5-11", Weight = 212, Age = 26, CollegeName = "Middle Tennessee State" },
                new TeamMember { FirstName = "Adoree'", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 25, Height = "5-11", Weight = 185, Age = 24, CollegeName = "USC" },
                // Kicker
                new TeamMember { FirstName = "Ryan", LastName = "Succop", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "6-2", Weight = 218, Age = 33, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Brett", LastName = "Kern", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-2", Weight = 214, Age = 33, CollegeName = "Toledo" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Mike", LastName = "Vrabel", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Arthur", LastName = "Smith", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Dean", LastName = "Peas", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Craig", LastName = "Aukerman", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetTennesseeTitansSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}

