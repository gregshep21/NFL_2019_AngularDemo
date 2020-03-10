

using System;

namespace SPA_Angular_Demo.Models
{
    [Serializable]
    public class TeamMember
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int JerseyNumber { get; set; }
        public string Position { get; set; }
        public int Weight { get; set; }
        public string Height { get; set; }
        public int Age { get; set; }
        public string CollegeName { get; set; }
    }
}
