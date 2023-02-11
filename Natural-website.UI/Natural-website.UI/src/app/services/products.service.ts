import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Observable } from 'rxjs';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class ProductsService {

  baseApiUrl: string = environment.baseApiUrl;
  constructor(private http: HttpClient) { }

  getJucyProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseApiUrl + 'products/jucys');
  }

  getHandmadeProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseApiUrl + 'products/handmades');
  }

  getAllProducts(): Observable<Product[]> {
    return this.http.get<Product[]>(this.baseApiUrl + 'products/getAllProducts');
  }

  getProduct(id: string): Observable<Product> {
    return this.http.get<Product>(this.baseApiUrl + 'products/getProduct/' + id);
  }

  deleteProduct(id: string): Observable<Product> {
    return this.http.delete<Product>(this.baseApiUrl + 'products/deleteProduct/' + id);
  }

  updateProduct(id: string, updateEmployeeRequest: Product): Observable<Product> {
    return this.http.put<Product>(this.baseApiUrl + 'products/updateProduct/' + id, updateEmployeeRequest);
  }

  addProduct(productRequest: Product): Observable<Product> {
    productRequest.product_Id = '0';
    return this.http.post<Product>(this.baseApiUrl + 'products/addProduct/', productRequest);
  }
}
