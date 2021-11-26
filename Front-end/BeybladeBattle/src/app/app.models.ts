export interface BeybladeBattle {
    firstBeyblade: Beyblade,
    secondBeyblade: Beyblade
}

export interface Beyblade {
    layer: Layer,
    disk: Disk,
    // Frame: Frame,
    driver: Driver,
    attack: number,
    defense: number,
    stamina: number,
    weight: number
}

export interface Layer {
    id: number,
    name: string,
    canUseDisk: boolean,
    weight: number,
    attack: number,
    defense: number,
    stamina: number,
}

export interface Disk {
    id: number,
    name: string,
    // CanUseFrame: boolean,
    weight: number,
    attack: number,
    defense: number,
    stamina: number,
}

/*export interface Frame {
    Id: number,
    Name: string,
    Weight: number
}*/

export interface Driver{
    id: number,
    name: string,
    type: DriverType,
    weight: number,
    attack: number,
    defense: number,
    stamina: number,
}

export enum DriverType{
    attack = 0,
    defense = 1,
    stamina = 2
}