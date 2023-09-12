import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteLayerShellComponent } from './delete-layer-shell.component';

describe('DeleteLayerShellComponent', () => {
  let component: DeleteLayerShellComponent;
  let fixture: ComponentFixture<DeleteLayerShellComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteLayerShellComponent]
    });
    fixture = TestBed.createComponent(DeleteLayerShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
