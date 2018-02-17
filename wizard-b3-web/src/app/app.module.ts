import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';

import { AppComponent } from './app-template/app.component';
import { StringComponent } from './ctrl-templates/string/string.component';
import { SwitchboxComponent } from './ctrl-templates/switchbox/switchbox.component';

import { WizardService } from './app-services/wizard.service';

@NgModule({
  declarations: [
    AppComponent,
  	StringComponent,
    SwitchboxComponent
  ],
  imports: [
  	BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [WizardService],
  bootstrap: [AppComponent]
})
export class AppModule { }