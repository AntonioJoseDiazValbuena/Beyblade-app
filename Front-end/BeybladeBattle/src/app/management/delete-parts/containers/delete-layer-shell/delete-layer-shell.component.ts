import { Component } from '@angular/core';
import { Store, select } from '@ngrx/store';
import * as fromBeybladeBattleManagement from '../../../../state';
import { Observable } from 'rxjs';
import { Layer } from 'src/app/app.models';

@Component({
  selector: 'app-delete-layer-shell',
  templateUrl: './delete-layer-shell.component.html',
  styleUrls: ['./delete-layer-shell.component.scss']
})
export class DeleteLayerShellComponent {
  layers$: Observable<Layer[]> | null = null;

  constructor(
    private store: Store<fromBeybladeBattleManagement.BeybladeBattleState>
  ) { }

  ngOnInit() {
    this.store.dispatch(fromBeybladeBattleManagement.obtainLayers());
    this.layers$ = this.store.pipe(select(fromBeybladeBattleManagement.getLayers));
  }

  deleteLayer(id: number) {
    this.store.dispatch(fromBeybladeBattleManagement.deleteLayer({ id }));
  }
}
