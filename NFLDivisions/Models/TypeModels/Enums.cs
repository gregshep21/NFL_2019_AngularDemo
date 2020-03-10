

using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    public class Enums
    {
        public enum PositionEnum
        {
            Cornerback,
            Right_Cornerback,
            Left_Cornerback,
            Defensive_Line_1,
            Defensive_Line_2,
            Defensive_Line_3,
            Right_Defensive_End, 
            Defensive_Tackle_1,
            Defensive_Tackle_2,
            Right_Defensive_Tackle,
            Left_Defensive_Tackle,
            Left_Defensive_End,
            Defensive_End_1,
            Defensive_End_2,
            Defensive_End_3,
            Free_Safety,
            Outside_Linebacker,
            Right_Outside_Linebacker,
            Left_Outside_Linebacker,
            Strongside_Linebacker,
            Weakside_Linebacker,
            Middle_Linebacker,
            Inside_Linebacker,
            Left_Inside_Linebacker,
            Right_Inside_Linebacker,
            Linebacker_1,
            Linebacker_2,
            Linebacker_3,
            Linebacker_4,
            Linebacker_End_LEO,
            Strong_Safety,
            NickelBack,
            Safety,

            Quarter_Back, 
            Running_Back_1,
            Running_Back_2, 
            Half_Back,
            Full_Back,
            Wide_Reciever_1,
            Wide_Reciever_2,
            Wide_Reciever_3,
            Left_Wide_Reciever,
            Right_Wide_Reciever,
            Tight_End,
            Tight_End_1,
            Tight_End_2,
            Left_Tackle, 
            Nose_Tackle,
            Left_Guard, 
            Center, 
            Right_Guard, 
            Right_Tackle,
            Rush,

            Special_Teams,
            Kicker,
            Holder,
            Long_Snapper,
            Kick_Returner_Punt_Returner,
            Punter,
            Gunner_Jammer,

            Scrimmage_Team_Player,
            Water_Provider,
            HeadCoach,
            Assistant_Coach,
            Offensive_Coordinator,
            Run_Game_Coordinator,
            Pass_Game_Coordinator,
            Defensive_Coordinator,
            Special_Teams_Coordinator,
            Defensive_Line_Coach,
            Linebacker_Coach,
            Offensive_Line_Coach,
            Quarterback_Coach,
            Running_Back_Coach,
            Secondary_Coach,
            Special_Teams_Coach,
            Tight_Ends_Coach,
            Wide_Recievers_Coach,
            Owner
        }

        public enum DivisionEnum
        {
            AFC_North,
            AFC_East,
            AFC_West,
            AFC_South,

            NFC_North,
            NFC_East,
            NFC_West,
            NFC_South
        }


        public enum GameResultEnum
        {
            Win,
            Loss,
            Tie,
            ByeWeek,
            TBD
        }
    }
}
