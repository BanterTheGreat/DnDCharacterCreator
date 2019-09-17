import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { RouterModule } from '@angular/router';
import { ClassComponent } from './class/class.component';
import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { PointBuyComponent } from './pointbuy/pointbuy.component';
import { ItemsBackgroundComponent } from './itemsBackground/itemsbackground.component';
import { CreatorComponent } from './creator/creator.component';
import { SummaryComponent } from './summary/summary.component';
import { DataService } from './shared/dataService';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    PointBuyComponent,
    ClassComponent,
    ItemsBackgroundComponent,
    CreatorComponent,
    SummaryComponent,
    
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    ReactiveFormsModule,
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: CreatorComponent, pathMatch: 'full' },
      { path: 'creator', component: CreatorComponent },
      { path: 'pointbuy', component: PointBuyComponent },
      { path: 'class', component: ClassComponent },
      { path: 'equipment', component: ItemsBackgroundComponent }
    ])
  ],
  providers: [DataService],
  bootstrap: [AppComponent]
})
export class AppModule { }
