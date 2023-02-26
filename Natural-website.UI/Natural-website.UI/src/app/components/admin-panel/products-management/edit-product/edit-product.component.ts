import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';

@Component({
  selector: 'app-edit-product',
  templateUrl: './edit-product.component.html',
  styleUrls: ['./edit-product.component.css']
})
export class EditProductComponent implements OnInit {

  productDetails: Product = {
  product_Id: '',
  name: '',
  price: 0,
  avaibility: 0,
  description: '',
  product_Discount: '',
  provide_Date: null,
  comment: '',
  section: '',
  picture: '',
  provider: ''
}

  constructor(private route: ActivatedRoute, private productService: ProductsService, private router: Router) { }

  ngOnInit(): void {
    this.route.paramMap.subscribe({
      next: (params) => {
        const id = params.get('id');

        if (id) {
          this.productService.getProduct(id)
            .subscribe({
              next: (response) => {
                this.productDetails = response;
              }
            })
        }
      }
    })
  }

  deleteProduct(id: string) {
    this.productService.deleteProduct(id)
      .subscribe({
        next: (response) => {
          this.router.navigate(['admin']);
        }
      });
  }

  updateProduct() {
    this.productService.updateProduct(this.productDetails.product_Id, this.productDetails)
      .subscribe({
        next: (employee) => {
          this.router.navigate(['admin']);
        }
      });
  }

  cancel() {
    this.router.navigate(['admin']);
  }
}
