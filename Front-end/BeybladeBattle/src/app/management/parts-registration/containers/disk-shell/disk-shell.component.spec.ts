import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DiskShellComponent } from './disk-shell.component';

describe('DiskShellComponent', () => {
  let component: DiskShellComponent;
  let fixture: ComponentFixture<DiskShellComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DiskShellComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DiskShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
