import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CommonModule } from '@angular/common';
import { NFLDivisionsComponent } from './nfldivisions/nfldivisions.component';
import { RosterComponent } from './roster/roster.component';
import { CoachesComponent } from './coaches/coaches.component';

const routes: Routes = [
  { path: '', component: NFLDivisionsComponent, pathMatch: 'full' },
  { path: 'roster', component: RosterComponent },
  { path: 'coaches', component: CoachesComponent }
]

@NgModule({
  declarations: [NFLDivisionsComponent, RosterComponent, CoachesComponent],
  imports: [
    CommonModule,
    RouterModule.forRoot(routes)
  ]
})
export class NFLDataModule { }
