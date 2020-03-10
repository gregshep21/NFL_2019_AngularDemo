using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class SanFrancisco49ers_NFC_West
    {
        private const string _teamName = "San Francisco 49ers";
        private const string _city = "San Francisco";
        private const string _state = "California";
        private const string _stadiumName = "Levi Statium";

        public static TeamInformation GetSanFrancisco49ersInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_West],
                Colors = new List<string> { "Scarlet", "Gold" },
                SeasonSchedule = GetSanFrancisco49ersSchedule(year),
                Players = GetSanFrancisco49ersRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 1,
                    TotalWins = 9,
                    TotalLosses = 1,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetSanFrancisco49ersRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Deebo", LastName = "Samuel", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 19, Height = "5-11", Weight = 214, Age = 23, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Joe", LastName = "Staley", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 74, Height = "6-5", Weight = 295, Age = 35, CollegeName = "Central Michigan" },
                new TeamMember { FirstName = "Laken", LastName = "Tomlinson", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 75, Height = "6-3", Weight = 312, Age = 27, CollegeName = "Duke" },
                new TeamMember { FirstName = "Weston", LastName = "Richburg", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 58, Height = "6-4", Weight = 290, Age = 28, CollegeName = "Colorado State" },
                new TeamMember { FirstName = "Mike", LastName = "Person", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 68, Height = "6-4", Weight = 300, Age = 31, CollegeName = "Montana State" },
                new TeamMember { FirstName = "Mike", LastName = "McGlinchey", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 69, Height = "6-8", Weight = 315, Age = 25, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "George", LastName = "Kittle", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 85, Height = "6-4", Weight = 250, Age = 26, CollegeName = "Iowa" },
                new TeamMember { FirstName = "Emmanuel", LastName = "Sanders", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 17, Height = "5-11", Weight = 180, Age = 32, CollegeName = "Souther Methodist" },
                new TeamMember { FirstName = "Matt", LastName = "Breida", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 22, Height = "5-10", Weight = 190, Age = 24, CollegeName = "Georgia Southern" },
                new TeamMember { FirstName = "Kyle", LastName = "Juszczyk", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 44, Height = "6-1", Weight = 240, Age = 28, CollegeName = "Harvard" },
                new TeamMember { FirstName = "Jimmy", LastName = "Garoppolo", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 10, Height = "6-2", Weight = 225, Age = 28, CollegeName = "Eastern Illinois" },
                // Defense
                new TeamMember { FirstName = "Dee", LastName = "Ford", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 55, Height = "6-2", Weight = 252, Age = 28, CollegeName = "Auburn" },
                new TeamMember { FirstName = "D.J.", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_Tackle], JerseyNumber = 93, Height = "6-0", Weight = 321, Age = 24, CollegeName = "Mississippi" },
                new TeamMember { FirstName = "DeForest", LastName = "Buckner", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_Tackle], JerseyNumber = 99, Height = "6-7", Weight = 300, Age = 25, CollegeName = "Oregon" },
                new TeamMember { FirstName = "Arik", LastName = "Armstead", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 91, Height = "6-7", Weight = 292, Age = 26, CollegeName = "Oregon" },
                new TeamMember { FirstName = "Azeez", LastName = "Al-Shaair", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 51, Height = "6-2", Weight = 228, Age = 22, CollegeName = "Florida Atlantic" },
                new TeamMember { FirstName = "Fred", LastName = "Warner", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 54, Height = "6-3", Weight = 236, Age = 23, CollegeName = "BYU" },
                new TeamMember { FirstName = "Dre", LastName = "Greenlaw", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 57, Height = "6-0", Weight = 227, Age = 22, CollegeName = "Arkansas" },
                new TeamMember { FirstName = "Richard", LastName = "Sherman", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 25, Height = "6-3", Weight = 195, Age = 31, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Ahkello", LastName = "Witherspoon", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 23, Height = "6-2", Weight = 195, Age = 24, CollegeName = "Colorado" },
                new TeamMember { FirstName = "K'Waun", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.NickelBack], JerseyNumber = 24, Height = "5-9", Weight = 185, Age = 28, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Jimmie", LastName = "Ward", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 20, Height = "5-11", Weight = 193, Age = 28, CollegeName = "Northern Illinois" },
                new TeamMember { FirstName = "Jaquiski", LastName = "Tartt", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 29, Height = "6-1", Weight = 215, Age = 27, CollegeName = "Samford" },
                // Kicker
                new TeamMember { FirstName = "Robble", LastName = "Gould", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 9, Height = "6-0", Weight = 190, Age = 36, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Mitch", LastName = "Wishnowsky", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-2", Weight = 220, Age = 27, CollegeName = "Utah" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Kyle", LastName = "Shanahan", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Jon", LastName = "Embree", Title = Constants.Positions[Enums.PositionEnum.Assistant_Coach] },
                new Coach { FirstName = "Robert", LastName = "Saleh", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Richard", LastName = "Hightower", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetSanFrancisco49ersSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
