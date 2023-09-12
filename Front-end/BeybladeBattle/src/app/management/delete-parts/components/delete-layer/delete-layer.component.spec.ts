import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteLayerComponent } from './delete-layer.component';

describe('DeleteLayerComponent', () => {
  let component: DeleteLayerComponent;
  let fixture: ComponentFixture<DeleteLayerComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteLayerComponent]
    });
    fixture = TestBed.createComponent(DeleteLayerComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
