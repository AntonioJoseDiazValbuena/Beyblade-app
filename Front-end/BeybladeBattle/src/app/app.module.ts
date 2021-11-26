import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomePageComponent } from './management/home-page/home-page.component';
import { PartsRegistrationComponent } from './management/parts-registration/parts-registration.component';
import { BattleSetUpComponent } from './management/battle-set-up/battle-set-up.component';
import { LayerComponent } from './management/parts-registration/layer/layer.component';
import { DiskComponent } from './management/parts-registration/disk/disk.component';
import { DriverComponent } from './management/parts-registration/driver/driver.component';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

@NgModule({
  declarations: [
    AppComponent,
    HomePageComponent,
    PartsRegistrationComponent,
    BattleSetUpComponent,
    LayerComponent,
    DiskComponent,
    DriverComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [HttpClientModule],
  bootstrap: [AppComponent]
})
export class AppModule { }
