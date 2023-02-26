import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';


@Component({
  selector: 'app-manage-products',
  templateUrl: './manage-products.component.html',
  styleUrls: ['./manage-products.component.css']
})
export class ManageProductsComponent implements OnInit {

  products: Product[] = [];

  // addingVisibility: boolean = false;

  constructor(private productService: ProductsService, private router: Router) { }

  ngOnInit(): void {
    this.productService.getAllProducts()
      .subscribe({
        next: (products) => {
          this.products = products;
        }
      })

  }


  // showAdding() {
  //   if (this.addingVisibility == false) {
  //     this.addingVisibility = true;
  //   } else {
  //     this.addingVisibility = false;
  //   }
  // }

  cancelProduct() {
    this.router.navigate(['admin']);
  }
}
