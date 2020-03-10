using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class NewOrleansSaints_NFC_South
    {
        private const string _teamName = "New Orleans Saints";
        private const string _city = "New Orleans";
        private const string _state = "Louisanna";
        private const string _stadiumName = "Mercedes-Benz Superdome";

        public static TeamInformation GetNewOrleansSaintsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_South],
                Colors = new List<string> { "Black", "Old Gold", "White" },
                SeasonSchedule = GetNewOrleansSaintsSchedule(year),
                Players = GetNewOrleansSaintsRoster(year),
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

        private static List<TeamMember> GetNewOrleansSaintsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Micheal", LastName = "Thomas", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 13, Height = "6-3", Weight = 212, Age = 26, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Terron", LastName = "Armstead", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 72, Height = "6-5", Weight = 304, Age = 28, CollegeName = "Arkansas-Pine Bluff" },
                new TeamMember { FirstName = "Andrus", LastName = "Peat", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 75, Height = "6-7", Weight = 316, Age = 26, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Erik", LastName = "McCoy", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 78, Height = "6-4", Weight = 314, Age = 22, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Larry", LastName = "Warford", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 67, Height = "6-3", Weight =317 , Age = 28, CollegeName = "Kentucky" },
                new TeamMember { FirstName = "Ryan", LastName = "Ramczyk", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 71, Height = "6-6", Weight = 314, Age = 25, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Jared", LastName = "Cook", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 87, Height = "6-5", Weight = 254, Age = 32, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Ted", LastName = "Ginn Jr", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 19, Height = "5-11", Weight = 180, Age = 34, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Drew", LastName = "Brees", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 9, Height = "6-0", Weight = 209, Age = 40, CollegeName = "Purdue" },
                new TeamMember { FirstName = "Alvin", LastName = "Kamara", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 41, Height = "5-10", Weight = 215, Age = 24, CollegeName = "Tennessee" },
                new TeamMember { FirstName = "Zach", LastName = "Line", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 42, Height = "6-1", Weight = 233, Age = 29, CollegeName = "Southern Methodist" },
                // Defense
                new TeamMember { FirstName = "Marcus", LastName = "Davenport", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 92, Height = "6-6", Weight = 265, Age = 23, CollegeName = "Texas-San Antonio" },
                new TeamMember { FirstName = "Malcolm", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 90, Height = "6-2", Weight = 320, Age = 25, CollegeName = "Texas" },
                new TeamMember { FirstName = "Sheldon", LastName = "Rankins", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 98, Height = "6-2", Weight = 305, Age = 25, CollegeName = "Louisville" },
                new TeamMember { FirstName = "Cameron", LastName = "Jordan", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 94, Height = "6-4", Weight = 287, Age = 30, CollegeName = "California" },
                new TeamMember { FirstName = "Demario", LastName = "Davis", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 56, Height = "6-2", Weight = 248, Age = 30, CollegeName = "Arkansas State" },
                new TeamMember { FirstName = "Kiko", LastName = "Alonso", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 54, Height = "6-3", Weight = 239, Age = 29, CollegeName = "Oregon" },
                new TeamMember { FirstName = "A.J.", LastName = "Klein", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 53, Height = "6-1", Weight = 240, Age = 28, CollegeName = "Iowa State" },
                new TeamMember { FirstName = "Eli", LastName = "Apple", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 25, Height = "6-1", Weight = 203, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Vonn", LastName = "Bell", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 24, Height = "5-11", Weight = 205, Age = 24, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Marcus", LastName = "Williams", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 43, Height = "6-1", Weight = 195, Age = 23, CollegeName = "Utah" },
                new TeamMember { FirstName = "Marshon", LastName = "Lattimore", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 23, Height = "6-0", Weight = 192, Age = 23, CollegeName = "Ohio State" },
                // Kicker
                new TeamMember { FirstName = "Will", LastName = "Lutz", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 3, Height = "5-11", Weight = 184, Age = 25, CollegeName = "Georgia State" },
                new TeamMember { FirstName = "Thomas", LastName = "Morstead", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-4", Weight = 235, Age = 33, CollegeName = "Souther Methodist" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Sean", LastName = "Payton", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Pete", LastName = "Carmichael", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Dennis", LastName = "Allen", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Darren", LastName = "Rizzi", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetNewOrleansSaintsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
