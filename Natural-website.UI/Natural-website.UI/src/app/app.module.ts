import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { ProductsListComponent } from './components/products/products-list/products-list.component';
import { MainPageComponent } from './components/main-page/main-page/main-page.component';
import { HandMadeComponent } from './components/hand-made/hand-made/hand-made.component';
import { BasketComponent } from './components/basket/basket/basket.component';
import { AboutUsComponent } from './components/infos/about-us/about-us.component';
import { ContactPageComponent } from './components/infos/contact-page/contact-page.component';

@NgModule({
  declarations: [
    AppComponent,
    ProductsListComponent,
    MainPageComponent,
    HandMadeComponent,
    BasketComponent,
    AboutUsComponent,
    ContactPageComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
