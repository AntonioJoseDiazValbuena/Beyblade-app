import { Component, OnInit } from '@angular/core';
import { Layer } from 'src/app/app.models';

import * as fromBeybladeBattleManagement from '../../../../state';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-layer-shell',
  templateUrl: './layer-shell.component.html',
  styleUrls: ['./layer-shell.component.scss']
})
export class LayerShellComponent implements OnInit {

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
  }

  saveLayer(layer: Layer) {
    this.store.dispatch(fromBeybladeBattleManagement.registerLayer({ layer }));
  }
}
