using SPA_Angular_Demo.Models.DataFactory;
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models
{
    public class NFLManager : INFLManager
    {
        private INFLFactory _nflFactory;
        public NFLManager(INFLFactory nflFactory)
        {
            _nflFactory = nflFactory;
        }

        public List<DivisionTeamsInformation> GetAllNFLDivisionTeams(int year)
        {
            List<DivisionTeamsInformation> result = new List<DivisionTeamsInformation>
            {
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.AFC_East,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.AFC_East, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.AFC_North,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.AFC_North, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.AFC_South,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.AFC_South, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.AFC_West,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.AFC_West, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.NFC_East,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.NFC_East, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.NFC_North,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.NFC_North, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.NFC_South,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.NFC_South, year)
                },
                new DivisionTeamsInformation
                {
                    DivisionName = Constants.NFC_West,
                    NFLDivisionTeamsInformation = _nflFactory.GetDivisionTeams(Constants.NFC_West, year)
                }
            };
            return result;
        }
    }
}
