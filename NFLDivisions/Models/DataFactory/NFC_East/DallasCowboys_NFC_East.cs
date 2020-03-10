
using System.Collections.Generic;


namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class DallasCowboys_NFC_East
    {
        private const string _teamName = "Dallas Cowboys";
        private const string _city = "Dallas";
        private const string _state = "Texas";
        private const string _stadiumName = "AT&T Stadium";

        public static TeamInformation GetDallasCowboysInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_East],
                Colors = new List<string> { "Blue", "White", "Navy Blue", "Royal Blue", "Silver" },
                SeasonSchedule = GetDallasCowboysSchedule(year),
                Players = GetDallasCowboysRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 6,
                    TotalLosses = 4,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetDallasCowboysRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Dak", LastName = "Prescott", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 4, Height = "6-2", Weight = 238, Age = 26, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Ezeklel", LastName = "Elliott", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 21, Height = "6-0", Weight = 228, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Jamize", LastName = "Olawale", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 49, Height = "6-1", Weight = 240, Age = 30, CollegeName = "North Texas" },
                new TeamMember { FirstName = "Amari", LastName = "Cooper", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 19, Height = "6-1", Weight = 210, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Randall", LastName = "Cobbs", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 18, Height = "5-10", Weight = 192, Age = 29, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Michael", LastName = "Gallup", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 13, Height = "6-1", Weight = 198, Age = 23, CollegeName = "Colorado State" },
                new TeamMember { FirstName = "Jason", LastName = "Witten", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 82, Height = "6-6", Weight = 263, Age = 37, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Tyron", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 77, Height = "6-5", Weight = 320, Age = 28, CollegeName = "USC" },
                new TeamMember { FirstName = "Connor", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 52, Height = "6-5", Weight = 298, Age = 22, CollegeName = "Texas" },
                new TeamMember { FirstName = "Travis", LastName = "Frederick", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 72, Height = "6-4", Weight = 320, Age = 28, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Zack", LastName = "Martin", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 70, Height = "6-4", Weight = 315, Age = 29, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "La'el", LastName = "Collins", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-4", Weight = 320, Age = 26, CollegeName = "LSU" },
                // Defense
                new TeamMember { FirstName = "DeMarcus", LastName = "Lawrence", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 90, Height = "6-3", Weight = 265, Age = 27, CollegeName = "Boise State" },
                new TeamMember { FirstName = "Maliek", LastName = "Collins", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 96, Height = "6-2", Weight = 308, Age = 24, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Antwaun", LastName = "Woods", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 99, Height = "6-1", Weight = 318, Age = 26, CollegeName = "USC" },
                new TeamMember { FirstName = "Tyrone", LastName = "Crawford", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 98, Height = "6-4", Weight = 290, Age = 30, CollegeName = "Boise State" },
                new TeamMember { FirstName = "Sean", LastName = "Lee", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 50, Height = "6-2", Weight = 245, Age = 33, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Jaylon", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 54, Height = "6-2", Weight = 245, Age = 24, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Leighton", LastName = "Vander Esch", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 55, Height = "6-4", Weight = 256, Age = 22, CollegeName = "Boise State" },
                new TeamMember { FirstName = "Chidobe", LastName = "Awuzle", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 24, Height = "6-0", Weight = 202, Age = 24, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Bryon", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 31, Height = "6-0", Weight = 205, Age = 27, CollegeName = "Connecticut" },
                new TeamMember { FirstName = "Jeff", LastName = "Heath", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 38, Height = "6-1", Weight = 212, Age = 28, CollegeName = "Saginaw Valley State" },
                new TeamMember { FirstName = "Xavier", LastName = "Woods", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 25, Height = "5-11", Weight = 202, Age = 24, CollegeName = "Louisiana Tech" },
                // Kicker
                new TeamMember { FirstName = "Chris", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 6, Height = "6-0", Weight = 205, Age = 30, CollegeName = "Carson-Newman" },
                new TeamMember { FirstName = "Brett", LastName = "Maher", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 2, Height = "6-1", Weight = 183, Age = 30, CollegeName = "Nebraska" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Jason", LastName = "Garrett", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Kellen", LastName = "Moore", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Rod", LastName = "Marinelli", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Keith", LastName = "O'Quinn", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetDallasCowboysSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
