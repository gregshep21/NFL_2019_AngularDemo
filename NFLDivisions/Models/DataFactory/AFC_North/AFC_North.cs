
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class AFC_North
    {
        private readonly TeamInformation _baltimoreRavens;
        private readonly TeamInformation _pittsburghSteelers;
        private readonly TeamInformation _clevelandBrowns;
        private readonly TeamInformation _cincinnatiBengals;

        public AFC_North(int year)
        {
            _baltimoreRavens = BaltimoreRavens_AFC_North.GetBaltimoreRavensInformation(year);
            _pittsburghSteelers = PittsburgSteelers_AFC_North.GetPittsburghSteelersInformation(year);
            _clevelandBrowns = ClevelandBrowns_AFC_North.GetClevelandBrownsInformation(year);
            _cincinnatiBengals = CincinnatiBengals_AFC_North.GetCincinnatiBengalsInformation(year);
        }

        public List<TeamInformation> GetAFCNorthTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _baltimoreRavens,
                _pittsburghSteelers,
                _clevelandBrowns,
                _cincinnatiBengals
            };
            return result;
        }

        public DivisionRankingInformation GetAFCNorthStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.AFC_North,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _baltimoreRavens.RankingInformation,
                    _pittsburghSteelers.RankingInformation,
                    _clevelandBrowns.RankingInformation,
                    _cincinnatiBengals.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.BALTIMORE_RAVENS:
                    result = _baltimoreRavens;
                    break;
                case Constants.PITTSBURGH_STEELERS:
                    result = _pittsburghSteelers;
                    break;
                case Constants.CLEVELAND_BROWNS:
                    result = _clevelandBrowns;
                    break;
                case Constants.CINCINNATI_BENGALS:
                    result = _cincinnatiBengals;
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
                case Constants.BALTIMORE_RAVENS:
                    result = _baltimoreRavens.SeasonSchedule;
                    break;
                case Constants.PITTSBURGH_STEELERS:
                    result = _pittsburghSteelers.SeasonSchedule;
                    break;
                case Constants.CLEVELAND_BROWNS:
                    result = _clevelandBrowns.SeasonSchedule;
                    break;
                case Constants.CINCINNATI_BENGALS:
                    result = _cincinnatiBengals.SeasonSchedule;
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
                case Constants.BALTIMORE_RAVENS:
                    result = _baltimoreRavens.Players;
                    break;
                case Constants.PITTSBURGH_STEELERS:
                    result = _pittsburghSteelers.Players;
                    break;
                case Constants.CLEVELAND_BROWNS:
                    result = _clevelandBrowns.Players;
                    break;
                case Constants.CINCINNATI_BENGALS:
                    result = _cincinnatiBengals.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
