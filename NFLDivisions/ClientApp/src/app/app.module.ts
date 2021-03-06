import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { CounterComponent } from './counter/counter.component';
import { NFLDivisionsComponent } from './nfldata/nfldivisions/nfldivisions.component';
import { NFLDataModule } from './nfldata/nfldata.module';

const routes: Routes = [
  { path: '', component: NFLDivisionsComponent, pathMatch: 'full' },
  { path: 'counter', component: CounterComponent }  
];

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    CounterComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    NFLDataModule,
    RouterModule.forRoot(routes),
    BrowserAnimationsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
