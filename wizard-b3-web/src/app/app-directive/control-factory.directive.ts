import { Directive, ViewContainerRef } from '@angular/core';

@Directive({ 
   selector: '[ctrl]' 
})
export class CtrlDirective {
   constructor(public viewContainerRef: ViewContainerRef) { }
} 