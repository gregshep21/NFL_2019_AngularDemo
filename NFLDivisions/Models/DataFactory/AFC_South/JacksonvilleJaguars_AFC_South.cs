
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class JacksonvilleJaguars_AFC_South
    {
        private const string _teamName = "Jacksonville Jaguars";
        private const string _city = "Jacksonville";
        private const string _state = "Florida";
        private const string _stadiumName = "TIAA Bank Field";

        public static TeamInformation GetJacksonvilleJaguarsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_South],
                Colors = new List<string> { "Black", "Gold", "Teal" },
                SeasonSchedule = GetJacksonvilleJaguarsSchedule(year),
                Players = GetJacksonvilleJaguarsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 4,
                    TotalWins = 4,
                    TotalLosses = 6,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetJacksonvilleJaguarsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Chris", LastName = "Conley", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 18, Height = "6-3", Weight = 205, Age = 27, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Cam", LastName = "Robinson", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 74, Height = "6-6", Weight = 320, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Andrew", LastName = "Norwell", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 68, Height = "6-6", Weight = 325, Age = 28, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Brandon", LastName = "Linder", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 65, Height = "6-6", Weight = 315, Age = 27, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "A.J.", LastName = "Cann", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 60, Height = "6-3", Weight = 315, Age = 28, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Jawaan", LastName = "Taylor", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 75, Height = "6-5", Weight = 312, Age = 22, CollegeName = "Florida" },
                new TeamMember { FirstName = "Seth", LastName = "DeValve", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 88, Height = "6-3", Weight = 245, Age = 26, CollegeName = "Princeton" },
                new TeamMember { FirstName = "Dede", LastName = "Westbrook", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 12, Height = "6-0", Weight = 178, Age = 26, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Nick", LastName = "Foles", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 7, Height = "6-6", Weight = 243, Age = 30, CollegeName = "Arizona" },
                new TeamMember { FirstName = "Leonard", LastName = "Fournette", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 27, Height = "6-0", Weight = 228, Age = 24, CollegeName = "LSU" },
                new TeamMember { FirstName = "DJ", LastName = "Clark Jr", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 17, Height = "6-4", Weight = 198, Age = 23, CollegeName = "LSU" },
                // Defense
                new TeamMember { FirstName = "Yannick", LastName = "Ngakoue", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 91, Height = "6-2", Weight = 246, Age = 24, CollegeName = "Mayland" },
                new TeamMember { FirstName = "Abry", LastName = "Jones", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 95, Height = "6-4", Weight = 318, Age = 28, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Taven", LastName = "Bryan", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 90, Height = "6-5", Weight = 291, Age = 23, CollegeName = "Florida" },
                new TeamMember { FirstName = "Calais", LastName = "Campbell", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_2], JerseyNumber = 93, Height = "6-8", Weight = 300, Age = 33, CollegeName = "Miami (Fla.)" },
                new TeamMember { FirstName = "Najee", LastName = "Goode", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 52, Height = "6-0", Weight = 244, Age = 30, CollegeName = "West Virginia" },
                new TeamMember { FirstName = "Myles", LastName = "Jack", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 44, Height = "6-1", Weight = 244, Age = 24, CollegeName = "UCLA" },
                new TeamMember { FirstName = "Leon", LastName = "Jacobs", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 48, Height = "6-2", Weight = 246, Age = 24, CollegeName = "Wisconsin" },
                new TeamMember { FirstName = "Tre", LastName = "Herndon", Position = Constants.Positions[Enums.PositionEnum.Left_Cornerback], JerseyNumber = 37, Height = "5-11", Weight = 185, Age = 23, CollegeName = "Vanderbilt" },
                new TeamMember { FirstName = "Jarrod", LastName = "Wilson", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 26, Height = "6-2", Weight = 210, Age = 25, CollegeName = "Michigan" },
                new TeamMember { FirstName = "Ronnie", LastName = "Harrison", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 36, Height = "6-3", Weight = 207, Age = 22, CollegeName = "Alabama" },
                new TeamMember { FirstName = "A.J.", LastName = "Bouye", Position = Constants.Positions[Enums.PositionEnum.Right_Cornerback], JerseyNumber = 21, Height = "6-0", Weight = 191, Age = 28, CollegeName = "Central Floria" },
                // Kicker
                new TeamMember { FirstName = "Josh", LastName = "Lambo", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "6-0", Weight = 215, Age = 29, CollegeName = "Texas A&M" },
                new TeamMember { FirstName = "Logan", LastName = "Cooke", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 9, Height = "6-5", Weight = 230, Age = 24, CollegeName = "Mississippi State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Doug", LastName = "Marrone", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "John", LastName = "Defilippo", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Todd", LastName = "Wash", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Joe", LastName = "Decamillis", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetJacksonvilleJaguarsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
