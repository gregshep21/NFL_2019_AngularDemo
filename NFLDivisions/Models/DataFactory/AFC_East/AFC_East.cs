
using System.Collections.Generic;

namespace SPA_Angular_Demo.Models.DataFactory
{
    public class AFC_East
    {
        private readonly TeamInformation _newEnglandPatriots;
        private readonly TeamInformation _miamiDolphins;
        private readonly TeamInformation _buffaloBills;
        private readonly TeamInformation _newYorkJets;


        public AFC_East(int year)
        {
            _newEnglandPatriots = NewEnglandPatriots_AFC_East.GetNewEnglandPatriotsInformation(year);
            _miamiDolphins = MiamiDolphins_AFC_East.GetMiamiDolphinsInformation(year);
            _buffaloBills = BuffaloBills_AFC_East.GetBuffaloBillsInformation(year);
            _newYorkJets = NewYorkJets_AFC_East.GetNewYorkJetsInformation(year);
        }

        public List<TeamInformation> GetAFCEastTeams(int year)
        {
            var result = new List<TeamInformation>
            {
                _newEnglandPatriots,
                _miamiDolphins,
                _buffaloBills,
                _newYorkJets
            };
            return result;
        }

        public DivisionRankingInformation GetAFCEastStandings()
        {
            return new DivisionRankingInformation
            {
                DivisionName = Constants.AFC_East,
                DivisionRanks = new List<TeamRankingInformation>
                {
                    _newEnglandPatriots.RankingInformation,
                    _miamiDolphins.RankingInformation,
                    _buffaloBills.RankingInformation,
                    _newYorkJets.RankingInformation
                }
            };
        }

        public TeamInformation GetTeamInformation(string teamName)
        {
            TeamInformation result;
            switch (teamName.Trim().ToUpper())
            {
                case Constants.NEW_ENGLAND_PATRIOTS:
                    result = _newEnglandPatriots;
                    break;
                case Constants.MIAMI_DOLPHINS:
                    result = _miamiDolphins;
                    break;
                case Constants.BUFFALO_BILLS:
                    result = _buffaloBills;
                    break;
                case Constants.NEW_YORK_JETS:
                    result = _newYorkJets;
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
                case Constants.NEW_ENGLAND_PATRIOTS:
                    result = _newEnglandPatriots.SeasonSchedule;
                    break;
                case Constants.MIAMI_DOLPHINS:
                    result = _miamiDolphins.SeasonSchedule;
                    break;
                case Constants.BUFFALO_BILLS:
                    result = _buffaloBills.SeasonSchedule;
                    break;
                case Constants.NEW_YORK_JETS:
                    result = _newYorkJets.SeasonSchedule;
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
                case Constants.NEW_ENGLAND_PATRIOTS:
                    result = _newEnglandPatriots.Players;
                    break;
                case Constants.MIAMI_DOLPHINS:
                    result = _miamiDolphins.Players;
                    break;
                case Constants.BUFFALO_BILLS:
                    result = _buffaloBills.Players;
                    break;
                case Constants.NEW_YORK_JETS:
                    result = _newYorkJets.Players;
                    break;
                default:
                    result = new List<TeamMember>();
                    break;
            }
            return result;
        }
    }
}
