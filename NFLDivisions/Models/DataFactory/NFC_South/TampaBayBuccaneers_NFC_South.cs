using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class TampaBayBuccaneers_NFC_South
    {
        private const string _teamName = "Tampa Bay Buccaneers";
        private const string _city = "Tampa Bay";
        private const string _state = "Florida";
        private const string _stadiumName = "Raymond James Statium";

        public static TeamInformation GetTampaBayBuccaneersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_South],
                Colors = new List<string> { "Black", "Old Gold", "White" },
                SeasonSchedule = GetTampaBayBuccaneersSchedule(year),
                Players = GetTampaBayBuccaneersRoster(year),
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

        public static List<TeamMember> GetTampaBayBuccaneersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Mike", LastName = "Evans", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 13, Height = "6-5", Weight = 231, Age = 26, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Cameron", LastName = "Brate", Position = Constants.Positions[Enums.PositionEnum.Tight_End_1], JerseyNumber = 84, Height = "6-5", Weight = 245, Age = 28, CollegeName = "Harvard" },
                new TeamMember { FirstName = "Donovan", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 76, Height = "6-6", Weight = 338, Age = 26, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Ali", LastName = "Marpet", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 74, Height = "6-4", Weight = 307, Age = 26, CollegeName = "Hobart" },
                new TeamMember { FirstName = "Ryan", LastName = "Jenson", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 66, Height = "6-4", Weight = 319, Age = 28, CollegeName = "Colorado State-Pueblo" },
                new TeamMember { FirstName = "Alex", LastName = "Cappa", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 65, Height = "6-6", Weight = 305, Age = 24, CollegeName = "Humboldt State" },
                new TeamMember { FirstName = "Demar", LastName = "Dotson", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 69, Height = "6-9", Weight = 315, Age = 34, CollegeName = "Southern Mississippi" },
                new TeamMember { FirstName = "O.J.", LastName = "Howard", Position = Constants.Positions[Enums.PositionEnum.Tight_End_2], JerseyNumber = 80, Height = "6-6", Weight = 251, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Chris", LastName = "Godwin", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 12, Height = "6-1", Weight = 209, Age = 23, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Jameis", LastName = "Winston", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 3, Height = "6-4", Weight = 231, Age = 25, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Ronald", LastName = "Jones II", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 27, Height = "5-11", Weight = 208, Age = 22, CollegeName = "USC" },
                // Defense
                new TeamMember { FirstName = "Ndamukong", LastName = "Suh", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 93, Height = "6-4", Weight = 313, Age = 32, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Vita", LastName = "Vea", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 50, Height = "6-4", Weight = 347, Age = 24, CollegeName = "Washington" },
                new TeamMember { FirstName = "William", LastName = "Gholston", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 92, Height = "6-6", Weight = 281, Age = 28, CollegeName = "Michigan State" },
                new TeamMember { FirstName = "Carl", LastName = "Nassib", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 94, Height = "6-7", Weight = 275, Age = 26, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Devin", LastName = "White", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 45, Height = "6-0", Weight = 237, Age = 21, CollegeName = "LSU" },
                new TeamMember { FirstName = "Lavonte", LastName = "David", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 54, Height = "6-1", Weight = 233, Age = 29, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Shaquil", LastName = "Barrett", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 58, Height = "6-2", Weight = 250, Age = 27, CollegeName = "Colorado State" },
                new TeamMember { FirstName = "Carlton", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 33, Height = "6-1", Weight = 206, Age = 22, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Sean", LastName = "Murphy-Bunting", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 26, Height = "6-0", Weight = 195, Age = 22, CollegeName = "Central Michigan" },
                new TeamMember { FirstName = "Mike", LastName = "Edwards", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 34, Height = "5-10", Weight = 205, Age = 23, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Jordan", LastName = "Whitehead", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 31, Height = "5-10", Weight = 198, Age = 22, CollegeName = "Pittsburgh" },
                // Kicker
                new TeamMember { FirstName = "Matt", LastName = "Gay", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 9, Height = "6-0", Weight = 232, Age = 25, CollegeName = "Utah" },
                new TeamMember { FirstName = "Bradley", LastName = "Pinion", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 8, Height = "6-5", Weight = 240, Age = 25, CollegeName = "Clemson" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Bruce", LastName = "Arians", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Byron", LastName = "Leftwich", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Todd", LastName = "Bowles", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Keith", LastName = "Armstrong", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetTampaBayBuccaneersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
