export interface Product {
    product_Id: string;
    name: string;
    price: number;
    avaibility: number | null;
    description: string | null;
    product_Discount: string;
    provide_Date: Date | null;
    comment: string | null;
    section: string | null;
    picture: string | null;
    provider: string;
}