
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    public interface INFLManager
    {
        public List<DivisionTeamsInformation> GetAllNFLDivisionTeams(int year);
    }
}
