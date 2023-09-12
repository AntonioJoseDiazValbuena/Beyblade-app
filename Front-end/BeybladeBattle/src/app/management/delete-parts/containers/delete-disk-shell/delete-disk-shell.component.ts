import { Component } from '@angular/core';
import { Store, select } from '@ngrx/store';
import * as fromBeybladeBattleManagement from '../../../../state';
import { Disk } from 'src/app/app.models';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-delete-disk-shell',
  templateUrl: './delete-disk-shell.component.html',
  styleUrls: ['./delete-disk-shell.component.scss']
})
export class DeleteDiskShellComponent {
  disks$: Observable<Disk[]> | null = null;

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
    this.store.dispatch(fromBeybladeBattleManagement.obtainDisks());
    this.disks$ = this.store.pipe(select(fromBeybladeBattleManagement.getDisks));
  }

  deleteDisk(id: number) {
    this.store.dispatch(fromBeybladeBattleManagement.deleteDisk({ id }));
  }
}
