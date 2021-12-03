import { Action, createReducer, on } from "@ngrx/store";
import { BeybladeBattle, Disk, Driver, Layer } from "src/app/app.models";
import { obtainDisksSuccessful, obtainDriversSuccessful, obtainLayersSuccessful, startBattle } from "../actions/beyblade-battle.actions";

export interface BeybladeBattleState {
    layers: Layer[];
    disks: Disk[];
    drivers: Driver[];
    beybladeBattle: BeybladeBattle | null;
};

export const initialState: BeybladeBattleState = {
    beybladeBattle: null,
    disks: [],
    drivers: [],
    layers: []
};

const beybladeBattleReducer = createReducer(
    initialState,
    on(obtainLayersSuccessful, (state, action) => ({ ...state, layers: [...action.layers] })),
    on(obtainDisksSuccessful, (state, action) => ({ ...state, disks: [...action.disks] })),
    on(obtainDriversSuccessful, (state, action) => ({ ...state, drivers: [...action.drivers] })),
    on(startBattle, (state, action) => ({ ...state, beybladeBattle: { ...action.beybladeBattle } }))
);

export function reducer(state: BeybladeBattleState | undefined, action: Action) {
    return beybladeBattleReducer(state, action);
};