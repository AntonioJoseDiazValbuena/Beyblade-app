import { Component } from '@angular/core';
import { Store, select } from '@ngrx/store';
import * as fromBeybladeBattleManagement from '../../../../state';
import { Driver } from 'src/app/app.models';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-delete-driver-shell',
  templateUrl: './delete-driver-shell.component.html',
  styleUrls: ['./delete-driver-shell.component.scss']
})
export class DeleteDriverShellComponent {
  drivers$: Observable<Driver[]> | null = null;

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
    this.store.dispatch(fromBeybladeBattleManagement.obtainDrivers());
    this.drivers$ = this.store.pipe(select(fromBeybladeBattleManagement.getDrivers));
  }

  deleteDriver(id: number) {
    this.store.dispatch(fromBeybladeBattleManagement.deleteDriver({ id }));
  }
}
