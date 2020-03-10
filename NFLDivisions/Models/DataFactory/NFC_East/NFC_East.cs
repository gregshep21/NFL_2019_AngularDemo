
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class NFC_East : INFC_East
    {
        private readonly TeamInformation _newYorkGiants;
        private readonly TeamInformation _washingtonRedskins;
        private readonly TeamInformation _philadelphiaEagles;
        private readonly TeamInformation _dallasCowboys;

        public NFC_East(int year)
        {
            _newYorkGiants = NewYorkGiants_NFC_East.GetNewYorkGiantsInformation(year);
            _washingtonRedskins = WashingtonRedskins_NFC_East.GetWashingtonRedskinsInformation(year);
            _philadelphiaEagles = PhiladelphiaEagles_NFC_East.GetPhiladelphiaEaglesInformation(year);
            _dallasCowboys = DallasCowboys_NFC_East.GetDallasCowboysInformation(year);
        }

        public List<TeamInformation> GetNFCEastTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _newYorkGiants,
                _washingtonRedskins,
                _philadelphiaEagles,
                _dallasCowboys
            };
            return result;
        }

        public DivisionRankingInformation GetNFCEastStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.NFC_East,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _newYorkGiants.RankingInformation,
                    _philadelphiaEagles.RankingInformation,
                    _washingtonRedskins.RankingInformation,
                    _dallasCowboys.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.NEW_YORK_GIANTS:
                    result = _newYorkGiants;
                    break;
                case Constants.WASHINGTON_REDSKINS:
                    result = _washingtonRedskins;
                    break;
                case Constants.PHILADELPHIA_EAGLES:
                    result = _philadelphiaEagles;
                    break;
                case Constants.DALLAS_COWBOYS:
                    result = _dallasCowboys;
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
                case Constants.NEW_YORK_GIANTS:
                    result = _newYorkGiants.SeasonSchedule;
                    break;
                case Constants.WASHINGTON_REDSKINS:
                    result = _washingtonRedskins.SeasonSchedule;
                    break;
                case Constants.PHILADELPHIA_EAGLES:
                    result = _philadelphiaEagles.SeasonSchedule;
                    break;
                case Constants.DALLAS_COWBOYS:
                    result = _dallasCowboys.SeasonSchedule;
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
                case Constants.NEW_YORK_GIANTS:
                    result = _newYorkGiants.Players;
                    break;
                case Constants.WASHINGTON_REDSKINS:
                    result = _washingtonRedskins.Players;
                    break;
                case Constants.PHILADELPHIA_EAGLES:
                    result = _philadelphiaEagles.Players;
                    break;
                case Constants.DALLAS_COWBOYS:
                    result = _dallasCowboys.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
