
using System;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    [Serializable]
    public class DivisionTeamsInformation
    {
        public string DivisionName { get; set; }
        public List<TeamInformation> NFLDivisionTeamsInformation { get; set; }
    }
}
