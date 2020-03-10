
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class HoustonTexans_AFC_South
    {
        private const string _teamName = "Houston Texans";
        private const string _city = "Houstin";
        private const string _state = "Texas";
        private const string _stadiumName = "NRG Stadium";

        public static TeamInformation GetHoustonTexansInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_South],
                Colors = new List<string> { "Deep Steel Blue", "Battle Red", "Liberty White" },
                SeasonSchedule = GetHoustonTexansSchedule(year),
                Players = GetHoustonTexansRoster(year),
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

        private static List<TeamMember> GetHoustonTexansRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "DeAndre", LastName = "Hopkins", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 10, Height = "6-1", Weight = 212, Age = 27, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Laremy", LastName = "Tunsil", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 78, Height = "6-5", Weight = 313, Age = 25, CollegeName = "Mississippi" },
                new TeamMember { FirstName = "Max", LastName = "Scharping", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 74, Height = "6-6", Weight = 327, Age = 23, CollegeName = "Northern Illinois" },
                new TeamMember { FirstName = "Nick", LastName = "Martin", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 66, Height = "6-4", Weight = 295, Age = 26, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Zach", LastName = "Fulton", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 73, Height = "6-5", Weight = 321, Age = 28, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Tytus", LastName = "Howard", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-5", Weight = 322, Age = 23, CollegeName = "Alabama State" },
                new TeamMember { FirstName = "Darren", LastName = "Fells", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 87, Height = "6-7", Weight = 270, Age = 33, CollegeName = "California-Irvine" },
                new TeamMember { FirstName = "Keke", LastName = "Coutee", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 16, Height = "5-11", Weight = 180, Age = 22, CollegeName = "Texas Tech" },
                new TeamMember { FirstName = "Will", LastName = "Fuller V", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 15, Height = "6-0", Weight = 184, Age = 25, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Deshaun", LastName = "Watson", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 4, Height = "6-2", Weight = 220, Age = 24, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Duke", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 25, Height = "5-9", Weight = 210, Age = 26, CollegeName = "Miami (Fla.)" },
                // Defense
                new TeamMember { FirstName = "Brandon", LastName = "Dunn", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 92, Height = "6-2", Weight = 310, Age = 27, CollegeName = "Louisville" },
                new TeamMember { FirstName = "D.J.", LastName = "Reader", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 98, Height = "6-3", Weight = 347, Age = 25, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Angelo", LastName = "Blackson", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 97, Height = "6-4", Weight = 319, Age = 27, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Whitney", LastName = "Mercilus", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 59, Height = "6-4", Weight = 258, Age = 29, CollegeName = "Illinoise" },
                new TeamMember { FirstName = "Benardrick", LastName = "McKinney", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 55, Height = "6-4", Weight = 257, Age = 27, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Zach", LastName = "Cunningham", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 41, Height = "6-3", Weight = 238, Age = 24, CollegeName = "Vanderbilt" },
                new TeamMember { FirstName = "Brennan", LastName = "Scarlett", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 57, Height = "6-4", Weight = 263, Age = 26, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Jonathan", LastName = "Joseph", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 24, Height = "5-11", Weight = 186, Age = 35, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Bradley", LastName = "Roby", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 21, Height = "5-11", Weight = 194, Age = 27, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Tashaun", LastName = "Gipson Sr", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 39, Height = "6-1", Weight = 212, Age = 29, CollegeName = "Wyoming" },
                new TeamMember { FirstName = "Justin", LastName = "Reid", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 20, Height = "6-1", Weight = 203, Age = 22, CollegeName = "Stanford" },
                // Kicker
                new TeamMember { FirstName = "Ka'imi", LastName = "Fairbairn", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 7, Height = "6-0", Weight = 183, Age = 25, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Brian", LastName = "Anger", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 9, Height = "6-3", Weight = 205, Age = 31, CollegeName = "California" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Bill", LastName = "O'Brian", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Tim", LastName = "Kelly", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Romeo", LastName = "Crennel", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Brad", LastName = "Seely", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetHoustonTexansSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
