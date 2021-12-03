import { Component, OnInit } from '@angular/core';
import { Disk } from 'src/app/app.models';

import * as fromBeybladeBattleManagement from '../../../../state';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-disk-shell',
  templateUrl: './disk-shell.component.html',
  styleUrls: ['./disk-shell.component.scss']
})
export class DiskShellComponent implements OnInit {

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
  }

  saveDisk(disk: Disk) {
    this.store.dispatch(fromBeybladeBattleManagement.registerDisk({ disk }));
  }
}
