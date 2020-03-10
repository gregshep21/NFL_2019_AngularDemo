using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class NewYorkGiants_NFC_East
    {
        private const string _teamName = "New York Giants";
        private const string _city = "New York";
        private const string _state = "New York";
        private const string _stadiumName = "MetLife Stadium";


        public static TeamInformation GetNewYorkGiantsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_East],
                Colors = new List<string> { "Blue", "White", "Grey", "Red", "Dark Blue" },
                SeasonSchedule = GetNewYorkGiantsSchedule(year),
                Players = GetNewYorkGiantsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    Ranking = 3,
                    TotalWins = 2,
                    TotalLosses = 7,
                    Ties = 0,
                    SeasonGameCount = 20
                }
            };
        }

        private static List<TeamMember> GetNewYorkGiantsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Golden", LastName = "Tate", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 15, Height = "5-10", Weight = 197, Age = 31, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Nate", LastName = "Solder", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 76, Height = "6-8", Weight = 325, Age = 31, CollegeName = "Colorado" },
                new TeamMember { FirstName = "Will", LastName = "Hernandez", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 71, Height = "6-2", Weight = 327, Age = 24, CollegeName = "UTEP" },
                new TeamMember { FirstName = "Jon", LastName = "Halaplo", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 75, Height = "6-3", Weight = 315, Age = 28, CollegeName = "Florida" },
                new TeamMember { FirstName = "Kevin", LastName = "Zeitler", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 70, Height = "6-4", Weight = 315, Age = 29, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Mike", LastName = "Remmers", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 74, Height = "6-5", Weight = 310, Age = 30, CollegeName = "Oregon State" },
                new TeamMember { FirstName = "Evan", LastName = "Engram", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 88, Height = "6-3", Weight = 240, Age = 25, CollegeName = "Mississippi" },
                new TeamMember { FirstName = "Rhett", LastName = "Ellison", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 85, Height = "6-5", Weight = 255, Age = 31, CollegeName = "USC" },
                new TeamMember { FirstName = "Sterling", LastName = "Shepard", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 87, Height = "5-10", Weight = 201, Age = 26, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Daniel", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 8, Height = "6-5", Weight = 221, Age = 22, CollegeName = "Duke" },
                new TeamMember { FirstName = "Saquon", LastName = "Barkley", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 26, Height = "5-11", Weight = 233, Age = 22, CollegeName = "Penn State" },
                // Defense
                new TeamMember { FirstName = "B.J.", LastName = "Hill", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 95, Height = "6-3", Weight = 311, Age = 24, CollegeName = "UTEP" },
                new TeamMember { FirstName = "Dalvin", LastName = "Tomlinson", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 94, Height = "6-3", Weight = 318, Age = 25, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Dexter", LastName = "Lawrence", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 97, Height = "6-4", Weight = 32, Age = 22, CollegeName = "Clemson" },
                new TeamMember { FirstName = "Marcus", LastName = "Golden", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 44, Height = "6-3", Weight = 260, Age = 28, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Alec", LastName = "Ogletree", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 47, Height = "6-2", Weight = 235, Age = 28, CollegeName = "Georgia" },
                new TeamMember { FirstName = "David", LastName = "Mayo", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 55, Height = "6-2", Weight = 240, Age = 26, CollegeName = "Texas State" },
                new TeamMember { FirstName = "Lorenzo", LastName = "Carter", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 59, Height = "6-5", Weight = 250, Age = 23, CollegeName = "Georgia" },
                new TeamMember { FirstName = "DeAndre", LastName = "Baker", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 27, Height = "5-11", Weight = 180, Age = 22, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Janoris", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 20, Height = "5-10", Weight = 190, Age = 31, CollegeName = "North Alabama" },
                new TeamMember { FirstName = "Jabrill", LastName = "Peppers", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 21, Height = "5-11", Weight = 213, Age = 24, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Antoine", LastName = "Bethea", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 41, Height = "5-11", Weight = 206, Age = 35, CollegeName = "Howard" },
                // Kicker
                new TeamMember { FirstName = "Aldrick", LastName = "Rosas", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 2, Height = "6-3", Weight = 221, Age = 24, CollegeName = "Southern Oregon" },
                new TeamMember { FirstName = "Riley", LastName = "Dixon", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 9, Height = "6-4", Weight = 221, Age = 26, CollegeName = "Syracuse" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Pat", LastName = "Shurmur", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Mike", LastName = "Shula", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "James", LastName = "Bettcher", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Thomas", LastName = "McGaughey", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }


        private static List<Schedule> GetNewYorkGiantsSchedule(int year)
        {
            return new List<Schedule>
            {
                new Schedule
                {
                    // Dallas Cowboys
                    GameDayDate = new DateTime(2019, 09, 08),
                    GameLocationCity = "San Antonio",
                    GameLocationState = "TX",
                    StatiumName = "AT&T Statuim",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Buffalo Bills
                    GameDayDate = new DateTime(2019, 09, 15),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Tampa Bay Buccaneers
                    GameDayDate = new DateTime(2019, 09, 22),
                    GameLocationCity = "Tampa Bay",
                    GameLocationState = "FL",
                    StatiumName = "Raymond James Statuim",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Win],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Washington Redskins
                    GameDayDate = new DateTime(2019, 09, 29),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Win],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Minnasota Vikings
                    GameDayDate = new DateTime(2019, 10, 06),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // New England Patriots
                    GameDayDate = new DateTime(2019, 10, 10),
                    GameLocationCity = "New England",
                    GameLocationState = "NE",
                    StatiumName = "Gillette Statuim",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Arizona Cardinals
                    GameDayDate = new DateTime(2019, 10, 20),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Detroit Lions
                    GameDayDate = new DateTime(2019, 10, 27),
                    GameLocationCity = "Detroit",
                    GameLocationState = "MI",
                    StatiumName = "Ford Field",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Dallas Cowboys
                    GameDayDate = new DateTime(2019, 11, 04),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // New York Jets
                    GameDayDate = new DateTime(2019, 11, 10),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statium",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.Loss],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Bye Week
                    GameDayDate = new DateTime(2019, 11, 17),
                    GameLocationCity = "",
                    GameLocationState = "",
                    StatiumName = "",
                    IsHomeGame = true,
                    IsOnByeWeek = true,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.ByeWeek],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Chicago Bears
                    GameDayDate = new DateTime(2019, 11, 24),
                    GameLocationCity = "Chicago",
                    GameLocationState = "IL",
                    StatiumName = "Soldier Field",
                    IsHomeGame = false,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Green Bay Packers
                    GameDayDate = new DateTime(2019, 12, 01),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Philadelphia Eagles
                    GameDayDate = new DateTime(2019, 12, 09),
                    GameLocationCity = "Philadelphia",
                    GameLocationState = "NY",
                    StatiumName = "Lincoln Financial Field",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Miami Dolphins
                    GameDayDate = new DateTime(2019, 12, 15),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Washington Redskins
                    GameDayDate = new DateTime(2019, 12, 22),
                    GameLocationCity = "Washington",
                    GameLocationState = "WA",
                    StatiumName = "FedEx Field",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                },
                new Schedule
                {
                    // Philadelphia Eagles
                    GameDayDate = new DateTime(2019, 12, 29),
                    GameLocationCity = "New York",
                    GameLocationState = "NY",
                    StatiumName = "MetLife Statuim",
                    IsHomeGame = true,
                    IsOnByeWeek = false,
                    GameResult = Constants.GameResult[Enums.GameResultEnum.TBD],
                    OpposingTeamInformation = new TeamInformation()
                }
            };
        }
    }
}
