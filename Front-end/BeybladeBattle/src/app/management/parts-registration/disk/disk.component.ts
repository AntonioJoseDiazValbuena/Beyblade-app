import { Component, OnInit } from '@angular/core';
import { Disk } from 'src/app/app.models';
import { ManagementService } from '../../management.service';

@Component({
  selector: 'app-disk',
  templateUrl: './disk.component.html',
  styleUrls: ['./disk.component.scss']
})
export class DiskComponent implements OnInit {
  diskName: string = '';
  diskAttack: number = 0;
  diskDefense: number = 0;
  diskStamina: number = 0;
  diskWeight: number = 0;
  alert: boolean = false;
  alertMessage: string = '';

  constructor(private managementService: ManagementService) { }

  ngOnInit() {
  }

  saveDisk() {
    var disk: Disk = {
      name: this.diskName,
      attack: this.diskAttack,
      defense: this.diskDefense,
      stamina: this.diskStamina,
      weight: this.diskStamina,
      id: 0
    }

    this.managementService.registerDisk(disk).subscribe(() => {
      this.alertMessage = 'The driver has been saved.';
      this.alert = true;
    });
  }

  closeAlert() {
    this.alert = false;
  }
}
