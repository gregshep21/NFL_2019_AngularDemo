
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class BuffaloBills_AFC_East
    {
        private const string _teamName = "Buffalo Bills";
        private const string _city = "Buffalo";
        private const string _state = "New York";
        private const string _stadiumName = "New Era Field";

        internal static TeamInformation GetBuffaloBillsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_East],
                Colors = new List<string> { "White:White", "Navy Blue:Navy", "Red:Red", "Royal Blue:RoyalBlue" },
                SeasonSchedule = GetBuffaloBillsSchedule(year),
                Players = GetBuffaloBillsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 7,
                    TotalLosses = 3,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetBuffaloBillsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "John", LastName = "Brown", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 15, Height = "5-11", Weight = 178, Age = 29, CollegeName = "Pittsburg State" },
                new TeamMember { FirstName = "Dion", LastName = "Dawkins", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 73, Height = "6-5", Weight = 320, Age = 25, CollegeName = "Temple" },
                new TeamMember { FirstName = "Quinton", LastName = "Spain", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 67, Height = "6-4", Weight = 330, Age = 28, CollegeName = "West Virginia" },
                new TeamMember { FirstName = "Mitch", LastName = "Morse", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 93, Height = "6-6", Weight = 305, Age = 27, CollegeName = "Missouri" },
                new TeamMember { FirstName = "Jon", LastName = "Feliciano", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 76, Height = "6-4", Weight = 325, Age = 27, CollegeName = "Miami(Fla.)" },
                new TeamMember { FirstName = "Cody", LastName = "Ford", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 70, Height = "6-3", Weight = 329, Age = 22, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Tyler", LastName = "Kroft", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 81, Height = "6-6", Weight = 252, Age = 27, CollegeName = "Rutgers" },
                new TeamMember { FirstName = "Josh", LastName = "Allen", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 17, Height = "6-5", Weight = 237, Age = 23, CollegeName = "Wyoming" },
                new TeamMember { FirstName = "Patrick", LastName = "DiMarco", Position = Constants.Positions[Enums.PositionEnum.Full_Back], JerseyNumber = 42, Height = "6-1", Weight = 234, Age = 30, CollegeName = "South Carolina" },
                new TeamMember { FirstName = "Frank", LastName = "Gore", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 20, Height = "5-9", Weight = 212, Age = 36, CollegeName = "Miami(Fla.)" },
                new TeamMember { FirstName = "Cole", LastName = "Beasley", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 10, Height = "5-8", Weight = 174, Age = 30, CollegeName = "Southern Methodist" },
                // Defense
                new TeamMember { FirstName = "Trent", LastName = "Murphy", Position = Constants.Positions[Enums.PositionEnum.Left_Defensive_End], JerseyNumber = 93, Height = "6-6", Weight = 260, Age = 28, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Jordan", LastName = "Phillips", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 97, Height = "6-6", Weight = 341, Age = 27, CollegeName = "Oklahoma" },
                new TeamMember { FirstName = "Star", LastName = "Lotulelei", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_2], JerseyNumber = 98, Height = "6-2", Weight = 315, Age = 29, CollegeName = "Utah" },
                new TeamMember { FirstName = "Jerry", LastName = "Hughes", Position = Constants.Positions[Enums.PositionEnum.Right_Defensive_End], JerseyNumber = 55, Height = "6-2", Weight = 254, Age = 31, CollegeName = "Texas Christian" },
                new TeamMember { FirstName = "Matt", LastName = "Milano", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 58, Height = "6-0", Weight = 223, Age = 25, CollegeName = "Boston College" },
                new TeamMember { FirstName = "Tremaine", LastName = "Edmunds", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 49, Height = "6-5", Weight = 250, Age = 21, CollegeName = "Virginia Tech" },
                new TeamMember { FirstName = "Lorenzo", LastName = "Alexander", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 57, Height = "6-1", Weight = 245, Age = 36, CollegeName = "California" },
                new TeamMember { FirstName = "Tre'Davious", LastName = "White", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 27, Height = "5-11", Weight = 192, Age = 23, CollegeName = "Louisiana State" },
                new TeamMember { FirstName = "Levi", LastName = "Wallace", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 39, Height = "6-0", Weight = 179, Age = 24, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Taron", LastName = "Johnson", Position = Constants.Positions[Enums.PositionEnum.NickelBack], JerseyNumber = 24, Height = "5-11", Weight = 192, Age = 23, CollegeName = "Weber State" },
                new TeamMember { FirstName = "Jordan", LastName = "Poyer", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 21, Height = "6-0", Weight = 191, Age = 28, CollegeName = "Oregon State" },
                new TeamMember { FirstName = "Micah", LastName = "Hyde", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 23, Height = "6-0", Weight = 197, Age = 28, CollegeName = "Iowa" },
                // Kicker
                new TeamMember { FirstName = "Stephen", LastName = "Hauschka", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "6-4", Weight = 210, Age = 34, CollegeName = "Middlebury" },
                new TeamMember { FirstName = "Corey", LastName = "Bojorquez", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 9, Height = "6-0", Weight = 208, Age = 23, CollegeName = "New Mexico" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach{ FirstName = "Sean", LastName = "McDermott", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach{ FirstName = "Brian", LastName = "Daboll", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach{ FirstName = "Leslie", LastName = "Frazier", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach{ FirstName = "Heath", LastName = "Farwell", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetBuffaloBillsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
