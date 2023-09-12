import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BattleSetUpComponent } from './management/battle-set-up/battle-set-up.component';
import { PartsRegistrationComponent } from './management/parts-registration/parts-registration.component';
import { DeletePartsComponent } from './management/delete-parts/delete-parts.component';

const routes: Routes = [
  {
    path: 'doABattle',
    component: BattleSetUpComponent
  },
  {
    path: 'registerParts',
    component: PartsRegistrationComponent
  },
  {
    path: 'deleteParts',
    component: DeletePartsComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
