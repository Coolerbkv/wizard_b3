import { Component } from '@angular/core';
import { Form } from '../app-data/form';
import { WizardService } from '../app-services/wizard.service';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})

export class AppComponent {
  isLoadForms = false;
	constructor(private wizardService: WizardService) { }

  ngOnInit() {
    this.getForms();
  }; 

  getForms(): void { 
    this.wizardService.getForms()
        .subscribe(forms => {
          this.wizardService.localForms = forms
          this.isLoadForms = true;
          }
        )   
	};
}
