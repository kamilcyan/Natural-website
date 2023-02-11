import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';
import { NgForm, NgModel } from '@angular/forms';

@Component({
  selector: 'app-products-list',
  templateUrl: './products-list.component.html',
  styleUrls: ['./products-list.component.css']
})
export class ProductsListComponent implements OnInit {

  products: Product[] = [];

  constructor(private productService: ProductsService) { }


  ngOnInit(): void {
    this.productService.getJucyProducts()
    .subscribe({
      next: (products) => {
        this.products = products;
      }
    })
  }

}
