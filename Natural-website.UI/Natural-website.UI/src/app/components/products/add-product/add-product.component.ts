import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-add-product',
  templateUrl: './add-product.component.html',
  styleUrls: ['./add-product.component.css']
})
export class AddProductComponent implements OnInit {

  constructor(private productService: ProductsService, private router: Router) { }

  productRequest: Product = {
    product_Id: '',
    name: '',
    price: 0,
    avaibility: 0,
    description: '',
    product_Discount: '0',
    provide_Date: null,
    comment: '',
    section: '',
    picture: '',
    provider: ''
  }

  ngOnInit(): void {
  }

  addProduct() {
    this.productService.addProduct(this.productRequest)
      .subscribe({
        next: (product) => {
          this.router.navigate(['admin']);
        }
      });
  }

  cancel(){
    this.router.navigate(['admin']);
  }

}
