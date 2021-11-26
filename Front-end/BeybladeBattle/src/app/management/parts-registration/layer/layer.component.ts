import { Component, OnInit } from '@angular/core';
import { Layer } from 'src/app/app.models';
import { ManagementService } from '../../management.service';

@Component({
  selector: 'app-layer',
  templateUrl: './layer.component.html',
  styleUrls: ['./layer.component.scss']
})
export class LayerComponent implements OnInit {
  layerName: string = '';
  layerAttack: number = 0;
  layerDefense: number = 0;
  layerStamina: number = 0;
  layerWeight: number = 0;
  alert: boolean = false;
  alertMessage: string = '';

  constructor(private managementService: ManagementService) { }

  ngOnInit() {
  }

  saveLayer() {
    var layer: Layer = {
      name: this.layerName,
      canUseDisk: true,
      attack: this.layerAttack,
      defense: this.layerDefense,
      stamina: this.layerStamina,
      weight: this.layerStamina,
      id: 0
    }

    this.managementService.registerLayer(layer).subscribe(() => {
      this.alertMessage = 'The layer has been saved.';
      this.alert = true;
    });
  }

  closeAlert() {
    this.alert = false;
  }
}
