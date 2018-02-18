import { Component } from '@angular/core';

import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';
import { NgIf } from '@angular/common';

import { WizardService } from '../app-services/wizard.service';
import { StringComponent } from '../ctrl-templates/string/string';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})

export class AppComponent {
	forms: Form[];
	
	constructor(private wizardService: WizardService) { }

  ngOnInit() {
    this.getForms();
  };

  getForms(): void {
    this.wizardService.getForms()
        .subscribe(forms => this.forms = [forms[0]])   
	}
	title = 'eSign 3.0';
}
