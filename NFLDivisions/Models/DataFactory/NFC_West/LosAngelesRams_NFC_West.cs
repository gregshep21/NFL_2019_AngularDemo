using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public static class LosAngelesRams_NFC_West
    {
        private const string _teamName = "Los Angeles Rams";
        private const string _city = "Los Angeles";
        private const string _state = "California";
        private const string _stadiumName = "LA Memorial Coliseum";

        public static TeamInformation GetLosAngelesRamsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.NFC_West],
                Colors = new List<string> { "White", "Gold", "Blue" },
                SeasonSchedule = GetLosAngelesRamsSchedule(year),
                Players = GetLosAngelesRamsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 3,
                    TotalWins = 6,
                    TotalLosses = 4,
                    Ties = 0
                }
            };
        }

        private static List<TeamMember> GetLosAngelesRamsRoster(int year)
        {
            return new List<TeamMember>
            {
                // Offense
                new TeamMember { FirstName = "Cooper", LastName = "Kupp", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 18, Height = "6-2", Weight = 208, Age = 26, CollegeName = "Eastern Washington" },
                new TeamMember { FirstName = "Tyler", LastName = "Higbee", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 89, Height = "6-6", Weight = 255, Age = 26, CollegeName = "Western Kentucky" },
                new TeamMember { FirstName = "Andrew", LastName = "Whitworth", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 77, Height = "6-7", Weight = 330, Age = 37, CollegeName = "LSU" },
                new TeamMember { FirstName = "Austin", LastName = "Corbett", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 63, Height = "6-4", Weight = 306, Age = 24, CollegeName = "Nevada" },
                new TeamMember { FirstName = "Austin", LastName = "Blythe", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 66, Height = "6-3", Weight = 298, Age = 27, CollegeName = "Iowa" },
                new TeamMember { FirstName = "David", LastName = "Edwards", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 73, Height = "6-6", Weight = 308, Age = 22, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Rob", LastName = "Havenstein", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 79, Height = "6-8", Weight = 330, Age = 27, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Brandin", LastName = "Cooks", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 12, Height = "5-10", Weight = 183, Age = 26, CollegeName = "Oregon State" },
                new TeamMember { FirstName = "Robert", LastName = "Woods", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 17, Height = "6-0", Weight = 195, Age = 27, CollegeName = "USC" },
                new TeamMember { FirstName = "Jared", LastName = "Goff", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 16, Height = "6-4", Weight = 222, Age = 25, CollegeName = "California" },
                new TeamMember { FirstName = "Todd", LastName = "Gurley II", Position = Constants.Positions[Enums.PositionEnum.Half_Back], JerseyNumber = 30, Height = "6-1", Weight = 224, Age = 25, CollegeName = "Georgia" },
                // Defense
                new TeamMember { FirstName = "Michael", LastName = "Brockers", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 90, Height = "6-5", Weight = 305, Age = 28, CollegeName = "LSU" },
                new TeamMember { FirstName = "Sebastion", LastName = "Joseph-Day", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 69, Height = "6-4", Weight = 310, Age = 24, CollegeName = "Rutgers" },
                new TeamMember { FirstName = "Aaron", LastName = "Donald", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 99, Height = "6-1", Weight = 280, Age = 28, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Dante", LastName = "Fowler Jr.", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 56, Height = "6-3", Weight = 255, Age = 25, CollegeName = "Florida" },
                new TeamMember { FirstName = "Clay", LastName = "Matthews", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 52, Height = "6-3", Weight = 255, Age = 33, CollegeName = "USC" },
                new TeamMember { FirstName = "Cory", LastName = "Littleton", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 58, Height = "6-3", Weight = 228, Age = 26, CollegeName = "Washington" },
                new TeamMember { FirstName = "Troy", LastName = "Reeder", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 51, Height = "6-3", Weight = 245, Age = 25, CollegeName = "Delaware" },
                new TeamMember { FirstName = "Troy", LastName = "Hill", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 22, Height = "5-11", Weight = 183, Age = 28, CollegeName = "Oregon" },
                new TeamMember { FirstName = "Jalen", LastName = "Ramsey", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 20, Height = "6-1", Weight = 208, Age = 25, CollegeName = "Florida State" },
                new TeamMember { FirstName = "Taylor", LastName = "Rapp", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 24, Height = "6-0", Weight = 208, Age = 21, CollegeName = "Washington" },
                new TeamMember { FirstName = "Eric", LastName = "Weddie", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 32, Height = "5-11", Weight = 195, Age = 34, CollegeName = "Utah" },
                // Kicker
                new TeamMember { FirstName = "Greg", LastName = "Zuerlein", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "6-0", Weight = 191, Age = 31, CollegeName = "Missouri Western State" },
                new TeamMember { FirstName = "Johnny", LastName = "Hekker", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 6, Height = "6-5", Weight = 241, Age = 29, CollegeName = "Oregon State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Sean", LastName = "McVay", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Aaron", LastName = "Kromer", Title = Constants.Positions[Enums.PositionEnum.Run_Game_Coordinator] },
                new Coach { FirstName = "Shane", LastName = "Waldron", Title = Constants.Positions[Enums.PositionEnum.Pass_Game_Coordinator] },
                new Coach { FirstName = "Wade", LastName = "Phillips", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "John", LastName = "Fassel", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetLosAngelesRamsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
