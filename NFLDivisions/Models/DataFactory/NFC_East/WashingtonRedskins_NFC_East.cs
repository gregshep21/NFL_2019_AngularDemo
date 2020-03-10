using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class WashingtonRedskins_NFC_East
    {
        private const string _teamName = "Washington Redskins";
        private const string _city = "Washington";
        private const string _state = "District of Columbia";
        private const string _stadiumName = "FedEx Field";

        public static TeamInformation GetWashingtonRedskinsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_East],
                Colors = new List<string> { "White", "Burgundy", "Gold" },
                SeasonSchedule = GetWashingtonRedskinsSchedule(year),
                Players = GetWashingtonRedskinsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 1,
                    TotalLosses = 9,
                    Ties = 0,
                }
            };
        }


        public static List<TeamMember> GetWashingtonRedskinsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Terry", LastName = "McLaurin", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 17, Height = "6-0", Weight = 210, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Donald", LastName = "Penn", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 72, Height = "6-4", Weight = 315, Age = 36, CollegeName = "Utah State" },
                new TeamMember { FirstName = "Ereck", LastName = "Flowers", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 77, Height = "6-6", Weight = 330, Age = 25, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Chase", LastName = "Roullier", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 73, Height = "6-4", Weight = 312, Age = 26, CollegeName = "Wyoming" },
                new TeamMember { FirstName = "Brandon", LastName = "Scherff", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 75, Height = "6-5", Weight = 315, Age = 27, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Morgan", LastName = "Moses", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 76, Height = "6-6", Weight = 330, Age = 28, CollegeName = "Virginia" },
                new TeamMember { FirstName = "Vernon", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 85, Height = "6-3", Weight = 248, Age = 35, CollegeName = "Maryland" },
                new TeamMember { FirstName = "Trey", LastName = "Quinn", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 18, Height = "6-0", Weight = 200, Age = 23, CollegeName = "SMU" },
                new TeamMember { FirstName = "Paul", LastName = "Richardson Jr", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 10, Height = "6-0", Weight = 180, Age = 27, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Dwayne", LastName = "Haskins", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 7, Height = "6-4", Weight = 230, Age = 22, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Adrian", LastName = "Peterson", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 26, Height = "6-1", Weight = 220, Age = 34, CollegeName = "Oklahoma" },
                // Defense
                new TeamMember { FirstName = "Johnathan", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 93, Height = "6-3", Weight = 300, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Daron", LastName = "Payne", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 94, Height = "6-3", Weight = 320, Age = 22, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Matt", LastName = "Loannidis", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 98, Height = "6-3", Weight = 310, Age = 25, CollegeName = "Temple" },
                new TeamMember { FirstName = "Montez", LastName = "Sweat", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 90, Height = "6-6", Weight = 262, Age = 23, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Cole", LastName = "Holcomb", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 55, Height = "6-1", Weight = 240, Age = 23, CollegeName = "North Carolina" },
                new TeamMember { FirstName = "Jon", LastName = "Bostic", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 53, Height = "6-1", Weight = 245, Age = 28, CollegeName = "Florida" },
                new TeamMember { FirstName = "Ryan", LastName = "Kerrigan", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 91, Height = "6-4", Weight = 265, Age = 31, CollegeName = "Purdue" },
                new TeamMember { FirstName = "Quinton", LastName = "Dunbar", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "6-2", Weight = 202, Age = 27, CollegeName = "Florida" },
                new TeamMember { FirstName = "Josh", LastName = "Norman", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 24, Height = "6-0", Weight = 200, Age = 31, CollegeName = "Coastal Carolina" },
                new TeamMember { FirstName = "Landon", LastName = "Collins", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 20, Height = "6-0", Weight = 218, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Montae", LastName = "Nicholson", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 35, Height = "6-2", Weight = 212, Age = 23, CollegeName = "Michigan State" },
                // Kicker
                new TeamMember { FirstName = "Dustin", LastName = "Hopkins", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 3, Height = "6-2", Weight = 205, Age = 29, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Tress", LastName = "Way", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 5, Height = "6-1", Weight = 220, Age = 29, CollegeName = "Oklahoma" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Bill", LastName = "Callahan", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Kevin", LastName = "O'Connell", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Greg", LastName = "Manusky", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Nate", LastName = "Kaczor", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetWashingtonRedskinsSchedule(int year)
        {
            return new List<Schedule>();
        }

    }
}
