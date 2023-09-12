import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormGroup, FormBuilder } from '@angular/forms';
import { Disk } from 'src/app/app.models';

@Component({
  selector: 'app-delete-disk',
  templateUrl: './delete-disk.component.html',
  styleUrls: ['./delete-disk.component.scss']
})
export class DeleteDiskComponent {
  @Input() disks: Disk[] | null = null;
  @Output() deleteDisk = new EventEmitter<number>();

  diskToDelete: FormGroup;

  constructor(private fb: FormBuilder) {
    this.diskToDelete = this.fb.group({
      disk: [{ id: 0, attack: 0, defense: 0, name: '', stamina: 0, weight: 0 }]
    })
  }

  ngOnInit() {
  }

  delete() {
    this.deleteDisk.emit(this.diskToDelete.value.disk.id as number);
  }
}
