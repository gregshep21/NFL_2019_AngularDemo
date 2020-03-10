
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class AFC_South
    {

        private readonly TeamInformation _houstonTexans;
        private readonly TeamInformation _indianapolisColts;
        private readonly TeamInformation _tennesseeTitans;
        private readonly TeamInformation _jacksonvilleJaguars;

        public AFC_South(int year)
        {
            _houstonTexans = HoustonTexans_AFC_South.GetHoustonTexansInformation(year);
            _indianapolisColts = IndianapolisColts_AFC_South.GetIndianapolisColtsInformation(year);
            _tennesseeTitans = TennesseeTitans_AFC_South.GetTennesseeTitansInformation(year);
            _jacksonvilleJaguars = JacksonvilleJaguars_AFC_South.GetJacksonvilleJaguarsInformation(year);
        }

        public List<TeamInformation> GetAFCSouthTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _houstonTexans,
                _indianapolisColts,
                _tennesseeTitans,
                _jacksonvilleJaguars
            };
            return result;
        }

        public DivisionRankingInformation GetAFCSouthStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.AFC_South,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _houstonTexans.RankingInformation,
                    _indianapolisColts.RankingInformation,
                    _tennesseeTitans.RankingInformation,
                    _jacksonvilleJaguars.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.HOUSTON_TEXANS:
                    result = _houstonTexans;
                    break;
                case Constants.INDIANAPOLIS_COLTS:
                    result = _indianapolisColts;
                    break;
                case Constants.TENNESSEE_TITANS:
                    result = _tennesseeTitans;
                    break;
                case Constants.JACKSONVILLE_JAGUARS:
                    result = _jacksonvilleJaguars;
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
                case Constants.HOUSTON_TEXANS:
                    result = _houstonTexans.SeasonSchedule;
                    break;
                case Constants.INDIANAPOLIS_COLTS:
                    result = _indianapolisColts.SeasonSchedule;
                    break;
                case Constants.TENNESSEE_TITANS:
                    result = _tennesseeTitans.SeasonSchedule;
                    break;
                case Constants.JACKSONVILLE_JAGUARS:
                    result = _jacksonvilleJaguars.SeasonSchedule;
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
                case Constants.HOUSTON_TEXANS:
                    result = _houstonTexans.Players;
                    break;
                case Constants.INDIANAPOLIS_COLTS:
                    result = _indianapolisColts.Players;
                    break;
                case Constants.TENNESSEE_TITANS:
                    result = _tennesseeTitans.Players;
                    break;
                case Constants.JACKSONVILLE_JAGUARS:
                    result = _jacksonvilleJaguars.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
