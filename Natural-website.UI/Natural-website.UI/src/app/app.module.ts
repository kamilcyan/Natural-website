import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';
import { MainPageComponent } from './components/main-page/main-page/main-page.component';
import { HandMadeComponent } from './components/hand-made/hand-made/hand-made.component';
import { BasketComponent } from './components/basket/basket/basket.component';
import { AboutUsComponent } from './components/infos/about-us/about-us.component';
import { ContactPageComponent } from './components/infos/contact-page/contact-page.component';
import { EditProductComponent } from './components/admin-panel/products-management/edit-product/edit-product.component';
import { AddProductComponent } from './components/admin-panel/products-management/add-product/add-product.component';
import { ClientsListComponent } from './components/clients/clients-list/clients-list.component';
import { EditClientComponent } from './components/admin-panel/clients-management/edit-client/edit-client.component';
import { AddClientComponent } from './components/admin-panel/clients-management/add-client/add-client.component';
import { AdminPanelComponent } from './components/admin-panel/admin-panel.component';
import { ManageProductsComponent } from './components/admin-panel/products-management/manage-products/manage-products.component';
import { ManageClientsComponent } from './components/admin-panel/clients-management/manage-clients/manage-clients/manage-clients.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsListComponent,
    MainPageComponent,
    HandMadeComponent,
    BasketComponent,
    AboutUsComponent,
    ContactPageComponent,
    AdminPanelComponent,
    EditProductComponent,
    AddProductComponent,
    ClientsListComponent,
    EditClientComponent,
    AddClientComponent,
    ManageProductsComponent,
    ManageClientsComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
