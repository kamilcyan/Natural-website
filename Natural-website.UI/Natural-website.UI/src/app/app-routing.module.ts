import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AdminPanelComponent } from './components/admin-panel/admin-panel.component';
import { BasketComponent } from './components/basket/basket/basket.component';
import { HandMadeComponent } from './components/hand-made/hand-made/hand-made.component';
import { AboutUsComponent } from './components/infos/about-us/about-us.component';
import { ContactPageComponent } from './components/infos/contact-page/contact-page.component';
import { MainPageComponent } from './components/main-page/main-page/main-page.component';
import { AddProductComponent } from './components/products/add-product/add-product.component';
import { EditProductComponent } from './components/products/edit-product/edit-product.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';

const routes: Routes = [
  {
    path: '',
    component: MainPageComponent
  },
  {
    path: 'jucys',
    component: ProductsListComponent
  },
  {
    path: 'handmades',
    component: HandMadeComponent
  },
  {
    path: 'basket',
    component: BasketComponent
  },
  {
    path: 'contact',
    component: ContactPageComponent
  },
  {
    path: 'about-us',
    component: AboutUsComponent
  }, 
  {
    path: 'admin',
    component: AdminPanelComponent
  },
  {
    path: 'products/edit/:id',
    component: EditProductComponent
  },
  {
    path: 'admin/products/add',
    component: AddProductComponent
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
