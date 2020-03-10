using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class ChicagoBears_NFC_North
    {
        private const string _teamName = "Chicago Bears";
        private const string _city = "Chicago";
        private const string _state = "Illinois";
        private const string _stadiumName = "Soldier Field";
        public static TeamInformation GetChicagoBearsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_North],
                Colors = new List<string> { "White", "Burnt Orange", "Navy Blue" },
                SeasonSchedule = GetChicagoBearsSchedule(year),
                Players = GetChicagoBearsRoster(year),
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

        private static List<TeamMember> GetChicagoBearsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Taylor", LastName = "Gabriel", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 18, Height = "5-7", Weight = 168, Age = 28, CollegeName = "Abilene Christian" },
                new TeamMember { FirstName = "Adam", LastName = "Shaheen", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 87, Height = "6-6", Weight = 257, Age = 25, CollegeName = "Ashland" },
                new TeamMember { FirstName = "Bobby", LastName = "Massie", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 70, Height = "6-6", Weight = 325, Age = 30, CollegeName = "Mississippi" },
                new TeamMember { FirstName = "Rashaad", LastName = "Coward", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 69, Height = "6-5", Weight = 326, Age = 25, CollegeName = "Old Dominion" },
                new TeamMember { FirstName = "Cody", LastName = "Whitehair", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 65, Height = "6-3", Weight = 309, Age = 27, CollegeName = "Kansas State" },
                new TeamMember { FirstName = "James", LastName = "Daniels", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 4, Height = "6-0", Weight = 229, Age = 33, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Charles", LastName = "Leno Jr.", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 72, Height = "6-3", Weight = 307, Age = 28, CollegeName = "Boise State" },
                new TeamMember { FirstName = "Mitchell", LastName = "Trubisky", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 10, Height = "6-2", Weight = 215, Age = 25, CollegeName = "North Carolina" },
                new TeamMember { FirstName = "Tarik", LastName = "Cohen", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 29, Height = "5-6", Weight = 191, Age = 24, CollegeName = "North Carolina A&T" },
                new TeamMember { FirstName = "Allen", LastName = "Robinson II", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 12, Height = "6-2", Weight = 220, Age = 26, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Anthony", LastName = "Miller", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 17, Height = "5-11", Weight = 199, Age = 25, CollegeName = "Memphis" },
                // Defense
                new TeamMember { FirstName = "Roy", LastName = "Robertson-Harris", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 95, Height = "6-5", Weight = 292, Age = 26, CollegeName = "Texas-El-Paso" },
                new TeamMember { FirstName = "Eddie", LastName = "Goldman", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 91, Height = "6-3", Weight = 318, Age = 25, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Bilal", LastName = "Nichols", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 98, Height = "6-3", Weight = 313, Age = 23, CollegeName = "Delaware" },
                new TeamMember { FirstName = "Khalil", LastName = "Mack", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 52, Height = "6-3", Weight = 269, Age = 28, CollegeName = "Buffalo" },
                new TeamMember { FirstName = "Danny", LastName = "Trevathan", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 59, Height = "6-0", Weight = 237, Age = 29, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Roquan", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 58, Height = "6-0", Weight = 230, Age = 22, CollegeName = "Smith" },
                new TeamMember { FirstName = "Leonard", LastName = "Floyd", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 94, Height = "6-5", Weight = 240, Age = 27, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Kyle", LastName = "Fuller", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "5-11", Weight = 194, Age = 27, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Ha Ha", LastName = "Clinton-Dix", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 21, Height = "6-1", Weight = 211, Age = 26, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Eddie", LastName = "Jackson", Position = Constants.Positions[Enums.PositionEnum.Safety], JerseyNumber = 39, Height = "6-0", Weight = 204, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Prince", LastName = "Amukamara", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 20, Height = "6-0", Weight = 206, Age = 30, CollegeName = "Nebraska" },
                // Kicker
                new TeamMember { FirstName = "Eddie", LastName = "Pineiro", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 15, Height = "5-11", Weight = 177, Age = 24, CollegeName = "Florida" },
                new TeamMember { FirstName = "Pat", LastName = "O'Donnell", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 16, Height = "6-4", Weight = 212, Age = 28, CollegeName = "Miami (Fla.)" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Matt", LastName = "Nagy", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Mark", LastName = "Helfrich", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Chuck", LastName = "Pagano", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Chris", LastName = "Tabor", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetChicagoBearsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
