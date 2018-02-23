import { Component, OnInit, ViewContainerRef, Input } from '@angular/core';
import { CtrlInterface } from '../../app-data/ctrl-interface';

@Component({
  selector: 'ctrl-String',
  templateUrl: './string.component.html',
  styleUrls: ['./string.component.css']
})


export class StringComponent implements CtrlInterface, OnInit {
	@Input() ctrl: any;
  controlId: "";
  constructor(public viewContainerRef: ViewContainerRef) { }

  // if (ctrl){
  //   this.controlId = this.ctrl.controlId;
  // }

  ngOnInit() {
  }

}
