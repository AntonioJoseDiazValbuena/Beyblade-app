import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Driver } from 'src/app/app.models';

@Component({
  selector: 'app-driver',
  templateUrl: './driver.component.html',
  styleUrls: ['./driver.component.scss']
})
export class DriverComponent implements OnInit {
  @Output() saveDriver = new EventEmitter<Driver>();

  driver: FormGroup;

  constructor(private fb: FormBuilder) { 
    this.driver = this.fb.group({
      name: [''],
      attack: [0],
      defense: [0],
      stamina: [0],
      weight: [0],
      type: [0]
    });
  }

  ngOnInit() {
  }

  save() {
    this.saveDriver.emit({ ...this.driver.value } as Driver);
  }
}
