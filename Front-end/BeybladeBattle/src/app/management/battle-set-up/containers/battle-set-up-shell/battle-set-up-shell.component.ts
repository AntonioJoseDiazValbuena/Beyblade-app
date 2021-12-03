import { Component, OnInit } from '@angular/core';
import { Store, select } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Layer, Disk, Driver, BeybladeBattle } from 'src/app/app.models';
import * as fromBeybladeBattleManagement from '../../../../state';

@Component({
  selector: 'app-battle-set-up-shell',
  templateUrl: './battle-set-up-shell.component.html',
  styleUrls: ['./battle-set-up-shell.component.scss']
})
export class BattleSetUpShellComponent implements OnInit {
  layers$: Observable<Layer[]> | null = null;
  disks$: Observable<Disk[]> | null = null;
  // frames$: Observable<Frame[]> | undefined;
  drivers$: Observable<Driver[]> | null = null;

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
    this.executeActions();
    this.initializeFetchStore();
  }

  executeActions() {
    this.store.dispatch(fromBeybladeBattleManagement.obtainLayers());
    this.store.dispatch(fromBeybladeBattleManagement.obtainDisks());
    this.store.dispatch(fromBeybladeBattleManagement.obtainDrivers());
  }

  initializeFetchStore() {
    this.layers$ = this.store.pipe(select(fromBeybladeBattleManagement.getLayers));
    this.disks$ = this.store.pipe(select(fromBeybladeBattleManagement.getDisks));
    this.drivers$ = this.store.pipe(select(fromBeybladeBattleManagement.getDrivers));
  }

  battle(beybladeBattle: BeybladeBattle) {
    this.store.dispatch(fromBeybladeBattleManagement.startBattle({ beybladeBattle }));
  }
}
