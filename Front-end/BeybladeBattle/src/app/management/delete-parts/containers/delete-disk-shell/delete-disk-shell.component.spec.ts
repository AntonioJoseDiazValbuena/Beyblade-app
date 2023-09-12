import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteDiskShellComponent } from './delete-disk-shell.component';

describe('DeleteDiskShellComponent', () => {
  let component: DeleteDiskShellComponent;
  let fixture: ComponentFixture<DeleteDiskShellComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteDiskShellComponent]
    });
    fixture = TestBed.createComponent(DeleteDiskShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
