
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class CincinnatiBengals_AFC_North
    {
        private const string _teamName = "Cincinnati Bengals";
        private const string _city = "Cincinnati";
        private const string _state = "Ohio";
        private const string _stadiumName = "Paul Brown Stadium";

        public static TeamInformation GetCincinnatiBengalsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_North],
                Colors = new List<string> { "Black", "Orange", "White" },
                SeasonSchedule = GetCincinnatiBengalsSchedule(year),
                Players = GetCincinnatiBengalsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 0,
                    TotalLosses = 10,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetCincinnatiBengalsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Ryan", LastName = "Finley", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 5, Height = "6-4", Weight = 207, Age = 24, CollegeName = "NC State" },
                new TeamMember { FirstName = "Joe", LastName = "Mixon", Position = Constants.Positions[Enums.PositionEnum.Half_Back], JerseyNumber = 28, Height = "6-1", Weight = 220, Age = 23, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "A.J.", LastName = "Green", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 18, Height = "6-4", Weight = 210, Age = 31, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Tyler", LastName = "Boyd", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 83, Height = "6-2", Weight = 203, Age = 25, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Auden", LastName = "Tate", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 19, Height = "6-5", Weight = 228, Age = 22, CollegeName = "Florida State" },
                new TeamMember { FirstName = "C.J.", LastName = "Uzomah", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 87, Height = "6-6", Weight = 260, Age = 26, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Cordy", LastName = "Glenn", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 77, Height = "6-6", Weight = 345, Age = 30, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Billy", LastName = "Price", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 53, Height = "6-4", Weight = 310, Age = 25, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Trey", LastName = "Hopkins", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 66, Height = "6-3", Weight = 316, Age = 27, CollegeName = "Texas" },
                new TeamMember { FirstName = "John", LastName = "Miller", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 67, Height = "6-3", Weight = 315, Age = 26, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Bobby", LastName = "Hart", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 68, Height = "6-5", Weight = 310, Age = 25, CollegeName = "Florida State" },
                // Defense
                new TeamMember { FirstName = "Carlos", LastName = "Dunlap", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 96, Height = "6-6", Weight = 285, Age = 30, CollegeName = "Florida" },
                new TeamMember { FirstName = "Andrew", LastName = "Billings", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 99, Height = "6-1", Weight = 328, Age = 24, CollegeName = "Baylor" },
                new TeamMember { FirstName = "Geno", LastName = "Atkins", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 97, Height = "6-1", Weight = 300, Age = 31, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Sam", LastName = "Hubbard", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 94, Height = "6-5", Weight = 265, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Nick", LastName = "Vigil", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], JerseyNumber = 59, Height = "6-2", Weight = 235, Age = 26, CollegeName = "Utah State" },
                new TeamMember { FirstName = "Germaine", LastName = "Pratt", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], JerseyNumber = 57, Height = "6-2", Weight = 245, Age = 23, CollegeName = "NC State" },
                new TeamMember { FirstName = "Darqueze", LastName = "Dennard", Position = Constants.Positions[Enums.PositionEnum.NickelBack], JerseyNumber = 21, Height = "5-11", Weight = 205, Age = 28, CollegeName = "Michigan State" },
                new TeamMember { FirstName = "B.W.", LastName = "Webb", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "5-11", Weight = 188, Age = 29, CollegeName = "William & Mary" },
                new TeamMember { FirstName = "William", LastName = "Jackson III", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 22, Height = "6-0", Weight = 196, Age = 27, CollegeName = "Houston" },
                new TeamMember { FirstName = "Shawn", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 36, Height = "6-0", Weight = 212, Age = 28, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Jessie", LastName = "Bates III", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 30, Height = "6-1", Weight = 200, Age = 22, CollegeName = "Wake Forest" },
                // Kicker
                new TeamMember { FirstName = "Randy", LastName = "Bullock", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "5-9", Weight = 210, Age = 29, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Kevin", LastName = "Huber", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 10, Height = "6-1", Weight = 210, Age = 34, CollegeName = "Cincinnati" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Zac", LastName = "Taylor", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Brian", LastName = "Callahan", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Lou", LastName = "Anarumo", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Darrin", LastName = "Simmons", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetCincinnatiBengalsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
