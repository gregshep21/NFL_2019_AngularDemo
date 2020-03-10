
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NFC_North
    {
        private readonly TeamInformation _greenBayPackers;
        private readonly TeamInformation _minnesotaVikings;
        private readonly TeamInformation _chicagoBears;
        private readonly TeamInformation _detroitLions;

        public NFC_North(int year)
        {
            _greenBayPackers = GreenBayPackers_NFC_North.GetGreenBayPackersInformation(year);
            _minnesotaVikings = MinnesotaVikings_NFC_North.GetMinnesotaVikingsInformation(year);
            _chicagoBears = ChicagoBears_NFC_North.GetChicagoBearsInformation(year);
            _detroitLions = DetroitLions_NFC_North.GetDetroitLionsInformation(year);
        }

        public List<TeamInformation> GetNFCNorthTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _greenBayPackers,
                _minnesotaVikings,
                _chicagoBears,
                _detroitLions,
            };
            return result;
        }

        public DivisionRankingInformation GetNFCNorthStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.NFC_North,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _greenBayPackers.RankingInformation,
                    _minnesotaVikings.RankingInformation,
                    _chicagoBears.RankingInformation,
                    _detroitLions.RankingInformation
                }
            };
        }


        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.GREEN_BAY_PACKERS:
                    result = _greenBayPackers;
                    break;
                case Constants.MINNASOTA_VIKINGS:
                    result = _minnesotaVikings;
                    break;
                case Constants.CHICAGO_BEARS:
                    result = _chicagoBears;
                    break;
                case Constants.DETROIT_LIONS:
                    result = _detroitLions;
                    break;
                default:
                    result = new TeamInformation();
                    break;
            }
            return result;
        }

        public List<Schedule> GetTeamSchedule(string teamName)
        {
            List<Schedule> result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.GREEN_BAY_PACKERS:
                    result = _greenBayPackers.SeasonSchedule;
                    break;
                case Constants.MINNASOTA_VIKINGS:
                    result = _minnesotaVikings.SeasonSchedule;
                    break;
                case Constants.CHICAGO_BEARS:
                    result = _chicagoBears.SeasonSchedule;
                    break;
                case Constants.DETROIT_LIONS:
                    result = _detroitLions.SeasonSchedule;
                    break;
                default:
                    result = new List<Schedule>();
                    break;
            }
            return result;
        }

        public List<TeamMember> GetTeamRoster(string teamName)
        {
            List<TeamMember> result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.GREEN_BAY_PACKERS:
                    result = _greenBayPackers.Players;
                    break;
                case Constants.MINNASOTA_VIKINGS:
                    result = _minnesotaVikings.Players;
                    break;
                case Constants.CHICAGO_BEARS:
                    result = _chicagoBears.Players;
                    break;
                case Constants.DETROIT_LIONS:
                    result = _detroitLions.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
