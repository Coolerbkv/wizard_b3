import { Component, ViewContainerRef } from '@angular/core';

@Component({
  selector: 'dynamic-ctrl',
  template: ''
})
export class DynamicCtrlComponent {
   constructor(public viewContainerRef: ViewContainerRef) { }
} 