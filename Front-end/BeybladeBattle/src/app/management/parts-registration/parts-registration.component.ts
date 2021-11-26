import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-parts-registration',
  templateUrl: './parts-registration.component.html',
  styleUrls: ['./parts-registration.component.scss']
})
export class PartsRegistrationComponent implements OnInit {
  registerLayer: boolean = false;
  registerDisk: boolean = false;
  registerDriver: boolean = false;
  
  constructor() { }

  ngOnInit() {
  }

  activateDeactivateRegisterLayer() {
    this.registerLayer = !this.registerLayer;
  }

  activateDeactivateRegisterDisk() {
    this.registerDisk = !this.registerDisk;
  }
  
  activateDeactivateRegisterDriver() {
    this.registerDriver = !this.registerDriver;
  }
}
