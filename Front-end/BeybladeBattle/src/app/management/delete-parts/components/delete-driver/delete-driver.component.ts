import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Driver } from 'src/app/app.models';

@Component({
  selector: 'app-delete-driver',
  templateUrl: './delete-driver.component.html',
  styleUrls: ['./delete-driver.component.scss']
})
export class DeleteDriverComponent {
  @Input() drivers: Driver[] | null = null;
  @Output() deleteDriver = new EventEmitter<number>();

  driverToDelete: FormGroup;

  constructor(private fb: FormBuilder) {
    this.driverToDelete = this.fb.group({
      driver: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0, type: 0 }]
    })
  }

  ngOnInit() {
  }

  delete() {
    this.deleteDriver.emit(this.driverToDelete.value.driver.id as number);
  }
}
