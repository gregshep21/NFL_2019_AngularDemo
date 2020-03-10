
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    public class Constants
    {
        public const string NFC_East = "NFC East";
        public const string NFC_West = "NFC West";
        public const string NFC_North = "NFC North";
        public const string NFC_South = "NFC South";

        public const string AFC_East = "AFC East";
        public const string AFC_West = "AFC West";
        public const string AFC_North = "AFC North";
        public const string AFC_South = "AFC South";

        // NFC EAST
        public const string NEW_YORK_GIANTS = "NEW YORK GIANTS";
        public const string PHILADELPHIA_EAGLES = "PHILADELPHIA EAGLES";
        public const string WASHINGTON_REDSKINS = "WASINGTON REDSKINS";
        public const string DALLAS_COWBOYS = "DALLAS COWBOYS";

        // NFC NORTH
        public const string CHICAGO_BEARS = "CHICAGO BEARS";
        public const string DETROIT_LIONS = "DETROIT LIONS";
        public const string GREEN_BAY_PACKERS = "GREEN BAY PACKERS";
        public const string MINNASOTA_VIKINGS = "MINNASOTA VIKINGS";

        // NFC SOUTH
        public const string ALANTA_FALCONS = "ALANTA FALCONS";
        public const string CAROLINA_PANTHERS = "CAROLINA PANTHERS";
        public const string NEW_ORLEANS_SAINTS = "NEW ORLEANS SAINTS";
        public const string TAMPA_BAY_BUCCANEERS = "TAMPA BAY BUCCANEERS";

        // NFC WEST
        public const string ARIZONA_CARDINALS = "ARIZONA CARDINALS";
        public const string LOS_ANGELES_RAMS = "LOS ANGELES RAMS";
        public const string SAN_FRANCISCO_49ERS = "SAN FRANCISCO 49ERS";
        public const string SEATTLE_SEAHAWKS = "SEATTLE SEAHAWKS";

        // AFC EAST
        public const string BUFFALO_BILLS = "BUFFALO BILLS";
        public const string MIAMI_DOLPHINS = "MIAMI DOLPHINS";
        public const string NEW_ENGLAND_PATRIOTS = "NEW ENGLAND PATRIOTS";
        public const string NEW_YORK_JETS = "NEW YORK JETS";

        // AFC NORTH
        public const string BALTIMORE_RAVENS = "BALTIMORE RAVENS";
        public const string CINCINNATI_BENGALS = "CINCINNATI BENGALS";
        public const string CLEVELAND_BROWNS = "CLEVELAND BROWNS";
        public const string PITTSBURGH_STEELERS = "PITTSBURGH STEELERS";

        // AFC SOUTH
        public const string HOUSTON_TEXANS = "HOUSTON TEXANS";
        public const string INDIANAPOLIS_COLTS = "INDIANAPOLIS COLTS";
        public const string JACKSONVILLE_JAGUARS = "JACKSONVILLE JAGUARS";
        public const string TENNESSEE_TITANS = "TENNESSEE TITANS";

        // AFC WEST
        public const string DENVER_BRONCOS = "DENVER BRONCOS";
        public const string KANSAS_CITY_CHIEFS = "KANSAS CITY CHIEFS";
        public const string LOS_ANGELES_CHARGERS = "LOS ANGELES CHARGERS";
        public const string OAKLAND_RAIDERS = "OAKLAND RAIDERS";

        public static readonly Dictionary<Enums.DivisionEnum, string> Divisions = new Dictionary<Enums.DivisionEnum, string>
        {
            { Enums.DivisionEnum.AFC_North, "AFC North" },
            { Enums.DivisionEnum.AFC_East, "AFC East" },
            { Enums.DivisionEnum.AFC_West, "AFC West" },
            { Enums.DivisionEnum.AFC_South, "AFC South" },
            
            { Enums.DivisionEnum.NFC_North, "NFC North" },
            { Enums.DivisionEnum.NFC_East, "NFC East" },
            { Enums.DivisionEnum.NFC_West, "NFC West" },
            { Enums.DivisionEnum.NFC_South, "NFC South" },
        };

        public static readonly Dictionary<Enums.PositionEnum, string> Positions = new Dictionary<Enums.PositionEnum, string>
        {
            { Enums.PositionEnum.Cornerback, "Cornerback" },
            { Enums.PositionEnum.Right_Cornerback, "Right Cornerback" },
            { Enums.PositionEnum.Left_Cornerback, "Left Cornerback" },
            { Enums.PositionEnum.Defensive_Line_1, "Defensive Line 1" },
            { Enums.PositionEnum.Defensive_Line_2, "Defensive Line 2" },
            { Enums.PositionEnum.Defensive_Line_3, "Defensive Line 3" },
            { Enums.PositionEnum.Right_Defensive_End, "Right Defensive End" },
            { Enums.PositionEnum.Defensive_Tackle_1, "Defensive Tackle 1" },
            { Enums.PositionEnum.Defensive_Tackle_2, "Defensive Tackle 2" },
            { Enums.PositionEnum.Right_Defensive_Tackle, "Right Defensive Tackle" },
            { Enums.PositionEnum.Left_Defensive_Tackle, "Left Defensive Tackle" },
            { Enums.PositionEnum.Left_Defensive_End, "Left Defensive End" },
            { Enums.PositionEnum.Defensive_End_1, "Defensive End 1" },
            { Enums.PositionEnum.Defensive_End_2, "Defensive End 2" },
            { Enums.PositionEnum.Defensive_End_3, "Defensive End 3" },
            { Enums.PositionEnum.Free_Safety, "Free Safety" },
            { Enums.PositionEnum.Outside_Linebacker, "Outside Linebacker" },
            { Enums.PositionEnum.Right_Outside_Linebacker, "Right Outside Linebacker" },
            { Enums.PositionEnum.Left_Outside_Linebacker, "Left Outside Linebacker" },
            { Enums.PositionEnum.Strongside_Linebacker, "Strongside Linebacker" },
            { Enums.PositionEnum.Weakside_Linebacker, "Weakside Linebacker" },
            { Enums.PositionEnum.Middle_Linebacker, "Middle Linebacker" },
            { Enums.PositionEnum.Inside_Linebacker, "Inside Linebacker" },
            { Enums.PositionEnum.Left_Inside_Linebacker, "Left Inside Linebacker" },
            { Enums.PositionEnum.Right_Inside_Linebacker, "Right Inside Linebacker" },
            { Enums.PositionEnum.Linebacker_1, "Linebacker 1" },
            { Enums.PositionEnum.Linebacker_2, "Linebacker 2" },
            { Enums.PositionEnum.Linebacker_3, "Linebacker 3" },
            { Enums.PositionEnum.Linebacker_4, "Linebacker 4" },
            { Enums.PositionEnum.Linebacker_End_LEO, "Linebacker End LEO" },
            { Enums.PositionEnum.Strong_Safety, "Strong Safety" },
            { Enums.PositionEnum.NickelBack, "NickelBack" },
            { Enums.PositionEnum.Safety, "Safety" },

            { Enums.PositionEnum.Quarter_Back, "Quarter Back" },
            { Enums.PositionEnum.Running_Back_1, "Running Back 1" },
            { Enums.PositionEnum.Running_Back_2, "Running Back 2" },
            { Enums.PositionEnum.Half_Back, "Half Back" },
            { Enums.PositionEnum.Full_Back, "Full Back" },
            { Enums.PositionEnum.Wide_Reciever_1, "Wide Reciever 1" },
            { Enums.PositionEnum.Wide_Reciever_2, "Wide Reciever 2" },
            { Enums.PositionEnum.Wide_Reciever_3, "Wide Reciever 3" },
            { Enums.PositionEnum.Left_Wide_Reciever, "Left Wide Reciever" },
            { Enums.PositionEnum.Right_Wide_Reciever, "Right Wide Reciever" },
            { Enums.PositionEnum.Tight_End, "Tight End" },
            { Enums.PositionEnum.Tight_End_1, "Tight End 1" },
            { Enums.PositionEnum.Tight_End_2, "Tight End 2" },
            { Enums.PositionEnum.Left_Tackle, "Left Tackle" },
            { Enums.PositionEnum.Nose_Tackle, "Nose Tackle" },
            { Enums.PositionEnum.Left_Guard, "Left Guard" },
            { Enums.PositionEnum.Center, "Center" },
            { Enums.PositionEnum.Right_Guard, "Right Guard" },
            { Enums.PositionEnum.Right_Tackle, "Right Tackle" },
            { Enums.PositionEnum.Rush, "Rush" },

            { Enums.PositionEnum.Special_Teams, "Special Teams" },
            { Enums.PositionEnum.Kicker, "Kicker" },
            { Enums.PositionEnum.Holder, "Holder" },
            { Enums.PositionEnum.Long_Snapper, "Long Snapper" },
            { Enums.PositionEnum.Kick_Returner_Punt_Returner, "Kick or Punt Returner" },
            { Enums.PositionEnum.Punter, "Punter" },
            { Enums.PositionEnum.Gunner_Jammer, "Gunner or Jammer" },

            { Enums.PositionEnum.Scrimmage_Team_Player, "Scrimmage Team Player" },
            { Enums.PositionEnum.Water_Provider, "Water Provider" },
            { Enums.PositionEnum.HeadCoach, "HeadCoach" },
            { Enums.PositionEnum.Assistant_Coach, "Assistant Coach" },
            { Enums.PositionEnum.Offensive_Coordinator, "Offensive Coordinator" },
            { Enums.PositionEnum.Run_Game_Coordinator, "Run Game Coordinator" },
            { Enums.PositionEnum.Pass_Game_Coordinator, "Pass Game Coordinator" },
            { Enums.PositionEnum.Defensive_Coordinator, "Defensive Coordinator" },
            { Enums.PositionEnum.Special_Teams_Coordinator, "Special Teams Coordinator" },
            { Enums.PositionEnum.Defensive_Line_Coach, "Defensive Line Coach" },
            { Enums.PositionEnum.Linebacker_Coach, "Linebacker Coach" },
            { Enums.PositionEnum.Offensive_Line_Coach, "Offensive Line Coach" },
            { Enums.PositionEnum.Quarterback_Coach, "Quarterback Coach" },
            { Enums.PositionEnum.Running_Back_Coach, "Running Back Coach" },
            { Enums.PositionEnum.Secondary_Coach, "Secondary Coach" },
            { Enums.PositionEnum.Special_Teams_Coach, "Special Teams Coach" },
            { Enums.PositionEnum.Tight_Ends_Coach, "Tight Ends Coach" },
            { Enums.PositionEnum.Wide_Recievers_Coach, "Wide Recievers Coach" },
            { Enums.PositionEnum.Owner, "Owner" }
        };

        public static readonly Dictionary<Enums.GameResultEnum, string> GameResult = new Dictionary<Enums.GameResultEnum, string>
        {
            { Enums.GameResultEnum.Win, "Win" },
            { Enums.GameResultEnum.Loss, "Loss" },
            { Enums.GameResultEnum.Tie, "Tie" },
            { Enums.GameResultEnum.ByeWeek, "Bye Week" },
            { Enums.GameResultEnum.TBD, "To Be Determined" }
        };
    }
}
