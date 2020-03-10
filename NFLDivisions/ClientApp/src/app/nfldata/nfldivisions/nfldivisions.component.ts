import { Component, OnInit, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CommonService } from '../../_services/common.service';
import { DivisionTeamsInformation, TeamInformation, TeamMember, Coach } from '../../ViewModels/NFLData';

@Component({
  selector: 'app-nfldivisions',
  templateUrl: './nfldivisions.component.html',
  styleUrls: ['./nfldivisions.component.css']
})
export class NFLDivisionsComponent implements OnInit {

  NFLDivisions: DivisionTeamsInformation[];
  teamColors: string[];
  teamName: string;
  teamInformationRequested: boolean = false;

  constructor(private commonService: CommonService, _http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
      _http.get<DivisionTeamsInformation[]>(baseUrl + 'nfl').subscribe(result => {
        this.NFLDivisions = result;
      },
        error => console.error(error)
      );
  }

  showTeamInformation(teamName, teamDivision) {
    this.teamInformationRequested = false;
    for (let division of this.NFLDivisions) {
      if (division.divisionName === teamDivision) {
        for (let team of division.nflDivisionTeamsInformation) {
          if (team.teamName == teamName) {
            this.teamColors = team.colors;
            this.teamInformationRequested = true;
            this.commonService.updateTeamName(teamName);
            this.commonService.updateTeamInformation(team);
            this.commonService.updateTeamMembers(team.players);
            this.commonService.updateTeamColors(team.colors);
            this.commonService.updateTeamCoaches(team.coaches);
          }
        }
      }
    }
  }

  resetToInitialStart() {
    this.teamInformationRequested = false;
    this.commonService.updateTeamName("");
    this.commonService.updateTeamInformation(new TeamInformation());
    this.commonService.updateTeamMembers([]);
    this.commonService.updateTeamColors([]);
    this.commonService.updateTeamCoaches([]);
  }

  ngOnInit() {
    this.commonService.currentTeamName$.subscribe(name => this.teamName = name);
  }
}
