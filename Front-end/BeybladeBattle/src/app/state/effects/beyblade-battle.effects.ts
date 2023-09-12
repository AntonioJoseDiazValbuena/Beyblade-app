import { Injectable } from "@angular/core";
import { ManagementService } from "src/app/management/management.service";
import { Actions, createEffect, ofType, concatLatestFrom } from '@ngrx/effects';
import * as battleActions from "../actions/beyblade-battle.actions";
import { mergeMap, map, switchMap, tap } from 'rxjs/operators';
import { BeybladeBattleState } from "../reducers/beyblade-battle.reducer";
import { Store } from "@ngrx/store";
import Swal from "sweetalert2";

@Injectable()
export class BeybladeBattleEffects {
    constructor(
        private actions$: Actions,
        private managementService: ManagementService,
        private store: Store<BeybladeBattleState>
    ) { }

    obtainLayers$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.obtainLayers),
        mergeMap(() => this.managementService.obtainLayers()
            .pipe(
                map(layers => battleActions.obtainLayersSuccessful({ layers }))
            )
        )
    ));

    obtainDisks$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.obtainDisks),
        mergeMap(() => this.managementService.obtainDisks()
            .pipe(
                map(disks => battleActions.obtainDisksSuccessful({ disks }))
            )
        )
    ));

    obtainDrivers$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.obtainDrivers),
        mergeMap(() => this.managementService.obtainDrivers()
            .pipe(
                map(drivers => battleActions.obtainDriversSuccessful({ drivers }))
            )
        )
    ));

    registerLayer$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerLayer),
        mergeMap((action) => this.managementService.registerLayer(action.layer)
            .pipe(
                map(() => battleActions.registerLayerSuccessful())
            )
        )
    ));

    deleteLayer$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteLayer),
        mergeMap((action) => this.managementService.deleteLayer(action.id)
            .pipe(
                switchMap(() => [battleActions.deleteLayerSuccesful(), battleActions.obtainLayers()])
            ))
    ));

    registerDisk$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerDisk),
        mergeMap((action) => this.managementService.registerDisk(action.disk)
            .pipe(
                map(() => battleActions.registerDiskSuccessful())
            )
        )
    ));

    deleteDisk$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteDisk),
        mergeMap((action) => this.managementService.deleteDisk(action.id)
            .pipe(
                switchMap(() => [battleActions.deleteDiskSuccesful(), battleActions.obtainDisks()])
            ))
    ));

    registerDriver$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerDriver),
        mergeMap((action) => this.managementService.registerDriver(action.driver)
            .pipe(
                map(() => battleActions.registerDriverSuccessful())
            )
        )
    ));

    deleteDriver$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteDriver),
        mergeMap((action) => this.managementService.deleteDriver(action.id)
            .pipe(
                switchMap(() => [battleActions.deleteDriverSuccesful(), battleActions.obtainDrivers()])
            ))
    ));

    startBattle$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.startBattle),
        mergeMap((action) => this.managementService.battle(action.beybladeBattle)
            .pipe(
                map(message => battleActions.setWinner({ message }))
            )
        )
    ));

    setWinner$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.setWinner),
        tap((action) => Swal.fire({
            title: 'Success!',
            text: action.message,
            icon: 'success'
        })
        )
    ), { dispatch: false });

    registerLayerSuccessful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerLayerSuccessful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The layer has been registered',
            icon: 'success'
        }
        ))
    ), { dispatch: false });

    deleteLayerSuccesful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteLayerSuccesful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The layer has been deleted',
            icon: 'success'
        })
        )
    ), { dispatch: false });

    deleteDiskSuccesful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteDiskSuccesful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The disk has been deleted',
            icon: 'success'
        })
        )
    ), { dispatch: false });

    deleteDriverSuccesful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.deleteDriverSuccesful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The driver has been deleted',
            icon: 'success'
        })
        )
    ), { dispatch: false });

    registerDiskSuccessful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerDiskSuccessful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The disk has been registered',
            icon: 'success'
        })
        )
    ), { dispatch: false });

    registerDriverSuccessful$ = createEffect(() => this.actions$.pipe(
        ofType(battleActions.registerDriverSuccessful),
        tap(() => Swal.fire({
            title: 'Success!',
            text: 'The driver has been registered',
            icon: 'success'
        })
        )
    ), { dispatch: false });
}