import { Component, Input, OnInit } from '@angular/core';
import { Disk, Driver, /*Frame,*/ Layer } from 'src/app/app.models';

@Component({
  selector: 'app-battle-set-up',
  templateUrl: './battle-set-up.component.html',
  styleUrls: ['./battle-set-up.component.scss']
})
export class BattleSetUpComponent implements OnInit {
  @Input() layers: Layer[] | undefined;
  @Input() disks: Disk[] | undefined;
  //@Input() frames: Frame[] | undefined;
  @Input() drivers: Driver[] | undefined;

  constructor() { }

  ngOnInit() {
  }

}
