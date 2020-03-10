import { Component, OnInit } from '@angular/core';
import { CommonService } from '../../_services/common.service';
import { Coach } from '../../ViewModels/NFLData';

@Component({
  selector: 'app-coaches',
  templateUrl: './coaches.component.html',
  styleUrls: ['./coaches.component.css']
})
export class CoachesComponent implements OnInit {

  constructor(private commonService: CommonService) { }

  teamName: string;
  teamCoaches: Coach[];

  ngOnInit(): void {
    this.commonService.currentTeamCoaches$.subscribe(coaches => this.teamCoaches = coaches);
  }
}
