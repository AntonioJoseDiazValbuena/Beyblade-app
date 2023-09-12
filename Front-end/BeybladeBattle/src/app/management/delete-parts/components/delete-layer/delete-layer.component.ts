import { Component, EventEmitter, Input, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Layer } from 'src/app/app.models';

@Component({
  selector: 'app-delete-layer',
  templateUrl: './delete-layer.component.html',
  styleUrls: ['./delete-layer.component.scss']
})
export class DeleteLayerComponent {
  @Input() layers: Layer[] | null = null;
  @Output() deleteLayer = new EventEmitter<number>();

  layerToDelete: FormGroup;

  constructor(private fb: FormBuilder) {
    this.layerToDelete = this.fb.group({
      layer: [{ id: 0, attack: 0, canUseDisk: true, defense: 0, name: '', stamina: 0, weight: 0 }]
    })
  }

  ngOnInit() {
  }

  delete() {
    this.deleteLayer.emit(this.layerToDelete.value.layer.id as number);
  }
}
