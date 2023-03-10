import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-hand-made',
  templateUrl: './hand-made.component.html',
  styleUrls: ['./hand-made.component.css']
})
export class HandMadeComponent implements OnInit {

  products: Product[] = [];

  constructor(private productService: ProductsService) { }


  ngOnInit(): void {
    this.productService.getHandmadeProducts()
      .subscribe({
        next: (products) => {
          this.products = products;
        }
      })
  }

}
