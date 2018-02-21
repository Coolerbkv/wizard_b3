import { Component, ViewChild, AfterViewInit, OnDestroy } from '@angular/core';

import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';
import { NgIf } from '@angular/common';

import { CtrlDirective } from '../app-directive/control-factory.directive';
import { DynamicCtrlComponent } from "../dynamic/dynamic.component";

import { WizardService } from '../app-services/wizard.service';
import { StringComponent } from '../ctrl-templates/string/string.component';
import { CtrlItem } from '../app-data/ctrl-item';

@Component({
  selector: 'app-root',
  templateUrl: 'app.component.html',
  styleUrls: ['app.component.css']
})

export class AppComponent {
	forms: Form[];
	ctrlItems: CtrlItem[];

  @ViewChild(CtrlDirective)
  private ctrlDirective: CtrlDirective;

  @ViewChild(DynamicCtrlComponent)
  private dynamicCtrlComponent: DynamicCtrlComponent;

	constructor(private wizardService: WizardService) { }

  ngOnInit() {
    this.getForms();
  }; 

  getForms(): void { 
    this.wizardService.getForms()
        .subscribe(forms => {
          this.forms = [forms[0]];
          this.renderCtrls();
        })   
	};

	renderCtrls(): void {
    let ctrlItem = new CtrlItem(StringComponent, this.forms[0].controls[0]);
    
		this.wizardService.loadComponent(this.dynamicCtrlComponent.viewContainerRef, ctrlItem);
	}

	title = 'eSign 3.0';
}
