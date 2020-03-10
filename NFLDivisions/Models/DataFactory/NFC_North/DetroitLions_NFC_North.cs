using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class DetroitLions_NFC_North
    {
        private const string _teamName = "Detroit Lions";
        private const string _city = "Detroit";
        private const string _state = "Michigan";
        private const string _stadiumName = "Ford Field";
        public static TeamInformation GetDetroitLionsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_North],
                Colors = new List<string> { "Black", "Silver", "White", "Honolulu Blue" },
                SeasonSchedule = GetDetroitLionsSchedule(year),
                Players = GetDetroitLionsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 3,
                    TotalLosses = 6,
                    Ties = 1
                }
            };
        }

        public static List<TeamMember> GetDetroitLionsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Kenny", LastName = "Golladay", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 19, Height = "6-4", Weight = 214, Age = 26, CollegeName = "Northern Illinois" },
                new TeamMember { FirstName = "Danny", LastName = "Amendola", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 80, Height = "5-11", Weight = 185, Age = 34, CollegeName = "Texas Tech" },
                new TeamMember { FirstName = "Taylor", LastName = "Decker", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 68, Height = "6-7", Weight = 318, Age = 26, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Joe", LastName = "Dahl", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 66, Height = "6-4", Weight = 310, Age = 26, CollegeName = "Washington State" },
                new TeamMember { FirstName = "Frank", LastName = "Ragnow", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 77, Height = "6-5", Weight = 311, Age = 23, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Graham", LastName = "Glasgow", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 60, Height = "6-6", Weight = 310, Age = 27, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Rick", LastName = "Wagner", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-6", Weight = 313, Age = 30, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Jesse", LastName = "James", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 83, Height = "6-7", Weight = 250, Age = 25, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Marvin", LastName = "Jones Jr.", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 11, Height = "6-2", Weight = 199, Age = 29, CollegeName = "California" },
                new TeamMember { FirstName = "Matthew", LastName = "Stafford", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 9, Height = "6-3", Weight = 220, Age = 31, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Ty", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 31, Height = "5-10", Weight = 210, Age = 22, CollegeName = "Maryland" },
                // Defense
                new TeamMember { FirstName = "Trey", LastName = "Flowers", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 90, Height = "6-2", Weight = 265, Age = 26, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Damon", LastName = "Harrison Sr.", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 98, Height = "6-3", Weight = 350, Age = 31, CollegeName = "William Penn" },
                new TeamMember { FirstName = "A'Shawn", LastName = "Robinson", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 91, Height = "6-4", Weight = 330, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Romeo", LastName = "Okwara", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 95, Height = "6-4", Weight = 263, Age = 24, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Devon", LastName = "Kennard", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 42, Height = "6-3", Weight = 256, Age = 28, CollegeName = "USC" },
                new TeamMember { FirstName = "Jarrad", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 40, Height = "6-1", Weight = 245, Age = 25, CollegeName = "Florida" },
                new TeamMember { FirstName = "Christian", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 52, Height = "6-3", Weight = 250, Age = 28, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Darius", LastName = "Slay", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "6-0", Weight = 190, Age = 28, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Justin", LastName = "Coleman", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 27, Height = "5-11", Weight = 190, Age = 26, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Tavon", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 32, Height = "6-0", Weight = 208, Age = 29, CollegeName = "Illinois" },
                new TeamMember { FirstName = "Tracy", LastName = "Walker", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 21, Height = "6-1", Weight = 210, Age = 24, CollegeName = "Louisiana-Lafayette" },
                // Kicker
                new TeamMember { FirstName = "Matt", LastName = "Prater", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 5, Height = "5-10", Weight = 201, Age = 35, CollegeName = "Central Florida" },
                new TeamMember { FirstName = "Sam", LastName = "Martin", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-1", Weight = 211, Age = 29, CollegeName = "Appalacian State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Matt", LastName = "Patricia", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Darrell", LastName = "Bevell", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Paul", LastName = "Pasqualoni", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "John", LastName = "Bonamego", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetDetroitLionsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
