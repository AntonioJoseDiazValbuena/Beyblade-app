import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BattleSetUpShellComponent } from './battle-set-up-shell.component';

describe('BattleSetUpShellComponent', () => {
  let component: BattleSetUpShellComponent;
  let fixture: ComponentFixture<BattleSetUpShellComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BattleSetUpShellComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BattleSetUpShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
