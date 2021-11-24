import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PartsRegistrationComponent } from './parts-registration.component';

describe('PartsRegistrationComponent', () => {
  let component: PartsRegistrationComponent;
  let fixture: ComponentFixture<PartsRegistrationComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PartsRegistrationComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PartsRegistrationComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
