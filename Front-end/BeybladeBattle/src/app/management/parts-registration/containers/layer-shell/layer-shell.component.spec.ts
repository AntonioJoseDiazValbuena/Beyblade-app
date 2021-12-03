import { ComponentFixture, TestBed } from '@angular/core/testing';

import { LayerShellComponent } from './layer-shell.component';

describe('LayerShellComponent', () => {
  let component: LayerShellComponent;
  let fixture: ComponentFixture<LayerShellComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ LayerShellComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(LayerShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
