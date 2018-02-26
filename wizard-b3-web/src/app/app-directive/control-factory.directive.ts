import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, ViewChild, AfterViewInit, OnDestroy, Directive, ViewContainerRef, Input, OnInit } from '@angular/core';
import { WizardService } from '../app-services/wizard.service';
import { StringComponent } from '../ctrl-templates/string/string.component';
import { CtrlItem } from '../app-data/ctrl-item';
import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';

@Directive({ 
   selector: '[control]' 
})

export class CtrlDirective implements OnInit {
    @Input() controlInfo: any;  
    @ViewChild(CtrlDirective)

    private ctrlDirective: CtrlDirective;

    constructor(public viewContainerRef: ViewContainerRef,
               private wizardService: WizardService) { }
   
    ngOnInit() {
        let ctrlItem = new CtrlItem(StringComponent, this.controlInfo);
        
        this.wizardService.loadComponent(this.viewContainerRef, ctrlItem);
   }
} 