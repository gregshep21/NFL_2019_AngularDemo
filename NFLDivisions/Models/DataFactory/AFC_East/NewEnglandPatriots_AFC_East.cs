
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NewEnglandPatriots_AFC_East
    {
        private const string _teamName = "New England Patriots";
        private const string _city = "Foxborough";
        private const string _state = "Massachusetts";
        private const string _stadiumName = "Gillette Stadium";

        internal static TeamInformation GetNewEnglandPatriotsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_East],
                Colors = new List<string> { "White", "New Century Silver", "Red", "Nautical Blue" },
                SeasonSchedule = GetNewEnglandPatriotsSchedule(year),
                Players = GetNewEnglandPatriotsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 9,
                    TotalLosses = 1,
                    Ties = 0
                }
            };
        }

        private static List<TeamMember> GetNewEnglandPatriotsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Phillip", LastName = "Dorsett II", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], Age = 26, Height = "5-10", Weight = 192, CollegeName = "Miami(Fla.)", JerseyNumber = 13 },
                new TeamMember { FirstName = "Marshall", LastName = "Newhouse", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], Age = 31, Height = "6-4", Weight = 330, CollegeName = "Texas Christian", JerseyNumber = 72 },
                new TeamMember { FirstName = "Joe", LastName = "Thuney", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], Age = 27, Height = "6-5", Weight = 308, CollegeName = "North Carolina State", JerseyNumber = 62 },
                new TeamMember { FirstName = "Ted", LastName = "Karras", Position = Constants.Positions[Enums.PositionEnum.Center], Age = 26, Height = "6-4", Weight = 305, CollegeName = "Illinois", JerseyNumber = 75 },
                new TeamMember { FirstName = "Shaq", LastName = "Mason", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], Age = 26, Height = "6-1", Weight = 310, CollegeName = "Georgia Tech", JerseyNumber = 69 },
                new TeamMember { FirstName = "Marcus", LastName = "Cannon", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], Age = 31, Height = "6-6", Weight = 335, CollegeName = "Texas Christian", JerseyNumber = 61 },
                new TeamMember { FirstName = "Ben", LastName = "Watson", Position = Constants.Positions[Enums.PositionEnum.Tight_End], Age = 38, Height = "6-3", Weight = 255, CollegeName = "Georgia", JerseyNumber = 84 },
                new TeamMember { FirstName = "Julian", LastName = "Edelman", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], Age = 33, Height = "5-10", Weight = 198, CollegeName = "Kent State", JerseyNumber = 11 },
                new TeamMember { FirstName = "Tom", LastName = "Brady", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], Age = 42, Height = "6-4", Weight = 225, CollegeName = "Michigan", JerseyNumber = 12 },
                new TeamMember { FirstName = "Sony", LastName = "Michel", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], Age = 26, Height = "5-11", Weight = 215, CollegeName = "Georgia", JerseyNumber = 26 },
                new TeamMember { FirstName = "James", LastName = "White", Position = Constants.Positions[Enums.PositionEnum.Running_Back_2], Age = 28, Height = "5-10", Weight = 205, CollegeName = "Wisconsin", JerseyNumber = 28 },
                // Defense
                new TeamMember { FirstName = "Lawrence", LastName = "Guy", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], Age = 29, Height = "6-4", Weight = 315, CollegeName = "Arizona State", JerseyNumber = 93 },
                new TeamMember { FirstName = "Danny", LastName = "Sheldon", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], Age = 26, Height = "6-2", Weight = 345, CollegeName = "Washington", JerseyNumber = 71 },
                new TeamMember { FirstName = "John", LastName = "Simon", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], Age = 29, Height = "6-2", Weight = 260, CollegeName = "Ohio State", JerseyNumber = 55 },
                new TeamMember { FirstName = "Jamie", LastName = "Collins Sr", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], Age = 30, Height = "6-3", Weight = 255, CollegeName = "Southern Mississippi", JerseyNumber = 58 },
                new TeamMember { FirstName = "Dont'a", LastName = "Hightower", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], Age = 29, Height = "6-3", Weight = 260, CollegeName = "Alabama", JerseyNumber = 29 },
                new TeamMember { FirstName = "Elandon", LastName = "Roberts", Position = Constants.Positions[Enums.PositionEnum.Linebacker_3], Age = 25, Height = "6-0", Weight = 238, CollegeName = "Houston", JerseyNumber = 52 },
                new TeamMember { FirstName = "Kyle", LastName = "Van Noy", Position = Constants.Positions[Enums.PositionEnum.Linebacker_4], Age = 28, Height = "6-3", Weight = 250, CollegeName = "Brigham Young", JerseyNumber = 53 },
                new TeamMember { FirstName = "Stephon", LastName = "Gilmore", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], Age = 24, Height = "6-1", Weight = 202, CollegeName = "South Carolina", JerseyNumber = 24 },
                new TeamMember { FirstName = "Jason", LastName = "McCourty", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], Age = 30, Height = "5-11", Weight = 195, CollegeName = "Rutgers", JerseyNumber = 30 },
                new TeamMember { FirstName = "Patrick", LastName = "Chung", Position = Constants.Positions[Enums.PositionEnum.Safety], Age = 23, Height = "5-11", Weight = 215, CollegeName = "Oregon", JerseyNumber =  23},
                new TeamMember { FirstName = "Devin", LastName = "McCourty", Position = Constants.Positions[Enums.PositionEnum.Safety], Age = 32, Height = "5-10", Weight = 195, CollegeName = "Rutgers", JerseyNumber = 32 },
                // Kicker
                new TeamMember { FirstName = "Kai", LastName = "Forbath", Position = Constants.Positions[Enums.PositionEnum.Kicker], Age = 32, Height = "511", Weight = 197, CollegeName = "UCLA", JerseyNumber = 5 },
                new TeamMember { FirstName = "Jake", LastName = "Bailey", Position = Constants.Positions[Enums.PositionEnum.Holder], Age = 22, Height = "6-2", Weight = 205, CollegeName = "Stanford", JerseyNumber = 7 }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach{ FirstName = "Bill", LastName = "Belichick", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach{ FirstName = "Josh", LastName = "McDaniels", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach{ FirstName = "Joe", LastName = "Judge", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetNewEnglandPatriotsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
