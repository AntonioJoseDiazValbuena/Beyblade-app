import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './management/home-page/home-page.component';
import { PartsRegistrationComponent } from './management/parts-registration/parts-registration.component';
import { BattleSetUpComponent } from './management/battle-set-up/battle-set-up.component';
import { LayerComponent } from './management/parts-registration/components/layer/layer.component';
import { DiskComponent } from './management/parts-registration/components/disk/disk.component';
import { DriverComponent } from './management/parts-registration/components/driver/driver.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { StoreModule } from '@ngrx/store';
import { EffectsModule } from '@ngrx/effects';
import { LayerShellComponent } from './management/parts-registration/containers/layer-shell/layer-shell.component';
import { DiskShellComponent } from './management/parts-registration/containers/disk-shell/disk-shell.component';
import { DriverShellComponent } from './management/parts-registration/containers/driver-shell/driver-shell.component';

import * as fromBeybladeBattleManagement from './state';
import { BattleSetUpShellComponent } from './management/battle-set-up/containers/battle-set-up-shell/battle-set-up-shell.component';
import { SetUpComponent } from './management/battle-set-up/components/set-up/set-up.component';
import { DeletePartsComponent } from './management/delete-parts/delete-parts.component';
import { DeleteLayerShellComponent } from './management/delete-parts/containers/delete-layer-shell/delete-layer-shell.component';
import { DeleteDriverShellComponent } from './management/delete-parts/containers/delete-driver-shell/delete-driver-shell.component';
import { DeleteDiskShellComponent } from './management/delete-parts/containers/delete-disk-shell/delete-disk-shell.component';
import { DeleteDiskComponent } from './management/delete-parts/components/delete-disk/delete-disk.component';
import { DeleteDriverComponent } from './management/delete-parts/components/delete-driver/delete-driver.component';
import { DeleteLayerComponent } from './management/delete-parts/components/delete-layer/delete-layer.component';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PartsRegistrationComponent,
    BattleSetUpComponent,
    LayerComponent,
    DiskComponent,
    DriverComponent,
    LayerShellComponent,
    DiskShellComponent,
    DriverShellComponent,
    BattleSetUpShellComponent,
    SetUpComponent,
    DeletePartsComponent,
    DeleteLayerShellComponent,
    DeleteDriverShellComponent,
    DeleteDiskShellComponent,
    DeleteDiskComponent,
    DeleteDriverComponent,
    DeleteLayerComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    StoreModule.forRoot({}),
    StoreModule.forFeature('beybladeBattleManagement', fromBeybladeBattleManagement.reducer),
    EffectsModule.forRoot(),
    EffectsModule.forFeature([fromBeybladeBattleManagement.BeybladeBattleEffects])
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
