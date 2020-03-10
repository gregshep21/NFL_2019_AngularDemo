
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NFC_West
    {
        private readonly TeamInformation _losAngelesRams;
        private readonly TeamInformation _seattleSeahawks;
        private readonly TeamInformation _sanFrancisco49ers;
        private readonly TeamInformation _arizonaCardinals;

        public NFC_West (int year)
        {
            _losAngelesRams = LosAngelesRams_NFC_West.GetLosAngelesRamsInformation(year);
            _seattleSeahawks = SeattleSeahawks_NFC_West.GetSeattleSeahawksInformation(year);
            _sanFrancisco49ers = SanFrancisco49ers_NFC_West.GetSanFrancisco49ersInformation(year);
            _arizonaCardinals = ArizonaCardinals_NFC_West.GetArizonaCardinalsInformation(year);
        }

        public List<TeamInformation> GetNFCWestTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _losAngelesRams,
                _seattleSeahawks,
                _sanFrancisco49ers,
                _arizonaCardinals
            };

            return result;
        }

        public DivisionRankingInformation GetNFCWestStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.NFC_West,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _losAngelesRams.RankingInformation,
                    _seattleSeahawks.RankingInformation,
                    _sanFrancisco49ers.RankingInformation,
                    _arizonaCardinals.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.LOS_ANGELES_RAMS:
                    result = _losAngelesRams;
                    break;
                case Constants.SEATTLE_SEAHAWKS:
                    result = _seattleSeahawks;
                    break;
                case Constants.SAN_FRANCISCO_49ERS:
                    result = _sanFrancisco49ers;
                    break;
                case Constants.ARIZONA_CARDINALS:
                    result = _arizonaCardinals;
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
                case Constants.LOS_ANGELES_RAMS:
                    result = _losAngelesRams.SeasonSchedule;
                    break;
                case Constants.SEATTLE_SEAHAWKS:
                    result = _seattleSeahawks.SeasonSchedule;
                    break;
                case Constants.SAN_FRANCISCO_49ERS:
                    result = _sanFrancisco49ers.SeasonSchedule;
                    break;
                case Constants.ARIZONA_CARDINALS:
                    result = _arizonaCardinals.SeasonSchedule;
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
                case Constants.LOS_ANGELES_RAMS:
                    result = _losAngelesRams.Players;
                    break;
                case Constants.SEATTLE_SEAHAWKS:
                    result = _seattleSeahawks.Players;
                    break;
                case Constants.SAN_FRANCISCO_49ERS:
                    result = _sanFrancisco49ers.Players;
                    break;
                case Constants.ARIZONA_CARDINALS:
                    result = _arizonaCardinals.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
