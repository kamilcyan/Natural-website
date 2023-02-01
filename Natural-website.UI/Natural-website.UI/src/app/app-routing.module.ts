import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BasketComponent } from './components/basket/basket/basket.component';
import { HandMadeComponent } from './components/hand-made/hand-made/hand-made.component';
import { AboutUsComponent } from './components/infos/about-us/about-us.component';
import { ContactPageComponent } from './components/infos/contact-page/contact-page.component';
import { MainPageComponent } from './components/main-page/main-page/main-page.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';

const routes: Routes = [
  {
    path: '',
    component: MainPageComponent
  },
  {
    path: 'products',
    component: ProductsListComponent
  },
  {
    path: 'hand-made',
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
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
