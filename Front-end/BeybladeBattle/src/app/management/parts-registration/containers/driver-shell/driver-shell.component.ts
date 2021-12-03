import { Component, OnInit } from '@angular/core';
import { Driver } from 'src/app/app.models';

import * as fromBeybladeBattleManagement from '../../../../state';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-driver-shell',
  templateUrl: './driver-shell.component.html',
  styleUrls: ['./driver-shell.component.scss']
})
export class DriverShellComponent implements OnInit {

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit(){
  }

  saveDriver(driver: Driver) {
    this.store.dispatch(fromBeybladeBattleManagement.registerDriver({ driver }));
  }
}
