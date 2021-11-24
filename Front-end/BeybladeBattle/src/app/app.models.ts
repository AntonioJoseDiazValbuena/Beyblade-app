export interface Beyblade {
    Layer: Layer,
    Disk: Disk,
    // Frame: Frame,
    Driver: Driver,
    Attack: number,
    Defense: number,
    Stamina: number,
    Weight: number
}

export interface Layer {
    Id: number,
    Name: string,
    CanUseDisk: boolean,
    Weight: number,
    Attack: number,
    Defense: number,
    Stamina: number,
}

export interface Disk {
    Id: number,
    Name: string,
    // CanUseFrame: boolean,
    Weight: number,
    Attack: number,
    Defense: number,
    Stamina: number,
}

/*export interface Frame {
    Id: number,
    Name: string,
    Weight: number
}*/

export interface Driver{
    Id: number,
    Name: string,
    Type: DriverType,
    Weight: number,
    Attack: number,
    Defense: number,
    Stamina: number,
}

export enum DriverType{
    Attack = 0,
    Defense = 1,
    Stamina = 2
}