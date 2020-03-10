using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class GreenBayPackers_NFC_North
    {
        private const string _teamName = "Green Bay Packers";
        private const string _city = "Green Bay";
        private const string _state = "Wisconsin";
        private const string _stadiumName = "Lambeau Field";
        public static TeamInformation GetGreenBayPackersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_North],
                Colors = new List<string> { "White", "Dark Green", "Gold" },
                SeasonSchedule = GetGreenBayPackersSchedule(year),
                Players = GetGreenBayPackersRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 8,
                    TotalLosses = 2,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetGreenBayPackersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Davante", LastName = "Adams", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 17, Height = "6-1", Weight = 215, Age = 26, CollegeName = "Fresno State" },
                new TeamMember { FirstName = "David", LastName = "Bakhtiari", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 69, Height = "6-4", Weight = 310, Age = 28, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Elgton", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 74, Height = "6-5", Weight = 311, Age = 23, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Corey", LastName = "Linsley", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 63, Height = "6-3", Weight = 301, Age = 28, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Bill", LastName = "Turner", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 77, Height = "6-5", Weight = 310, Age = 28, CollegeName = "North Dakota State" },
                new TeamMember { FirstName = "Bryan", LastName = "Bulaga", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 75, Height = "6-5", Weight = 314, Age = 30, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Jimmy", LastName = "Graham", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 80, Height = "6-7", Weight = 265, Age = 33, CollegeName = "Miami" },
                new TeamMember { FirstName = "Marquez", LastName = "Valdes-Scantling", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 83, Height = "6-4", Weight = 206, Age = 25, CollegeName = "South Florida" },
                new TeamMember { FirstName = "Aaron", LastName = "Rodgers", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 12, Height = "6-2", Weight = 225, Age = 35, CollegeName = "California" },
                new TeamMember { FirstName = "Aaron", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 33, Height = "5-9", Weight = 208, Age = 24, CollegeName = "Texas-El Paso" },
                new TeamMember { FirstName = "Danny", LastName = "Vitale", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 45, Height = "6-0", Weight = 239, Age = 26, CollegeName = "Northwestern" },
                // Defense
                new TeamMember { FirstName = "Dean", LastName = "Lowry", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 94, Height = "6-6", Weight = 296, Age = 25, CollegeName = "Northwestern" },
                new TeamMember { FirstName = "Kenny", LastName = "Clark", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 97, Height = "6-3", Weight = 314, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Tyler", LastName = "Lancaster", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 95, Height = "6-3", Weight = 313, Age = 25, CollegeName = "Northwestern" },
                new TeamMember { FirstName = "Preston", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 91, Height = "6-5", Weight = 265, Age = 27, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Blake", LastName = "Martinez", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 50, Height = "6-2", Weight = 237, Age = 25, CollegeName = "Stanford" },
                new TeamMember { FirstName = "B.J.", LastName = "Goodson", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 93, Height = "6-1", Weight = 242, Age = 26, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Za'Darius", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 55, Height = "6-4", Weight = 272, Age = 27, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Jaire", LastName = "Alexander", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "5-10", Weight = 196, Age = 22, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Kevin", LastName = "King", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 20, Height = "6-3", Weight = 200, Age = 24, CollegeName = "Washington" },
                new TeamMember { FirstName = "Adrian", LastName = "Amos", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 31, Height = "6-0", Weight = 214, Age = 26, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Darnell", LastName = "Savage", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 26, Height = "5-11", Weight = 198, Age = 22, CollegeName = "Maryland" },
                // Kicker
                new TeamMember { FirstName = "Mason", LastName = "Crosby", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 2, Height = "6-1", Weight = 207, Age = 35, CollegeName = "Colorado" },
                new TeamMember { FirstName = "JK", LastName = "Scott", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-6", Weight = 208, Age = 24, CollegeName = "Alabama" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Matt", LastName = "LaFleur", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Nathaniel", LastName = "Hackett", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Mike", LastName = "Pettine", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Shawn", LastName = "Mennenga", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetGreenBayPackersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
