import { createAction, props } from "@ngrx/store";
import { BeybladeBattle, Disk, Driver, Layer } from "src/app/app.models";

const origin = '[BeybladeBattle]';

export const obtainLayers = createAction(
    `${origin} Obtain layers`
);

export const obtainLayersSuccessful = createAction(
    `${origin} Obtain layers successful`,
    props<{ layers: Layer[] }>()
);

export const obtainDisks = createAction(
    `${origin} Obtain Disks`
);

export const obtainDisksSuccessful = createAction(
    `${origin} Obtain Disks successful`,
    props<{ disks: Disk[] }>()
);

export const obtainDrivers = createAction(
    `${origin} Obtain drivers`
);

export const obtainDriversSuccessful = createAction(
    `${origin} Obtain drivers successful`,
    props<{ drivers: Driver[] }>()
);

export const registerLayer = createAction(
    `${origin} Register layer`,
    props<{ layer: Layer }>()
);

export const registerLayerSuccessful = createAction(
    `${origin} Register layer successful`
);

export const deleteLayer = createAction(
    `${origin} Delete layer`,
    props<{ id: number }>()
);

export const deleteLayerSuccesful = createAction(
    `${origin} Delete layer succesful`
);

export const registerDisk = createAction(
    `${origin} Register disk`,
    props<{ disk: Disk }>()
);

export const registerDiskSuccessful = createAction(
    `${origin} Register disk successful`
);
export const deleteDisk = createAction(
    `${origin} Delete Disk`,
    props<{ id: number }>()
);

export const deleteDiskSuccesful = createAction(
    `${origin} Delete disk succesful`
);

export const registerDriver = createAction(
    `${origin} Register driver`,
    props<{ driver: Driver }>()
);

export const registerDriverSuccessful = createAction(
    `${origin} Register driver successful`
);

export const deleteDriver = createAction(
    `${origin} Delete Driver`,
    props<{ id: number }>()
);

export const deleteDriverSuccesful = createAction(
    `${origin} Delete driver succesful`
);


export const startBattle = createAction(
    `${origin} Start battle`,
    props<{ beybladeBattle: BeybladeBattle }>()
);

export const setWinner = createAction(
    `${origin} Set winner`,
    props<{ message: string }>()
);