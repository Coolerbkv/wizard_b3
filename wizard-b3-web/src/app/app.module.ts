import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppComponent } from './app.component';
import { StringComponent } from './ctrl-templates/string/string.component';
import { SwitchboxComponent } from './ctrl-templates/switchbox/switchbox.component';


@NgModule({
  declarations: [
    AppComponent,
    StringComponent,
    SwitchboxComponent
  ],
  imports: [
    BrowserModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
