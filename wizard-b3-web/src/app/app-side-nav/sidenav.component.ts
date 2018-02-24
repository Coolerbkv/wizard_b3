import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, ViewChild, AfterViewInit, OnDestroy } from '@angular/core';
import { DynamicCtrlComponent } from "../ctrl-dynamic/dynamic.component";

//import { CtrlDirective } from '../app-directive/control-factory.directive';
import { WizardService } from '../app-services/wizard.service';
import { StringComponent } from '../ctrl-templates/string/string.component';
import { CtrlItem } from '../app-data/ctrl-item';
import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';

@Component({
  selector: 'sidenav-responsive',
  templateUrl: './sidenav.component.html',
  styleUrls: ['./sidenav.component.css']
})
export class SidenavComponent {
  mobileQuery: MediaQueryList;
  forms: Form[];
  ctrlItems: CtrlItem[];
  ctrls: Ctrl[];

  private _mobileQueryListener: () => void;

  // @ViewChild(CtrlDirective)
  // private ctrlDirective: CtrlDirective;

  @ViewChild(DynamicCtrlComponent)
  private dynamicCtrlComponent: DynamicCtrlComponent;

  ngOnInit() {
    this.getForms();
  }; 

  getForms(): void { 
    this.wizardService.getForms()
        .subscribe(forms => {
          this.forms = forms;
          this.ctrls = forms[0].controls;
          //this.renderCtrls();
        })   
	};

	renderCtrls(): void {
    let ctrlItem = new CtrlItem(StringComponent, this.forms[0].controls[0]);
    
    this.wizardService.loadComponent(this.dynamicCtrlComponent.viewContainerRef, ctrlItem);
    
    this.wizardService.loadComponent(this.dynamicCtrlComponent.viewContainerRef, new CtrlItem(StringComponent, this.forms[0].controls[1]));
	}

  constructor(private wizardService: WizardService,
              changeDetectorRef: ChangeDetectorRef, 
              media: MediaMatcher) {
    this.mobileQuery = media.matchMedia('(max-width: 600px)');
    this._mobileQueryListener = () => changeDetectorRef.detectChanges();
    this.mobileQuery.addListener(this._mobileQueryListener);
  }

  ngOnDestroy(): void {
    this.mobileQuery.removeListener(this._mobileQueryListener);
  }
}
