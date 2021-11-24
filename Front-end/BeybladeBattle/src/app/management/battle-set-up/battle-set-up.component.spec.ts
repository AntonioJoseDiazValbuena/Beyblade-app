import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BattleSetUpComponent } from './battle-set-up.component';

describe('BattleSetUpComponent', () => {
  let component: BattleSetUpComponent;
  let fixture: ComponentFixture<BattleSetUpComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BattleSetUpComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BattleSetUpComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
