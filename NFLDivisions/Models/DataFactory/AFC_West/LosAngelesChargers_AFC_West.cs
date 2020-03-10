
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class LosAngelesChargers_AFC_West
    {
        private const string _teamName = "Los Angeles Chargers";
        private const string _city = "Los Angeles";
        private const string _state = "California";
        private const string _stadiumName = "Digty Health Sports Park";

        public static TeamInformation GetLosAngelesChargersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_West],
                Colors = new List<string> { "White", "Gold", "Navy Blue", "Powder Blue" },
                SeasonSchedule = GetLosAngelesChargersSchedule(year),
                Players = GetLosAngelesChargersRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 3,
                    TotalWins = 4,
                    TotalLosses = 7,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetLosAngelesChargersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Keenan", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 13, Height = "6-2", Weight = 211, Age = 27, CollegeName = "College" },
                new TeamMember { FirstName = "Russell", LastName = "Okung", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 76, Height = "6-5", Weight = 310, Age = 31, CollegeName = "Oklahoma State" },
                new TeamMember { FirstName = "Dan", LastName = "Feeney", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 66, Height = "6-4", Weight = 310, Age = 25, CollegeName = "Indiana" },
                new TeamMember { FirstName = "Scott", LastName = "Quessenberry", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 61, Height = "6-3", Weight = 310, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Michael", LastName = "Scholfield III", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 75, Height = "6-6", Weight = 301, Age = 29, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Sam", LastName = "Tevi", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 69, Height = "6-5", Weight = 315, Age = 25, CollegeName = "Utah" },
                new TeamMember { FirstName = "Hunter", LastName = "Henry", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 86, Height = "6-5", Weight = 250, Age = 24, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Mike", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 81, Height = "6-4", Weight = 220, Age = 25, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Philip", LastName = "Rivers", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 17, Height = "6-5", Weight = 228, Age = 37, CollegeName = "North Carolina State" },
                new TeamMember { FirstName = "Derek", LastName = "Watt", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 34, Height = "6-2", Weight = 234, Age = 27, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Melvin", LastName = "Gordon III", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 25, Height = "6-1", Weight = 215, Age = 26, CollegeName = "Wisconsin" },
                // Defense
                new TeamMember { FirstName = "Joey", LastName = "Bosa", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 97, Height = "6-5", Weight = 280, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Justin", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 93, Height = "6-3", Weight = 309, Age = 23, CollegeName = "North Carolina State" },
                new TeamMember { FirstName = "Brandon", LastName = "Mebane", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 92, Height = "6-1", Weight = 311, Age = 34, CollegeName = "California" },
                new TeamMember { FirstName = "Melvin", LastName = "Ingram III", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 54, Height = "6-2", Weight = 247, Age = 30, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Thomas", LastName = "Davis Sr.", Position = Constants.Positions[Enums.PositionEnum.Linebacker_1], JerseyNumber = 58, Height = "6-1", Weight = 235, Age = 36, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Denzel", LastName = "Perryman", Position = Constants.Positions[Enums.PositionEnum.Linebacker_2], JerseyNumber = 52, Height = "5-11", Weight = 240, Age = 26, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Uchenna", LastName = "Nwosu", Position = Constants.Positions[Enums.PositionEnum.Linebacker_3], JerseyNumber = 42, Height = "6-2", Weight = 251, Age = 22, CollegeName = "USC" },
                new TeamMember { FirstName = "Brandon", LastName = "Facyson", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 28, Height = "6-2", Weight = 197, Age = 25, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Rayshawn", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 23, Height = "6-1", Weight = 220, Age = 25, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Roderic", LastName = "Teamer", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 36, Height = "6-0", Weight = 205, Age = 22, CollegeName = "Tulane" },
                new TeamMember { FirstName = "Casey", LastName = "Hayward Jr.", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 26, Height = "5-11", Weight = 192, Age = 30, CollegeName = "Vanderbilt" },
                // Kicker
                new TeamMember { FirstName = "Michael", LastName = "Badgley", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "5-10", Weight = 183, Age = 24, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Ty", LastName = "Long", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 1, Height = "6-2", Weight = 205, Age = 26, CollegeName = "Alabama-Birmingham" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Anthony", LastName = "Lynn", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Shane", LastName = "Steichen", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Gus", LastName = "Bradley", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "George", LastName = "Stewart", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetLosAngelesChargersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
