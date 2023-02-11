import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Product } from '../models/product.model';

@Injectable({
  providedIn: 'root'
})
export class OrdersService {

  baseApiUrl: string = environment.baseApiUrl;

  constructor(private http: HttpClient) { }

  // getAllProducts(): Observable<Product[]> {
  //   return this.http.get<Product[]>(this.baseApiUrl + 'handmade');
  // }
}
