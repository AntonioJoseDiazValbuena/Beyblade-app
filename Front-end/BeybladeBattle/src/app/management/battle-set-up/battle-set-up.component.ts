import { Component, Input, OnInit } from '@angular/core';
import { select, Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Beyblade, BeybladeBattle, Disk, Driver, /*Frame,*/ Layer } from 'src/app/app.models';

@Component({
  selector: 'app-battle-set-up',
  templateUrl: './battle-set-up.component.html',
  styleUrls: ['./battle-set-up.component.scss']
})
export class BattleSetUpComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }
}
