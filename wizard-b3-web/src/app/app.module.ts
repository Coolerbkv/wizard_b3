import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule }    from '@angular/common/http';

import { AppComponent } from './app-template/app.component';
import { StringComponent } from './ctrl-templates/string/string.component';
import { SwitchboxComponent } from './ctrl-templates/switchbox/switchbox.component';

import { WizardService } from './app-services/wizard.service';
import { CtrlDirective } from './app-directive/control-factory.directive';
import { DynamicCtrlComponent } from './dynamic/dynamic.component';

@NgModule({
  declarations: [
    AppComponent,
    CtrlDirective,
  	StringComponent,
    SwitchboxComponent,
    DynamicCtrlComponent    
  ],
  imports: [
  	BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  entryComponents: [ 
     StringComponent,
     SwitchboxComponent
  ],
  providers: [WizardService],
  bootstrap: [AppComponent]
})
export class AppModule { }