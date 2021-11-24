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
  layers$: Observable<Layer[]> | undefined;
  disks$: Observable<Disk[]> | undefined;
  // frames$: Observable<Frame[]> | undefined;
  drivers$: Observable<Driver[]> | undefined;
  
  constructor(private managementService: ManagementService) { }

  ngOnInit() {
    this.layers$ = this.managementService.obtainLayers();
    this.disks$ = this.managementService.obtainDisks();
    // this.frames$ = this.managementService.obtainFrames();
    this.drivers$ = this.managementService.obtainDrivers();
  }

}
