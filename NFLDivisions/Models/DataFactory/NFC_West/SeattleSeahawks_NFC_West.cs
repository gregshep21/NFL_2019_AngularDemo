
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class SeattleSeahawks_NFC_West
    {
        private const string _teamName = "Seattle Seahawks";
        private const string _city = "Seattle";
        private const string _state = "Washington";
        private const string _stadiumName = "Century Link Field";

        public static TeamInformation GetSeattleSeahawksInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_West],
                Colors = new List<string> { "Blue", "Bright Green", "Silver" },
                SeasonSchedule = GetSeattleSeahawksSchedule(year),
                Players = GetSeattleSeahawksRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 8,
                    TotalLosses = 2,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetSeattleSeahawksRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "DK", LastName = "Metcalf", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 14, Height = "6-4", Weight = 229, Age = 21, CollegeName = "Ole Miss" },
                new TeamMember { FirstName = "Duane", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 76, Height = "6-4", Weight = 315, Age = 34, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Mike", LastName = "Lupati", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 70, Height = "6-5", Weight = 331, Age = 32, CollegeName = "Idaho" },
                new TeamMember { FirstName = "Joey", LastName = "Hunt", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 53, Height = "6-2", Weight = 299, Age = 25, CollegeName = "Texas Christian University" },
                new TeamMember { FirstName = "D.J.", LastName = "Fluker", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 78, Height = "6-5", Weight = 342, Age = 28, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Germain", LastName = "Ifedi", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 65, Height = "6-5", Weight = 325, Age = 25, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Luke", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 82, Height = "6-5", Weight = 255, Age = 29, CollegeName = "Rice" },
                new TeamMember { FirstName = "Tyler", LastName = "Lockett", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 16, Height = "5-10", Weight = 182, Age = 27, CollegeName = "Kansas State" },
                new TeamMember { FirstName = "Russell", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 3, Height = "5-11", Weight = 215, Age = 31, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Nick", LastName = "Bellore", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 44, Height = "6-1", Weight = 250, Age = 30, CollegeName = "Central Michigan" },
                new TeamMember { FirstName = "Chris", LastName = "Carson", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 32, Height = "5-11", Weight = 222, Age = 25, CollegeName = "Oklahoma State" },
                // Defense
                new TeamMember { FirstName = "Jadeveon", LastName = "Clowney", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 90, Height = "6-5", Weight = 255, Age = 26, CollegeName = "Southh Carolina" },
                new TeamMember { FirstName = "Jarran", LastName = "Reed", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 91, Height = "6-3", Weight = 306, Age = 26, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Poona", LastName = "Ford", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 97, Height = "5-11", Weight = 310, Age = 24, CollegeName = "Texas" },
                new TeamMember { FirstName = "Ziggy", LastName = "Ansah", Position = Constants.Positions[Enums.PositionEnum.Linebacker_End_LEO], JerseyNumber = 94, Height = "6-5", Weight = 275, Age = 30, CollegeName = "Brigham Young" },
                new TeamMember { FirstName = "Mychal", LastName = "Kendricks", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 56, Height = "5-11", Weight = 240, Age = 29, CollegeName = "California" },
                new TeamMember { FirstName = "Bobby", LastName = "Wagner", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 54, Height = "6-0", Weight = 242, Age = 29, CollegeName = "Utah State" },
                new TeamMember { FirstName = "K.J.", LastName = "Wright", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 50, Height = "6-4", Weight = 246, Age = 30, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Shaquill", LastName = "Griffin", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 26, Height = "6-0", Weight = 198, Age = 24, CollegeName = "UCF" },
                new TeamMember { FirstName = "Tre", LastName = "Flowers", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 21, Height = "6-3", Weight = 203, Age = 24, CollegeName = "Oklahoma State" },
                new TeamMember { FirstName = "Bradley", LastName = "McDougald", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 30, Height = "6-1", Weight = 215, Age = 29, CollegeName = "Kansas" },
                new TeamMember { FirstName = "Marquise", LastName = "Blair", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 27, Height = "6-1", Weight = 196, Age = 22, CollegeName = "Utah" },
                // Kicker
                new TeamMember { FirstName = "Jason", LastName = "Myers", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 5, Height = "5-10", Weight = 190, Age = 28, CollegeName = "Marist" },
                new TeamMember { FirstName = "Michael", LastName = "Dickson", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 4, Height = "6-2", Weight = 208, Age = 23, CollegeName = "Texas" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Pete", LastName = "Carroll", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Brian", LastName = "Schottenheimer", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Ken", LastName = "Norton Jr", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Brian", LastName = "Schneider", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] },
            };
        }

        private static List<Schedule> GetSeattleSeahawksSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
