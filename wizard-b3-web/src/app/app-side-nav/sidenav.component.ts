import { MediaMatcher } from '@angular/cdk/layout';
import { ChangeDetectorRef, Component, ViewChild, AfterViewInit, OnDestroy, Input } from '@angular/core';
//import { DynamicCtrlComponent } from "../ctrl-dynamic/dynamic.component";

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
  ctrlItems: CtrlItem[];
  selectForm: Form;

  private _mobileQueryListener: () => void;

  // @ViewChild(DynamicCtrlComponent)
  // private dynamicCtrlComponent: DynamicCtrlComponent;

  ngOnInit() {
    this.selectForm = this.forms[0];
  };

  onSelect(form: Form, snav: any): void {
    this.selectForm = form;
    snav.toggle();
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
