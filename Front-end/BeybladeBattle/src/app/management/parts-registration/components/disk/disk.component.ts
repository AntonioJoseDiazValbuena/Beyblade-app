import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Disk } from 'src/app/app.models';

@Component({
  selector: 'app-disk',
  templateUrl: './disk.component.html',
  styleUrls: ['./disk.component.scss']
})
export class DiskComponent implements OnInit {
  @Output() saveDisk = new EventEmitter<Disk>();

  disk: FormGroup;

  constructor(private fb: FormBuilder) { 
    this.disk = this.fb.group({
      name: [''],
      attack: [0],
      defense: [0],
      stamina: [0],
      weight: [0]
    });
  }

  ngOnInit() {
  }

  save() {
    this.saveDisk.emit({ ...this.disk.value } as Disk);
  }
}
