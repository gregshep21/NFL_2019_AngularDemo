
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class DenverBroncos_AFC_West
    {
        private const string _teamName = "Denver Broncos";
        private const string _city = "Denver";
        private const string _state = "Colorado";
        private const string _stadiumName = "Mile High Stadium";

        public static TeamInformation GetDenverBroncosInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_West],
                Colors = new List<string> { "White", "Orange", "Blue", "Navy Blue" },
                SeasonSchedule = GetDenverBroncosSchedule(year),
                Players = GetDenverBroncosRoster(year),
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

        public static List<TeamMember> GetDenverBroncosRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Tim", LastName = "Patrick", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 81, Height = "6-4", Weight = 212, Age = 26, CollegeName = "Utah" },
                new TeamMember { FirstName = "Garrett", LastName = "Bolles", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 72, Height = "6-5", Weight = 300, Age = 27, CollegeName = "Utah" },
                new TeamMember { FirstName = "Dalton", LastName = "Risner", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 66, Height = "6-5", Weight = 312, Age = 24, CollegeName = "Kansas State" },
                new TeamMember { FirstName = "Connor", LastName = "McGovern", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 60, Height = "6-4", Weight = 306, Age = 26, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Ron", LastName = "Leary", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 65, Height = "6-3", Weight = 320, Age = 30, CollegeName = "Memphis" },
                new TeamMember { FirstName = "Ja'Wuan", LastName = "James", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 70, Height = "6-6", Weight = 312, Age = 27, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Jeff", LastName = "Heuerman", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 82, Height = "6-5", Weight = 255, Age = 27, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Courtland", LastName = "Sutton", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 14, Height = "6-4", Weight = 216, Age = 24, CollegeName = "Southern Methodist" },
                new TeamMember { FirstName = "Phillip", LastName = "Lindsay", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 30, Height = "5-8", Weight = 190, Age = 25, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Brandon", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 2, Height = "6-2", Weight = 209, Age = 27, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Andy", LastName = "Janovich", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 32, Height = "6-1", Weight = 238, Age = 26, CollegeName = "Nebraska" },
                // Defense
                new TeamMember { FirstName = "Shelby", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 96, Height = "6-2", Weight = 290, Age = 28, CollegeName = "Illinois State" },
                new TeamMember { FirstName = "Mike", LastName = "Purcell", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 98, Height = "6-3", Weight = 328, Age = 28, CollegeName = "Wyoming" },
                new TeamMember { FirstName = "Derek", LastName = "Wolfe", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 95, Height = "6-5", Weight = 285, Age = 29, CollegeName = "Cincinnati" },
                new TeamMember { FirstName = "Malik", LastName = "Reed", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 59, Height = "6-2", Weight = 235, Age = 23, CollegeName = "Nevada" },
                new TeamMember { FirstName = "Von", LastName = "Miller", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 58, Height = "6-3", Weight = 250, Age = 30, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Alexander", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 45, Height = "6-2", Weight = 255, Age = 27, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Todd", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 51, Height = "6-1", Weight = 230, Age = 27, CollegeName = "Sacramento State" },
                new TeamMember { FirstName = "Chris", LastName = "Harris Jr.", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 25, Height = "5-10", Weight = 199, Age = 30, CollegeName = "Kansas" },
                new TeamMember { FirstName = "Davontae", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 27, Height = "5-11", Weight = 200, Age = 24, CollegeName = "Illinois State" },
                new TeamMember { FirstName = "Kareem", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 22, Height = "5-10", Weight = 183, Age = 31, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Justin", LastName = "Simmons", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 31, Height = "6-2", Weight = 202, Age = 26, CollegeName = "Boston College" },
                // Kicker
                new TeamMember { FirstName = "Brandon", LastName = "McManus", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 8, Height = "6-3", Weight = 201, Age = 28, CollegeName = "Temple" },
                new TeamMember { FirstName = "Colby", LastName = "Wadman", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-1", Weight = 213, Age = 24, CollegeName = "California-Davis" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Vic", LastName = "Fangio", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Rich", LastName = "Scangarello", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Ed", LastName = "Donatell", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Tom", LastName = "McMahon", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetDenverBroncosSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
