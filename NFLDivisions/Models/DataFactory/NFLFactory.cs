
using System.Collections.Generic;


namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NFLFactory : INFLFactory
    {
        private readonly NFC_North _nfcNorth;
        private readonly NFC_East _nfcEast;
        private readonly NFC_West _nfcWest;
        private readonly NFC_South _nfcSouth;

        private readonly AFC_North _afcNorth;
        private readonly AFC_East _afcEast;
        private readonly AFC_West _afcWest;
        private readonly AFC_South _afcSouth;

        public NFLFactory(int year)
        {
            _nfcEast = new NFC_East(year);
            _nfcWest = new NFC_West(year);
            _nfcSouth = new NFC_South(year);
            _nfcNorth = new NFC_North(year);

            _afcEast = new AFC_East(year);
            _afcWest = new AFC_West(year);
            _afcSouth = new AFC_South(year);
            _afcNorth = new AFC_North(year);
        }

        public List<TeamInformation> GetDivisionTeams(string division, int year)
        {
            List<TeamInformation> result;
            switch (division)
            {
                case Constants.AFC_East:
                    result = _afcEast.GetAFCEastTeams(year);
                    break;
                case Constants.AFC_North:
                    result = _afcNorth.GetAFCNorthTeams(year);
                    break;
                case Constants.AFC_South:
                    result = _afcSouth.GetAFCSouthTeams(year);
                    break;
                case Constants.AFC_West:
                    result = _afcWest.GetAFCWestTeams(year);
                    break;
                case Constants.NFC_East:
                    result = _nfcEast.GetNFCEastTeams(year);
                    break;
                case Constants.NFC_North:
                    result = _nfcNorth.GetNFCNorthTeams(year);
                    break;
                case Constants.NFC_South:
                    result = _nfcSouth.GetNFCSouthTeams(year);
                    break;
                case Constants.NFC_West:
                    result = _nfcWest.GetNFCWestTeams(year);
                    break;
                default:
                    result = new List<TeamInformation>();
                    break;
            }
            return result;
        }

        // TODO: Add these call from controller
        public List<DivisionRankingInformation> GetNFLStanding(int year)
        {
            return new List<DivisionRankingInformation>
            {
                _nfcNorth.GetNFCNorthStandings(),
                _nfcEast.GetNFCEastStandings(),
                _nfcWest.GetNFCWestStandings(),
                _nfcSouth.GetNFCSouthStandings(),

                _afcNorth.GetAFCNorthStandings(),
                _afcEast.GetAFCEastStandings(),
                _afcWest.GetAFCWestStandings(),
                _afcSouth.GetAFCSouthStandings(),
            };
        }

        public TeamInformation GetSpecificTeamInformation(string teamName, string teamDivision)
        {
            TeamInformation result = new TeamInformation();
            switch (teamDivision.ToUpper())
            {
                case "NFC NORTH":
                    result = _nfcNorth.GetTeamInformation(teamName);
                    break;
                case "NFC EAST":
                    result = _nfcEast.GetTeamInformation(teamName);
                    break;
                case "NFC WEST":
                    result = _nfcWest.GetTeamInformation(teamName);
                    break;
                case "NFC SOUTH":
                    result = _nfcSouth.GetTeamInformation(teamName);
                    break;
                case "AFC NORTH":
                    result = _afcNorth.GetTeamInformation(teamName);
                    break;
                case "AFC EAST":
                    result = _afcEast.GetTeamInformation(teamName);
                    break;
                case "AFC WEST":
                    result = _afcWest.GetTeamInformation(teamName);
                    break;
                case "AFC SOUTH":
                    result = _afcSouth.GetTeamInformation(teamName);
                    break;
                default:
                    break;
            }
            return result;
        }
    }
}
