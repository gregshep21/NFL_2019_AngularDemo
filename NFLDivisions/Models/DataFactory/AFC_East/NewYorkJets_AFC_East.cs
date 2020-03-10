
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NewYorkJets_AFC_East
    {
        private const string _teamName = "New York Jets";
        private const string _city = "New York";
        private const string _state = "New York";
        private const string _stadiumName = "MetLife Stadium";

        internal static TeamInformation GetNewYorkJetsInformation(int year)
        {
            return new TeamInformation
            {
                TeamName = _teamName,
                City = _city,
                State = _state,
                StadiumName = _stadiumName,
                Division = Constants.Divisions[Enums.DivisionEnum.AFC_East],
                Colors = new List<string> { "White", "Green" },
                SeasonSchedule = GetNewYorkJetsSchedule(year),
                Players = GetNewYorkJetsRoster(year),
                Coaches = Get_Coaches(year),
                RankingInformation = new TeamRankingInformation
                {
                    TeamName = _teamName,
                    SeasonGameCount = 20,
                    Ranking = 3,
                    TotalWins = 3,
                    TotalLosses = 7,
                    Ties = 0
                }
            };
        }

        public static List<TeamMember> GetNewYorkJetsRoster(int year)
        {
            return new List<TeamMember> { 
                // Offense
                new TeamMember { FirstName = "Robby", LastName = "Anderson", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_1], JerseyNumber = 11, Height = "6-3", Weight = 190, Age = 26, CollegeName = "Valencia College" },
                new TeamMember { FirstName = "Kelvin", LastName = "Beachum", Position = Constants.Positions[Enums.PositionEnum.Left_Tackle], JerseyNumber = 68, Height = "6-3", Weight = 308, Age = 30, CollegeName = "Southern Methodist" },
                new TeamMember { FirstName = "Alex", LastName = "Lewis", Position = Constants.Positions[Enums.PositionEnum.Left_Guard], JerseyNumber = 71, Height = "6-6", Weight = 305, Age = 27, CollegeName = "Nebraska" },
                new TeamMember { FirstName = "Jonotthan", LastName = "Harrison", Position = Constants.Positions[Enums.PositionEnum.Center], JerseyNumber = 78, Height = "6-4", Weight = 300, Age = 28, CollegeName = "Florida" },
                new TeamMember { FirstName = "Tom", LastName = "Compton", Position = Constants.Positions[Enums.PositionEnum.Right_Guard], JerseyNumber = 77, Height = "6-6", Weight = 315, Age = 30, CollegeName = "South Dakota" },
                new TeamMember { FirstName = "Chuma", LastName = "Edoga", Position = Constants.Positions[Enums.PositionEnum.Right_Tackle], JerseyNumber = 75, Height = "6-3", Weight = 308, Age = 22, CollegeName = "Southern California" },
                new TeamMember { FirstName = "Ryan", LastName = "Griffin", Position = Constants.Positions[Enums.PositionEnum.Tight_End], JerseyNumber = 84, Height = "6-6", Weight = 255, Age = 29, CollegeName = "Connecticut" },
                new TeamMember { FirstName = "Jamison", LastName = "Crowder", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_2], JerseyNumber = 82, Height = "5-9", Weight = 177, Age = 26, CollegeName = "Duke" },
                new TeamMember { FirstName = "Demaryius", LastName = "Thomas", Position = Constants.Positions[Enums.PositionEnum.Wide_Reciever_3], JerseyNumber = 18, Height = "6-3", Weight = 225, Age = 31, CollegeName = "Georgia Tech" },
                new TeamMember { FirstName = "Sam", LastName = "Darnold", Position = Constants.Positions[Enums.PositionEnum.Quarter_Back], JerseyNumber = 14, Height = "6-3", Weight = 308, Age = 22, CollegeName = "Southern California" },
                new TeamMember { FirstName = "Le'Veon", LastName = "Bell", Position = Constants.Positions[Enums.PositionEnum.Running_Back_1], JerseyNumber = 26, Height = "6-1", Weight = 225, Age = 27, CollegeName = "Michigan State" },
                // Defense
                new TeamMember { FirstName = "Henry", LastName = "Anderson", Position = Constants.Positions[Enums.PositionEnum.Defensive_Line_1], JerseyNumber = 96, Height = "6-6", Weight = 301, Age = 28, CollegeName = "Stanford" },
                new TeamMember { FirstName = "Steve", LastName = "McLendon", Position = Constants.Positions[Enums.PositionEnum.Defensive_Line_2], JerseyNumber = 99, Height = "6-3", Weight = 310, Age = 33, CollegeName = "Troy" },
                new TeamMember { FirstName = "Quinnen", LastName = "Willams", Position = Constants.Positions[Enums.PositionEnum.Defensive_Line_3], JerseyNumber = 95, Height = "6-3", Weight = 303, Age = 21, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Brandon", LastName = "Copeland", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 51, Height = "6-3", Weight = 263, Age = 28, CollegeName = "Pennsylvania" },
                new TeamMember { FirstName = "C.J.", LastName = "Mosley", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 57, Height = "6-2", Weight = 250, Age = 27, CollegeName = "Alabama" },
                new TeamMember { FirstName = "Neville", LastName = "Hewitt", Position = Constants.Positions[Enums.PositionEnum.Inside_Linebacker], JerseyNumber = 46, Height = "6-2", Weight = 234, Age = 26, CollegeName = "Marshall" },
                new TeamMember { FirstName = "Jordan", LastName = "Jenkins", Position = Constants.Positions[Enums.PositionEnum.Outside_Linebacker], JerseyNumber = 48, Height = "6-3", Weight = 259, Age = 25, CollegeName = "Georgia" },
                new TeamMember { FirstName = "Nate", LastName = "Hairston", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 21, Height = "6-0", Weight = 185, Age = 25, CollegeName = "Temple" },
                new TeamMember { FirstName = "Darryl", LastName = "Roberts", Position = Constants.Positions[Enums.PositionEnum.Cornerback], JerseyNumber = 27, Height = "6-0", Weight = 182, Age = 29, CollegeName = "Marshall" },
                new TeamMember { FirstName = "Jamal", LastName = "Adams", Position = Constants.Positions[Enums.PositionEnum.Strong_Safety], JerseyNumber = 33, Height = "6-1", Weight = 213, Age = 24, CollegeName = "LSU" },
                new TeamMember { FirstName = "Marcus", LastName = "Maye", Position = Constants.Positions[Enums.PositionEnum.Free_Safety], JerseyNumber = 20, Height = "6-0", Weight = 207, Age = 26, CollegeName = "Florida" },
                // Kicker
                new TeamMember { FirstName = "Sam", LastName = "Ficken", Position = Constants.Positions[Enums.PositionEnum.Kicker], JerseyNumber = 9, Height = "6-1", Weight = 192, Age = 26, CollegeName = "Penn State" },
                new TeamMember { FirstName = "Lachlan", LastName = "Edwards", Position = Constants.Positions[Enums.PositionEnum.Holder], JerseyNumber = 4, Height = "6-4", Weight = 209, Age = 27, CollegeName = "Sam Houston State" }
            };
        }

        private static List<Coach> Get_Coaches(int year)
        {
            return new List<Coach>
            {
                new Coach{ FirstName = "Adam", LastName = "Gase", Title =Constants.Positions[Enums.PositionEnum.HeadCoach] },
                new Coach{ FirstName = "Dowell", LastName = "Loggains", Title = Constants.Positions[Enums.PositionEnum.Offensive_Coordinator] },
                new Coach{ FirstName = "Gregg", LastName = "Williams", Title = Constants.Positions[Enums.PositionEnum.Defensive_Coordinator] },
                new Coach{ FirstName = "Brant", LastName = "Boyer", Title = Constants.Positions[Enums.PositionEnum.Special_Teams_Coordinator] }
            };
        }

        private static List<Schedule> GetNewYorkJetsSchedule(int year)
        {
            return new List<Schedule>();
        }
    }
}
