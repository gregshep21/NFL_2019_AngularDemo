
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class MiamiDolphins_AFC_East
    {
        private const string _teamName = "Miami Dolphins";
        private const string _city = "Miami Gardens";
        private const string _state = "Florida";
        private const string _stadiumName = "Hard Rock Stadium";

        internal static TeamInformation GetMiamiDolphinsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_East],
                Colors = new List<string> { "White", "Orange", "Navy Blue", "Aqua Green" },
                SeasonSchedule = GetMiamiDolphinsSchedule(year),
                Players = GetMiamiDolphinsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 2,
                    TotalLosses = 8,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetMiamiDolphinsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "DeVante", LastName = "Parker", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 11, Height = "6-3", Weight = 216, Age = 26, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Julien", LastName = "Davenport", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 70, Height = "6-7", Weight = 325, Age = 24, CollegeName = "Bucknell" },
                new TeamMember { FirstName = "Micheal", LastName = "Delter", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 63, Height = "6-6", Weight = 310, Age = 23, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Daniel", LastName = "Kilgore", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 67, Height = "6-3", Weight = 291, Age = 31, CollegeName = "Appalachian State" },
                new TeamMember { FirstName = "Evan", LastName = "Boehm", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 76, Height = "6-3", Weight = 321, Age = 26, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Jesse", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 77, Height = "6-6", Weight = 325, Age = 28, CollegeName = "Idaho" },
                new TeamMember { FirstName = "Mike", LastName = "Gesickl", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 88, Height = "6-6", Weight = 250, Age = 24, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Ryan", LastName = "Fitzpatrick", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 14, Height = "6-2", Weight = 228, Age = 37, CollegeName = "Harvard" },
                new TeamMember { FirstName = "Kalen", LastName = "Ballage", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 27, Height = "6-2", Weight = 231, Age = 24, CollegeName = "Arizona State" },
                new TeamMember { FirstName = "Albert", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 15, Height = "5-9", Weight = 195, Age = 27, CollegeName = "Georgia State" },
                new TeamMember { FirstName = "Jakeem", LastName = "Grant", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 19, Height = "5-7", Weight = 171, Age = 27, CollegeName = "Texas Tech" },
                // Defense
                new TeamMember { FirstName = "John", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 95, Height = "6-3", Weight = 327, Age = 30, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Davon", LastName = "Godchaux", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 56, Height = "6-3", Weight = 311, Age = 25, CollegeName = "LSU" },
                new TeamMember { FirstName = "Christian", LastName = "Wilkins", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 94, Height = "6-4", Weight = 315, Age = 23, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Sam", LastName = "Eguavoen", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], JerseyNumber = 49, Height = "6-0", Weight = 236, Age = 26, CollegeName = "Texas Tech" },
                new TeamMember { FirstName = "Raekwon", LastName = "McMillan", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], JerseyNumber = 52, Height = "6-2", Weight = 242, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Jerome", LastName = "Baker", Position = Constants.Positions[Enums.PositionEnum.Linebacker_3], JerseyNumber = 55, Height = "6-2", Weight = 225, Age = 22, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Charles", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Linebacker_4], JerseyNumber = 90, Height = "6-3", Weight = 252, Age = 24, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Ken", LastName = "Webster", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 31, Height = "5-11", Weight = 201, Age = 23, CollegeName = "Mississippi" },
                new TeamMember { FirstName = "Eric", LastName = "Rowe", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 21, Height = "6-1", Weight = 205, Age = 27, CollegeName = "Utah" },
                new TeamMember { FirstName = "Reshad", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 20, Height = "6-1", Weight = 215, Age = 31, CollegeName = "Georgia Tech" },
                new TeamMember { FirstName = "Bobby", LastName = "McCain", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 28, Height = "5-11", Weight = 192, Age = 26, CollegeName = "Memphis" },
                // Kicker
                new TeamMember { FirstName = "Jason", LastName = "Sanders", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 7, Height = "5-11", Weight = 186, Age = 24, CollegeName = "New Mexico" },
                new TeamMember { FirstName = "Matt", LastName = "Haack", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 2, Height = "6-0", Weight = 205, Age = 25, CollegeName = "Arizona State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach{ FirstName = "Brian", LastName = "Flores", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach{ FirstName = "Chad", LastName = "O'Shea", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach{ FirstName = "Patrick", LastName = "Graham", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach{ FirstName = "Danny", LastName = "Crossman", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] },
                new Coach{ FirstName = "Jim", LastName = "Caldwell", Title = Constants.Positions[Enums.PositionEnum.Assistant_Coach] }
            };
        }

        private static List<Schedule> GetMiamiDolphinsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
