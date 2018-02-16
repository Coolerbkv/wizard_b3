import { Component, OnInit } from '@angular/core';
import { Ctrl } from '../../app-data/ctrl';

@Component({
  selector: 'ctrl-string',
  templateUrl: './string.component.html',
  styleUrls: ['./string.component.css']
})
export class StringComponent implements OnInit {
  ctrl: Ctrl = {
	controlId: "first_id",
	q: "siski",
	value: ""
  };

  constructor() { }

  ngOnInit() {
  }

}
