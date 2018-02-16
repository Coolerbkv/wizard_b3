import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';

import { AppComponent } from './app-template/app.component';
import { StringComponent } from './ctrl-templates/string/string.component';
import { SwitchboxComponent } from './ctrl-templates/switchbox/switchbox.component';


@NgModule({
  declarations: [
    AppComponent,
  	StringComponent,
    SwitchboxComponent
  ],
  imports: [
  	BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }