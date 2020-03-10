import { Component, OnInit } from '@angular/core';
import { CommonService } from '../_services/common.service';
import { TeamInformation } from '../ViewModels/NFLData';

@Component({
  selector: 'app-nav-menu',
  templateUrl: './nav-menu.component.html',
  styleUrls: ['./nav-menu.component.css']
})
export class NavMenuComponent implements OnInit {

  constructor(private commonService: CommonService) { }

  teamName: string;
  isExpanded = false;

  collapse() {
    this.isExpanded = false;
  }

  toggle() {
    this.isExpanded = !this.isExpanded;
  }

  ngOnInit() {
    this.commonService.currentTeamName$.subscribe(name => this.teamName = name)
  }

  reset() {
    this.commonService.updateTeamName("");
    this.commonService.updateTeamInformation(new TeamInformation());
    this.commonService.updateTeamMembers([]);
    this.commonService.updateTeamColors([]);
    this.commonService.updateTeamCoaches([]);
  }
}
