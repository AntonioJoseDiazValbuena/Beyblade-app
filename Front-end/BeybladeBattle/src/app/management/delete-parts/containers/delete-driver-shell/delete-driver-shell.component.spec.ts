import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DeleteDriverShellComponent } from './delete-driver-shell.component';

describe('DeleteDriverShellComponent', () => {
  let component: DeleteDriverShellComponent;
  let fixture: ComponentFixture<DeleteDriverShellComponent>;

  beforeEach(() => {
    TestBed.configureTestingModule({
      declarations: [DeleteDriverShellComponent]
    });
    fixture = TestBed.createComponent(DeleteDriverShellComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
