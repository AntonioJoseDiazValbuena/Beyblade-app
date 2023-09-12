import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteDiskComponent } from './delete-disk.component';

describe('DeleteDiskComponent', () => {
  let component: DeleteDiskComponent;
  let fixture: ComponentFixture<DeleteDiskComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteDiskComponent]
    });
    fixture = TestBed.createComponent(DeleteDiskComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
