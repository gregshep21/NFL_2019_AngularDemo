using System;

namespace SPA_Angular_Demo.Models
{
    [Serializable]
    public class Schedule
    {
        public bool IsOnByeWeek { get; set; }
        public bool IsHomeGame { get; set; }
        public string GameLocationCity { get; set; }
        public string GameLocationState { get; set; }
        public string StatiumName { get; set; }
        public DateTime GameDayDate { get; set; }
        public string GameResult { get; set; }
        public  TeamInformation OpposingTeamInformation { get; set; }
    }
}
