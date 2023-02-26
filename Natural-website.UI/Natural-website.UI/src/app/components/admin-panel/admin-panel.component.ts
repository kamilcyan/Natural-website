import { Component, OnInit } from '@angular/core';
import { Product } from 'src/app/models/product.model';
import { ProductsService } from 'src/app/services/products.service';
import { ManageProductsComponent } from './products-management/manage-products/manage-products.component';

@Component({
  selector: 'app-admin-panel',
  templateUrl: './admin-panel.component.html',
  styleUrls: ['./admin-panel.component.css']
})
export class AdminPanelComponent implements OnInit {

  products: Product[] = [];

  productsVisibility: boolean = true;
  clientsVisibility: boolean = false;

  buttonProductsClicked: boolean = true;
  buttonClientsClicked: boolean = false;


  addingVisibility: boolean = false;
  constructor(private productService: ProductsService) { }


  ngOnInit(): void {
    this.productService.getAllProducts()
      .subscribe({
        next: (products) => {
          this.products = products;
        }
      })
  }

  showProducts() {
    if (this.clientsVisibility == true){
      this.clientsVisibility = false;
      this.buttonClientsClicked = false;
    }
    if (this.productsVisibility == false) {
      this.productsVisibility = true;
      this.buttonProductsClicked = true;
    } else {
      this.productsVisibility = false;
      this.buttonProductsClicked = false;
    }
  }

  showClients() {
    if (this.productsVisibility == true){
      this.productsVisibility = false;
      this.buttonProductsClicked = false;
    }
    if (this.productsVisibility == false) {
      this.clientsVisibility = true;
      this.buttonClientsClicked = true;
    } else {
      this.clientsVisibility = false;
      this.buttonClientsClicked = false;
    }
  }
}
