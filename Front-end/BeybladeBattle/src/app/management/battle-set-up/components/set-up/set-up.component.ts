import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Layer, Disk, Driver, BeybladeBattle } from 'src/app/app.models';

@Component({
  selector: 'app-set-up',
  templateUrl: './set-up.component.html',
  styleUrls: ['./set-up.component.scss']
})
export class SetUpComponent implements OnInit {
  @Input() layers: Layer[] | null = null;
  @Input() disks: Disk[] | null = null;
  //@Input() frames: Frame[] | undefined;
  @Input() drivers: Driver[] | null = null;
  @Output() battle = new EventEmitter<BeybladeBattle>();

  firstBeyblade: FormGroup;

  secondBeyblade: FormGroup;

  constructor(private fb: FormBuilder) {
    this.firstBeyblade = this.fb.group({
      layer: [{ id: 0, attack: 0, canUseDisk: true, defense: 0, name: '', stamina: 0, weight: 0 }],
      disk: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0 }],
      driver: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0, type: 0 }],
      attack: [0],
      defense: [0],
      stamina: [0],
      weight: [0]
    });
    this.secondBeyblade = this.fb.group({
      layer: [{ id: 0, attack: 0, canUseDisk: true, defense: 0, name: '', stamina: 0, weight: 0 }],
      disk: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0 }],
      driver: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0, type: 0 }],
      attack: [0],
      defense: [0],
      stamina: [0],
      weight: [0]
    });
  }

  ngOnInit() {
  }

  startBattle() {
    this.battle.emit({ firstBeyblade: { ...this.firstBeyblade.value }, secondBeyblade: { ...this.secondBeyblade.value } } as BeybladeBattle);
  }
}
