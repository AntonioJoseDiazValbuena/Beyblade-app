import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { Disk, Driver, /*Frame,*/ Layer } from 'src/app/app.models';
import { ManagementService } from '../management.service';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent implements OnInit {
  layers$: Observable<Layer[]> | null = null;
  disks$: Observable<Disk[]> | null = null;
  // frames$: Observable<Frame[]> | undefined;
  drivers$: Observable<Driver[]> | null = null;
  doABattle: boolean = false;
  registerParts: boolean = false;

  constructor(private managementService: ManagementService) { }

  ngOnInit() {
    this.layers$ = this.managementService.obtainLayers();
    this.disks$ = this.managementService.obtainDisks();
    // this.frames$ = this.managementService.obtainFrames();
    this.drivers$ = this.managementService.obtainDrivers();
  }

  activateDeactivateBattleSetUp() {
    this.doABattle = !this.doABattle;
  }

  activateDeactivatePartsRegistration() {
    this.registerParts = !this.registerParts;
  }
}
