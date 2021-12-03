import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DriverShellComponent } from './driver-shell.component';

describe('DriverShellComponent', () => {
  let component: DriverShellComponent;
  let fixture: ComponentFixture<DriverShellComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DriverShellComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DriverShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
