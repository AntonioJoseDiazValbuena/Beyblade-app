import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Layer } from 'src/app/app.models';

@Component({
  selector: 'app-layer',
  templateUrl: './layer.component.html',
  styleUrls: ['./layer.component.scss']
})
export class LayerComponent implements OnInit {
  @Output() saveLayer = new EventEmitter<Layer>();

  layer: FormGroup;

  constructor(private fb: FormBuilder) {
    this.layer = this.fb.group({
      name: [''],
      attack: [0],
      defense: [0],
      stamina: [0],
      weight: [0],
      canUseDisk: [true]
    });
  }

  ngOnInit() {
  }

  save() {
    this.saveLayer.emit({ ...this.layer.value } as Layer);
  }
}
