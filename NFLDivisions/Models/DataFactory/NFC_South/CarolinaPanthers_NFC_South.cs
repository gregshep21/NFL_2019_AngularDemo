using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class CarolinaPanthers_NFC_South
    {
        private const string _teamName = "Carolina Panthers";
        private const string _city = "Charlotte";
        private const string _state = "North Carolina";
        private const string _stadiumName = "Bank Of America Statium";

        public static TeamInformation GetCarolinaPanthersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_South],
                Colors = new List<string> { "Black", "White", "Blue", "Silver" },
                SeasonSchedule = GetCarolinaPanthersSchedule(year),
                Players = GetCarolinaPanthersRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 5,
                    TotalLosses = 5,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetCarolinaPanthersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "DJ", LastName = "Moore", Position = Constants.Positions[Enums.PositionEnum.Left_Wide_Reciever], JerseyNumber = 12, Height = "5-11", Weight = 215, Age = 22, CollegeName = "Maryland" },
                new TeamMember { FirstName = "Dennis", LastName = "Daley", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 65, Height = "6-6", Weight = 325, Age = 23, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Greg", LastName = "Van Roten", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 73, Height = "6-3", Weight = 305, Age = 29, CollegeName = "Pennsylvania" },
                new TeamMember { FirstName = "Matt", LastName = "Paradis", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 61, Height = "6-3", Weight = 300, Age = 30, CollegeName = "Boise State" },
                new TeamMember { FirstName = "Trai", LastName = "Turner", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 70, Height = "6-3", Weight = 315, Age = 26, CollegeName = "LSU" },
                new TeamMember { FirstName = "Taylor", LastName = "Moton", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 72, Height = "6-5", Weight = 325, Age = 25, CollegeName = "Western Michigan" },
                new TeamMember { FirstName = "Greg", LastName = "Olsen", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 88, Height = "6-5", Weight = 255, Age = 34, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Curtis", LastName = "Samuel", Position = Constants.Positions[Enums.PositionEnum.Right_Wide_Reciever], JerseyNumber = 10, Height = "5-11", Weight = 195, Age = 23, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Kyle", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 7, Height = "6-3", Weight = 210, Age = 23, CollegeName = "Houston" },
                new TeamMember { FirstName = "Alex", LastName = "Armah", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 40, Height = "6-2", Weight = 255, Age = 25, CollegeName = "West Georgia" },
                new TeamMember { FirstName = "Christian", LastName = "McCaffrey", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 22, Height = "5-11", Weight = 205, Age = 23, CollegeName = "Stanford" },
                // Defense
                new TeamMember { FirstName = "Gerald", LastName = "McCoy", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 93, Height = "6-4", Weight = 300, Age = 31, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Dontari", LastName = "Poe", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 95, Height = "6-3", Weight = 346, Age = 29, CollegeName = "Memphis" },
                new TeamMember { FirstName = "Vernon", LastName = "Butler", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 92, Height = "6-4", Weight = 330, Age = 25, CollegeName = "Louisiana Tech" },
                new TeamMember { FirstName = "Mario", LastName = "Addison", Position = Constants.Positions[Enums.PositionEnum.Left_Outside_Linebacker], JerseyNumber = 97, Height = "6-3", Weight = 260, Age = 32, CollegeName = "Troy" },
                new TeamMember { FirstName = "Shaq", LastName = "Thompson", Position = Constants.Positions[Enums.PositionEnum.Left_Inside_Linebacker], JerseyNumber = 54, Height = "6-0", Weight = 230, Age = 25, CollegeName = "Washington" },
                new TeamMember { FirstName = "Luke", LastName = "Kuechly", Position = Constants.Positions[Enums.PositionEnum.Right_Inside_Linebacker], JerseyNumber = 59, Height = "6-3", Weight = 238, Age = 28, CollegeName = "Boston College" },
                new TeamMember { FirstName = "Bruce", LastName = "Irvin", Position = Constants.Positions[Enums.PositionEnum.Right_Outside_Linebacker], JerseyNumber = 55, Height = "6-3", Weight = 250, Age = 32, CollegeName = "West Virginia" },
                new TeamMember { FirstName = "Donte", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 26, Height = "5-10", Weight = 180, Age = 24, CollegeName = "LSU" },
                new TeamMember { FirstName = "James", LastName = "Bradberry", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 24, Height = "6-1", Weight = 212, Age = 26, CollegeName = "Samford" },
                new TeamMember { FirstName = "Eric", LastName = "Reid", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 25, Height = "6-1", Weight = 215, Age = 27, CollegeName = "LSU" },
                new TeamMember { FirstName = "Tre", LastName = "Boston", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 33, Height = "6-1", Weight = 205, Age = 27, CollegeName = "North Carolina" },
                // Kicker
                new TeamMember { FirstName = "Joey", LastName = "Slye", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "5-11", Weight = 213, Age = 23, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Michael", LastName = "Palardy", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 5, Height = "5-11", Weight = 200, Age = 27, CollegeName = "Tennessee" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Ron", LastName = "Rivera", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Norv", LastName = "Turner", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Eric", LastName = "Washinton", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Chase", LastName = "Blackburn", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetCarolinaPanthersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
