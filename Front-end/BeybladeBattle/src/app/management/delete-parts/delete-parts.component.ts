import { Component } from '@angular/core';

@Component({
  selector: 'app-delete-parts',
  templateUrl: './delete-parts.component.html',
  styleUrls: ['./delete-parts.component.scss']
})
export class DeletePartsComponent {
  deleteLayer: boolean = false;
  deleteDisk: boolean = false;
  deleteDriver: boolean = false;
  
  constructor() { }

  ngOnInit() {
  }

  activateDeactivateDeleteLayer() {
    this.deleteLayer = !this.deleteLayer;
  }

  activateDeactivateDeleteDisk() {
    this.deleteDisk = !this.deleteDisk;
  }
  
  activateDeactivateDeleteDriver() {
    this.deleteDriver = !this.deleteDriver;
  }
}
