
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NFC_South
    {
        private readonly TeamInformation _newOrleansSaints;
        private readonly TeamInformation _carolinaPanthers;
        private readonly TeamInformation _alantaFalcons;
        private readonly TeamInformation _tampaBayBuccaneers;

        public NFC_South(int year)
        {
            _newOrleansSaints = NewOrleansSaints_NFC_South.GetNewOrleansSaintsInformation(year);
            _carolinaPanthers = CarolinaPanthers_NFC_South.GetCarolinaPanthersInformation(year);
            _alantaFalcons = AlantaFalcons_NFC_South.GetAlantaFalconsInformation(year);
            _tampaBayBuccaneers = TampaBayBuccaneers_NFC_South.GetTampaBayBuccaneersInformation(year);
        }
       
        public List<TeamInformation> GetNFCSouthTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _newOrleansSaints,
                _carolinaPanthers,
                _alantaFalcons,
                _tampaBayBuccaneers
            };

            return result;
        }

        public DivisionRankingInformation GetNFCSouthStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.NFC_South,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _newOrleansSaints.RankingInformation,
                    _carolinaPanthers.RankingInformation,
                    _alantaFalcons.RankingInformation,
                    _tampaBayBuccaneers.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.NEW_ORLEANS_SAINTS:
                    result = _newOrleansSaints;
                    break;
                case Constants.CAROLINA_PANTHERS:
                    result = _carolinaPanthers;
                    break;
                case Constants.ALANTA_FALCONS:
                    result = _alantaFalcons;
                    break;
                case Constants.TAMPA_BAY_BUCCANEERS:
                    result = _tampaBayBuccaneers;
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
                case Constants.NEW_ORLEANS_SAINTS:
                    result = _newOrleansSaints.SeasonSchedule;
                    break;
                case Constants.CAROLINA_PANTHERS:
                    result = _carolinaPanthers.SeasonSchedule;
                    break;
                case Constants.ALANTA_FALCONS:
                    result = _alantaFalcons.SeasonSchedule;
                    break;
                case Constants.TAMPA_BAY_BUCCANEERS:
                    result = _tampaBayBuccaneers.SeasonSchedule;
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
                case Constants.NEW_ORLEANS_SAINTS:
                    result = _newOrleansSaints.Players;
                    break;
                case Constants.CAROLINA_PANTHERS:
                    result = _carolinaPanthers.Players;
                    break;
                case Constants.ALANTA_FALCONS:
                    result = _alantaFalcons.Players;
                    break;
                case Constants.TAMPA_BAY_BUCCANEERS:
                    result = _tampaBayBuccaneers.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
