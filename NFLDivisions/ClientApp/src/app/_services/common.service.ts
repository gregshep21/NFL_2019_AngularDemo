import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { DivisionTeamsInformation, TeamInformation, TeamMember, Coach } from '../ViewModels/NFLData';

@Injectable({
  providedIn: 'root'
})
export class CommonService {
  constructor() { }

  private teamNameSelected$ = new BehaviorSubject<string>("");
  private NFLDivisions$ = new BehaviorSubject<DivisionTeamsInformation[]>([]);
  private teamInformation$ = new BehaviorSubject<TeamInformation>(new TeamInformation());
  private teamMembers$ = new BehaviorSubject <TeamMember[]>([]);
  private teamColors$ = new BehaviorSubject <string[]>([]);
  private teamCoaches$ = new BehaviorSubject<Coach[]>([]);

  currentTeamName$ = this.teamNameSelected$.asObservable();
  currentNFLDivisions$ = this.NFLDivisions$.asObservable();
  currentTeamInformation$ = this.teamInformation$.asObservable();
  currentTeamMembers$ = this.teamMembers$.asObservable();
  currentTeamColors$ = this.teamColors$.asObservable();
  currentTeamCoaches$ = this.teamCoaches$.asObservable();

  updateTeamName(teamName: string) {
    this.teamNameSelected$.next(teamName);
  }

  updateNFLDivisions(nflDivisions: DivisionTeamsInformation[]) {
    this.NFLDivisions$.next(nflDivisions);
  }

  updateTeamInformation(teamInformation: TeamInformation) {
    this.teamInformation$.next(teamInformation);
  }

  updateTeamMembers(teamMembers: TeamMember[]) {
    this.teamMembers$.next(teamMembers);
  }

  updateTeamColors(teamColors: string[]) {
    this.teamColors$.next(teamColors);
  }

  updateTeamCoaches(teamCoaches: Coach[]) {
    this.teamCoaches$.next(teamCoaches);
  }
}
