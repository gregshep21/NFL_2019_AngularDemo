
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class IndianapolisColts_AFC_South
    {
        private const string _teamName = "Indianapolis Colts";
        private const string _city = "Indianapolis";
        private const string _state = "Indiana";
        private const string _stadiumName = "Lucas Oil Stadium";

        public static TeamInformation GetIndianapolisColtsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_South],
                Colors = new List<string> { "White", "Royal Blue", "Blue" },
                SeasonSchedule = GetIndianapolisColtsSchedule(year),
                Players = GetIndianapolisColtsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 2,
                    TotalWins = 6,
                    TotalLosses = 5,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetIndianapolisColtsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "T.Y.", LastName = "Hilton", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 13, Height = "5-10", Weight = 183, Age = 30, CollegeName = "Florida International" },
                new TeamMember { FirstName = "Anthony", LastName = "Castonzo", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 74, Height = "6-7", Weight = 307, Age = 31, CollegeName = "Boston College" },
                new TeamMember { FirstName = "Quenton", LastName = "Nelson", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 56, Height = "6-5", Weight = 330, Age = 23, CollegeName = "Notre Dame" },
                new TeamMember { FirstName = "Ryan", LastName = "Kelly", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 78, Height = "6-4", Weight = 307, Age = 26, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Mark", LastName = "Glowinski", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 64, Height = "6-4", Weight = 310, Age = 27, CollegeName = "West Virginia" },
                new TeamMember { FirstName = "Braden", LastName = "Smith", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 72, Height = "6-6", Weight = 315, Age = 23, CollegeName = "Auburn" },
                new TeamMember { FirstName = "Jack", LastName = "Doyle", Position = Constants.Positions[Enums.PositionEnum.Tight_End_1], JerseyNumber = 84, Height = "6-6", Weight = 262, Age = 29, CollegeName = "Western Kentucky" },
                new TeamMember { FirstName = "Zach", LastName = "Pascal", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 14, Height = "6-2", Weight = 214, Age = 24, CollegeName = "Old Dominion" },
                new TeamMember { FirstName = "Jocoby", LastName = "Brissett", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 7, Height = "6-4", Weight = 328, Age = 26, CollegeName = "North Carolina State" },
                new TeamMember { FirstName = "Eric", LastName = "Ebron", Position = Constants.Positions[Enums.PositionEnum.Tight_End_2], JerseyNumber = 85, Height = "6-4", Weight = 253, Age = 26, CollegeName = "North Carolina" },
                new TeamMember { FirstName = "Marion", LastName = "Mack", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 25, Height = "6-0", Weight = 210, Age = 23, CollegeName = "South Florida" },
                // Defense
                new TeamMember { FirstName = "Justin", LastName = "Houston", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 99, Height = "6-3", Weight = 270, Age = 30, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Grover", LastName = "Stewart", Position = Constants.Positions[Enums.PositionEnum.Nose_Tackle], JerseyNumber = 90, Height = "6-4", Weight = 315, Age = 326, CollegeName = "Albany State (Ga.)" },
                new TeamMember { FirstName = "Denico", LastName = "Autry", Position = Constants.Positions[Enums.PositionEnum.Defensive_Tackle_1], JerseyNumber = 96, Height = "6-5", Weight = 285, Age = 29, CollegeName = "Mississippi State" },
                new TeamMember { FirstName = "Jabaal", LastName = "Sheard", Position = Constants.Positions[Enums.PositionEnum.Defensive_End_1], JerseyNumber = 93, Height = "6-3", Weight = 268, Age = 30, CollegeName = "Pittsburgh" },
                new TeamMember { FirstName = "Darius", LastName = "Leonard", Position = Constants.Positions[Enums.PositionEnum.Weakside_Linebacker], JerseyNumber = 53, Height = "6-2", Weight = 230, Age = 24, CollegeName = "South Carolina State" },
                new TeamMember { FirstName = "Anthony", LastName = "Walker", Position = Constants.Positions[Enums.PositionEnum.Middle_Linebacker], JerseyNumber = 50, Height = "6-1", Weight = 230, Age = 24, CollegeName = "Northwestern" },
                new TeamMember { FirstName = "Matthew", LastName = "Adams", Position = Constants.Positions[Enums.PositionEnum.Strongside_Linebacker], JerseyNumber = 49, Height = "6-0", Weight = 229, Age = 23, CollegeName = "Houston" },
                new TeamMember { FirstName = "Kenny", LastName = "Moore II", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 23, Height = "5-9", Weight = 190, Age = 24, CollegeName = "Valdosta State" },
                new TeamMember { FirstName = "Malik", LastName = "Hooker", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 29, Height = "6-1", Weight = 214, Age = 23, CollegeName = "Ohio State" },
                new TeamMember { FirstName = "Clayton", LastName = "Geathers", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 26, Height = "6-2", Weight = 216, Age = 27, CollegeName = "Central Florida" },
                new TeamMember { FirstName = "Pierre", LastName = "Desir", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 35, Height = "6-1", Weight = 192, Age = 29, CollegeName = "Lindenwood" },
                // Kicker
                new TeamMember { FirstName = "Adam", LastName = "Vinatieri", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 4, Height = "6-0", Weight = 212, Age = 46, CollegeName = "South Dakota State" },
                new TeamMember { FirstName = "Rigoberto", LastName = "Sanchez", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 8, Height = "6-0", Weight = 195, Age = 25, CollegeName = "Hawaii" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach { FirstName = "Frank", LastName = "Reich", Title = Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach { FirstName = "Nick", LastName = "Sirianni", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach { FirstName = "Matt", LastName = "Eberflus", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach { FirstName = "Bubba", LastName = "Ventrone", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetIndianapolisColtsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
