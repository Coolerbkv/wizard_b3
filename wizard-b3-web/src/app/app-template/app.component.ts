import { Component } from '@angular/core';

import { Ctrl } from '../app-data/ctrl';
import { CTRLS } from '../app-data/ctrls';

import { WizardService } from '../app-services/wizard.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})

export class AppComponent {
	ctrls: Ctrl[];

	constructor(private wizardService: WizardService) { }

  ngOnInit() {
    this.getForms();
  };

  getForms(): void {
    this.wizardService.getForms()
        .subscribe(ctrls => this.ctrls = ctrls);
  };

  title = 'eSign 3.0';
}
