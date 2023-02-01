import { Customer } from "./customer.model";
import { Product } from "./product.model";

export interface Order {
    idOrder: number;
    idProduct: Product;
    idCustomer: Customer;
    price: Product;
    quantity: number;
    customerDiscount: Customer;
    productDiscount: Product;
    total: number;
    orderDate: Date;
    comment: string;
}