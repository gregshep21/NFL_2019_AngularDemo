using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public interface INFLFactory
    {
        public List<TeamInformation> GetDivisionTeams(string division, int year);
        public List<DivisionRankingInformation> GetNFLStanding(int year);
        public TeamInformation GetSpecificTeamInformation(string teamName, string teamDivision);
    }
}
