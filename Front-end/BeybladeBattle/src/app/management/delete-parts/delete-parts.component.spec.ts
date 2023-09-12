import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeletePartsComponent } from './delete-parts.component';

describe('DeletePartsComponent', () => {
  let component: DeletePartsComponent;
  let fixture: ComponentFixture<DeletePartsComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeletePartsComponent]
    });
    fixture = TestBed.createComponent(DeletePartsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
