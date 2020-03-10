import { Component, OnInit } from '@angular/core';
import { CommonService } from '../../_services/common.service';
import { TeamMember } from '../../ViewModels/NFLData';

@Component({
  selector: 'app-roster',
  templateUrl: './roster.component.html',
  styleUrls: ['./roster.component.css']
})
export class RosterComponent implements OnInit {

  constructor(private commonService: CommonService) { }
  teamName: string;
  teamMembers: TeamMember[];

  ngOnInit(): void {
    this.commonService.currentTeamName$.subscribe(name => this.teamName = name);
    this.commonService.currentTeamMembers$.subscribe(roster => this.teamMembers = roster);
  }
}
