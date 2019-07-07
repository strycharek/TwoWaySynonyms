import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SynonymAddComponent } from './synonym-add/synonym-add.component';
import { SynonymListComponent } from './synonym-list/synonym-list.component';
import { SynonymListService } from './synonym-list/synonym-list-service';

import { SynonymService } from './synonym.service';

@NgModule({
  declarations: [
    AppComponent,
    SynonymAddComponent,
    SynonymListComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [
    SynonymService,
    SynonymListService
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
