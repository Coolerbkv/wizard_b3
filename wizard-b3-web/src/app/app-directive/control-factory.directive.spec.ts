import { CtrlDirective } from './control-factory.directive';
import { ViewContainerRef } from '@angular/core';
import { WizardService } from '../app-services/wizard.service';

describe('CtrlDirective', () => {
  it('should create an instance', () => {
    let viewContainerRef: ViewContainerRef
    let wizardService: WizardService;
    const directive = new CtrlDirective(viewContainerRef, wizardService);
    expect(directive).toBeTruthy();
  });
});
