import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerModule } from './customer/customer.module'; 
import { InvoiceModule } from './invoice/invoice.module';
import { ProductsModule } from './products/products.module';



@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    CustomerModule,
    InvoiceModule,
    ProductsModule
  ]
})
export class ComponentsModule { }
