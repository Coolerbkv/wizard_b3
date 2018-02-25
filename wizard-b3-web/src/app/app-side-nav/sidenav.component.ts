import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, ViewChild, AfterViewInit, OnDestroy, Input } from '@angular/core';
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
  @Input() forms: Form[];
  mobileQuery: MediaQueryList;
 // forms = this.getForms();
  ctrlItems: CtrlItem[];
  ctrls: any;
  
  private _mobileQueryListener: () => void;

  // @ViewChild(CtrlDirective)
  // private ctrlDirective: CtrlDirective;

  @ViewChild(DynamicCtrlComponent)
  private dynamicCtrlComponent: DynamicCtrlComponent;

  ngOnInit() {
    this.ctrls = this.forms[0].controls;
  }; 

  // getForms(): void { 
  //   this.wizardService.getForms()
  //       .subscribe(forms => {
  //         return forms
  //         //this.forms = forms;
  //         //this.ctrls = forms[0].controls;
  //       })   
	// };

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
