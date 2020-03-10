
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class ClevelandBrowns_AFC_North
    {
        private const string _teamName = "Cleveland Browns";
        private const string _city = "Cleveland";
        private const string _state = "Ohio";
        private const string _stadiumName = "FirstEnergy";

        public static TeamInformation GetClevelandBrownsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_North],
                Colors = new List<string> { "Black", "Gold", "White" },
                SeasonSchedule = GetClevelandBrownsSchedule(year),
                Players = GetClevelandBrownsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 3,
                    TotalWins = 4,
                    TotalLosses = 6,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetClevelandBrownsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Jarvis", LastName = "Landry", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 80, Height = "5-11", Weight = 196, Age = 27, CollegeName = "LSU" },
                new TeamMember { FirstName = "Greg", LastName = "Robinson", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 78, Height = "6-5", Weight = 330, Age = 27, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Joel", LastName = "Bitonio", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 75, Height = "6-4", Weight = 320, Age = 28, CollegeName = "Nevada" },
                new TeamMember { FirstName = "JC", LastName = "Tretter", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 64, Height = "6-4", Weight = 307, Age = 28, CollegeName = "Cornell" },
                new TeamMember { FirstName = "Wyatt", LastName = "Teller", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 77, Height = "6-4", Weight = 315, Age = 25, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Chris", LastName = "Hubbard", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 74, Height = "6-4", Weight = 295, Age = 28, CollegeName = "Alabama-Birmingham" },
                new TeamMember { FirstName = "Pharaoh", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Tight_End_1], JerseyNumber = 86, Height = "6-6", Weight = 258, Age = 25, CollegeName = "Oregon" },
                new TeamMember { FirstName = "Odell", LastName = "Beckham Jr", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 13, Height = "5-11", Weight = 198, Age = 27, CollegeName = "LSU" },
                new TeamMember { FirstName = "Baker", LastName = "Mayfield", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 6, Height = "6-1", Weight = 215, Age = 24, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Nick", LastName = "Chubb", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 24, Height = "5-11", Weight = 227, Age = 23, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Demetrius", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Tight_End_2], JerseyNumber = 88, Height = "6-7", Weight = 230, Age = 28, CollegeName = "Wisconsin-Milwaukee" },
                // Defense
                new TeamMember { FirstName = "Chad", LastName = "Thomas", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 92, Height = "6-5", Weight = 278, Age = 24, CollegeName = "Miami(Fla.)" },
                new TeamMember { FirstName = "Larry", LastName = "Ogunjobi", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_Tackle], JerseyNumber = 65, Height = "6-3", Weight = 305, Age = 25, CollegeName = "Charlotte" },
                new TeamMember { FirstName = "Sheldon", LastName = "Richardson", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_Tackle], JerseyNumber = 98, Height = "6-3", Weight = 294, Age = 29, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Oliver", LastName = "Vernon", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 54, Height = "6-2", Weight = 262, Age = 29, CollegeName = "Miami(Fla.)" },
                new TeamMember { FirstName = "Mack", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 51, Height = "6-1", Weight = 240, Age = 21, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Joe", LastName = "Schobert", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 53, Height = "6-1", Weight = 245, Age = 26, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Adarius", LastName = "Taylor", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 57, Height = "6-0", Weight = 230, Age = 29, CollegeName = "Florida Atlantic" },
                new TeamMember { FirstName = "Denzel", LastName = "Ward", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 21, Height = "5-11", Weight = 190, Age = 22, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Greedy", LastName = "William", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 26, Height = "6-2", Weight = 185, Age = 21, CollegeName = "LSU" },
                new TeamMember { FirstName = "Damarious", LastName = "Randall", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 23, Height = "5-11", Weight = 196, Age = 27, CollegeName = "Arizona State" },
                new TeamMember { FirstName = "Juston", LastName = "Burris", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 31, Height = "6-0", Weight = 212, Age = 26, CollegeName = "North Carolina State" },
                // Kicker
                new TeamMember { FirstName = "Austin", LastName = "Selbert", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "5-9", Weight = 214, Age = 23, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Jamie", LastName = "Gillan", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 7, Height = "6-1", Weight = 207, Age = 22, CollegeName = "Arkansas Pine-Bluff" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Freddie", LastName = "Kitchens", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Todd", LastName = "Monken", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Steve", LastName = "Wilks", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Mike", LastName = "Priefer", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetClevelandBrownsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
