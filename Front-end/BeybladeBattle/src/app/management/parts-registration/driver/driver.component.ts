import { Component, OnInit } from '@angular/core';
import { Driver, DriverType } from 'src/app/app.models';
import { ManagementService } from '../../management.service';

@Component({
  selector: 'app-driver',
  templateUrl: './driver.component.html',
  styleUrls: ['./driver.component.scss']
})
export class DriverComponent implements OnInit {
  driverName: string = '';
  driverAttack: number = 0;
  driverDefense: number = 0;
  driverStamina: number = 0;
  driverWeight: number = 0;
  driverType: number = 0;
  alert: boolean = false;
  alertMessage: string = '';

  constructor(private managementService: ManagementService) { }

  ngOnInit() {
  }

  saveDriver() {
    var driver: Driver = {
      name: this.driverName,
      attack: this.driverAttack,
      defense: this.driverDefense,
      stamina: this.driverStamina,
      weight: this.driverStamina,
      type: this.driverType,
      id: 0
    }

    this.managementService.registerDriver(driver).subscribe(() => {
      this.alertMessage = 'The driver has been saved.';
      this.alert = true;
    });
  }

  closeAlert() {
    this.alert = false;
  }
}
