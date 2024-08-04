import { Component, Input } from '@angular/core';
import { Product } from 'src/app/shared/Models/porduct';

@Component({
  selector: 'app-product-item',
  templateUrl: './product-item.component.html',
  styleUrls: ['./product-item.component.scss']
})
export class ProductItemComponent {
@Input() product?: Product
}
