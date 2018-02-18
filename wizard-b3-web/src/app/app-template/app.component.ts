import { Component } from '@angular/core';

import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';

import { WizardService } from '../app-services/wizard.service';

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
        .subscribe(forms => this.forms = forms);
  };

  title = 'eSign 3.0';
  formsLength = this.forms.length;
}
