using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class MinnesotaVikings_NFC_North
    {
        private const string _teamName = "Minnesota Vikings";
        private const string _city = "Minneapolis";
        private const string _state = "Minnesota";
        private const string _stadiumName = "U. S. Bank Statium";
        public static TeamInformation GetMinnesotaVikingsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_North],
                Colors = new List<string> { "White", "Gold", "Purple" },
                SeasonSchedule = GetMinnesotaVikingsSchedule(year),
                Players = GetMinnesotaVikingsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 8,
                    TotalLosses = 3,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetMinnesotaVikingsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Stefon", LastName = "Diggs", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 14, Height = "6-0", Weight = 191, Age = 26, CollegeName = "Maryland" },
                new TeamMember { FirstName = "Riley", LastName = "Reiff", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 71, Height = "6-6", Weight = 305, Age = 30, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Pat", LastName = "Elflein", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 65, Height = "6-3", Weight = 303, Age = 25, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Garrett", LastName = "Bradbury", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 56, Height = "6-3", Weight = 305, Age = 24, CollegeName = "North Carolina State" },
                new TeamMember { FirstName = "Josh", LastName = "Kline", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 64, Height = "6-3", Weight = 300, Age = 29, CollegeName = "Kent State" },
                new TeamMember { FirstName = "Brian", LastName = "O'Neill", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 75, Height = "6-7", Weight = 297, Age = 24, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Kyle", LastName = "Rudolph", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 82, Height = "6-6", Weight = 265, Age = 30, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Adam", LastName = "Thielen", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 19, Height = "6-2", Weight = 200, Age = 29, CollegeName = "Minnesota State" },
                new TeamMember { FirstName = "Kirk", LastName = "Cousins", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 8, Height = "6-3", Weight = 202, Age = 31, CollegeName = "Michigan State" },
                new TeamMember { FirstName = "Dalvin", LastName = "Cook", Position = Constants.Positions[Enums.PositionEnum.Half_Back], JerseyNumber = 33, Height = "5-10", Weight = 210, Age = 24, CollegeName = "Florida State" },
                new TeamMember { FirstName = "C.J.", LastName = "Ham", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 30, Height = "5-11", Weight = 235, Age = 26, CollegeName = "Augustana (S.D.)" },
                // Defense
                new TeamMember { FirstName = "Daniel", LastName = "Hunter", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 99, Height = "6-5", Weight = 252, Age = 25, CollegeName = "LSU" },
                new TeamMember { FirstName = "Linval", LastName = "Joseph", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 98, Height = "6-4", Weight = 329, Age = 31, CollegeName = "East Carolina" },
                new TeamMember { FirstName = "Shamar", LastName = "Stephen", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 93, Height = "6-5", Weight = 309, Age = 28, CollegeName = "Connecticut" },
                new TeamMember { FirstName = "Everson", LastName = "Griffen", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 97, Height = "6-3", Weight = 273, Age = 31, CollegeName = "USC" },
                new TeamMember { FirstName = "Ben", LastName = "Gedeon", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 42, Height = "6-2", Weight = 244, Age = 25, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Eric", LastName = "Kendricks", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 54, Height = "6-0", Weight = 232, Age = 27, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Anthony", LastName = "Barr", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 55, Height = "6-5", Weight = 255, Age = 27, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Trae", LastName = "Waynes", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 26, Height = "6-0", Weight = 190, Age = 27, CollegeName = "Michigan State" },
                new TeamMember { FirstName = "Xavier", LastName = "Rhodes", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 29, Height = "6-1", Weight = 218, Age = 29, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Harrison", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 22, Height = "6-2", Weight = 214, Age = 30, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Anthony", LastName = "Harris", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 41, Height = "6-1", Weight = 202, Age = 28, CollegeName = "Virgina" },
                // Kicker
                new TeamMember { FirstName = "Dan", LastName = "Bailey", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 5, Height = "6-0", Weight = 190, Age = 31, CollegeName = "Oklahoma State" },
                new TeamMember { FirstName = "Austin", LastName = "Cutting", Position = Constants.Positions[Enums.PositionEnum.Long_Snapper], JerseyNumber = 58, Height = "6-3", Weight = 245, Age = 23, CollegeName = "Air Force" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Mike", LastName = "Zimmer", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Kevin", LastName = "Stefanski", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "George", LastName = "Edwards", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Marwan", LastName = "Maalouf", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetMinnesotaVikingsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
