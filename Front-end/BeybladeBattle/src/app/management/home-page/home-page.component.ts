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
  doABattle: boolean = false;
  registerParts: boolean = false;

  constructor() { }

  ngOnInit() {
  }

  activateDeactivateBattleSetUp() {
    this.doABattle = !this.doABattle;
  }

  activateDeactivatePartsRegistration() {
    this.registerParts = !this.registerParts;
  }
}
