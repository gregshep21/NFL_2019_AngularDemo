
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class AFC_West
    {
        private readonly TeamInformation _kansasCityChiefs;
        private readonly TeamInformation _oaklandRaiders;
        private readonly TeamInformation _losAngelesChargers;
        private readonly TeamInformation _denverBroncos;

        public AFC_West(int year)
        {
            _kansasCityChiefs = KansasCityChiefs_AFC_West.GetKansasCityChiefsInformation(year);
            _oaklandRaiders = OaklandRaiders_AFC_West.GetOaklandRaidersInformation(year);
            _losAngelesChargers = LosAngelesChargers_AFC_West.GetLosAngelesChargersInformation(year);
            _denverBroncos = DenverBroncos_AFC_West.GetDenverBroncosInformation(year);
        }

        public List<TeamInformation> GetAFCWestTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _kansasCityChiefs,
                _oaklandRaiders,
                _losAngelesChargers,
                _denverBroncos
            };
            return result;
        }

        public DivisionRankingInformation GetAFCWestStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.AFC_West,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _kansasCityChiefs.RankingInformation,
                    _oaklandRaiders.RankingInformation,
                    _losAngelesChargers.RankingInformation,
                    _denverBroncos.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.KANSAS_CITY_CHIEFS:
                    result = _kansasCityChiefs;
                    break;
                case Constants.OAKLAND_RAIDERS:
                    result = _oaklandRaiders;
                    break;
                case Constants.LOS_ANGELES_CHARGERS:
                    result = _losAngelesChargers;
                    break;
                case Constants.DENVER_BRONCOS:
                    result = _denverBroncos;
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
                case Constants.KANSAS_CITY_CHIEFS:
                    result = _kansasCityChiefs.SeasonSchedule;
                    break;
                case Constants.OAKLAND_RAIDERS:
                    result = _oaklandRaiders.SeasonSchedule;
                    break;
                case Constants.LOS_ANGELES_CHARGERS:
                    result = _losAngelesChargers.SeasonSchedule;
                    break;
                case Constants.DENVER_BRONCOS:
                    result = _denverBroncos.SeasonSchedule;
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
                case Constants.KANSAS_CITY_CHIEFS:
                    result = _kansasCityChiefs.Players;
                    break;
                case Constants.OAKLAND_RAIDERS:
                    result = _oaklandRaiders.Players;
                    break;
                case Constants.LOS_ANGELES_CHARGERS:
                    result = _losAngelesChargers.Players;
                    break;
                case Constants.DENVER_BRONCOS:
                    result = _denverBroncos.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
