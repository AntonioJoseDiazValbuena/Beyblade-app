import { createFeatureSelector, createSelector } from "@ngrx/store";
import { BeybladeBattleState } from "../reducers/beyblade-battle.reducer";

const getBeybladeBattleFeature = createFeatureSelector<BeybladeBattleState>('beybladeBattleManagement');

export const getLayers = createSelector(
    getBeybladeBattleFeature,
    state => state.layers
);

export const getDisks = createSelector(
    getBeybladeBattleFeature,
    state => state.disks
);

export const getDrivers = createSelector(
    getBeybladeBattleFeature,
    state => state.drivers
);

export const getBeybladeBattle = createSelector(
    getBeybladeBattleFeature,
    state => state.beybladeBattle
);