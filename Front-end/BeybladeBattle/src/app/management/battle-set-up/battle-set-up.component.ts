import { Component, Input, OnInit } from '@angular/core';
import { Beyblade, BeybladeBattle, Disk, Driver, /*Frame,*/ Layer } from 'src/app/app.models';
import { ManagementService } from '../management.service';

@Component({
  selector: 'app-battle-set-up',
  templateUrl: './battle-set-up.component.html',
  styleUrls: ['./battle-set-up.component.scss']
})
export class BattleSetUpComponent implements OnInit {
  @Input() layers: Layer[] | null = null;
  @Input() disks: Disk[] | null = null;
  //@Input() frames: Frame[] | undefined;
  @Input() drivers: Driver[] | null = null;
  alert: boolean = false;
  alertMessage: string = '';
  firstBeyblade: Beyblade = {
    layer: {
      id: 0,
      attack: 0,
      canUseDisk: true,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0
    },
    disk: {
      id: 0,
      attack: 0,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0
    },
    driver: {
      id: 0,
      attack: 0,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0,
      type: 0
    },
    attack: 0,
    defense: 0,
    stamina: 0,
    weight: 0
  };

  secondBeyblade: Beyblade = {
    layer: {
      id: 0,
      attack: 0,
      canUseDisk: true,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0
    },
    disk: {
      id: 0,
      attack: 0,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0
    },
    driver: {
      id: 0,
      attack: 0,
      defense: 0,
      name: '',
      stamina: 0,
      weight: 0,
      type: 0
    },
    attack: 0,
    defense: 0,
    stamina: 0,
    weight: 0
  };

  constructor(private managementService: ManagementService) { }

  ngOnInit() {
  }

  startBattle() {
    var beybladeBattle: BeybladeBattle = {
      firstBeyblade: this.firstBeyblade,
      secondBeyblade: this.secondBeyblade
    };


    this.managementService.battle(beybladeBattle).subscribe(
      message => this.alertMessage = message
    );
    
    debugger;
    this.alert = true;
  }

  closeAlert() {
    this.alert = false;
  }
}
