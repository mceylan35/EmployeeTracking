import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { LayoutComponent } from './fatura/layout/layout.component';

const routes:Routes=[
  {path:"panel",component:LayoutComponent,children:[
    {path:"customer",loadChildren:()=>import("./fatura/components/customer/customer.component").then(
      module=>module.CustomerComponent
    )
  },
  {path:"invoice",loadChildren:()=>import("./fatura/components/invoice/invoice.component").then(
    module=>module.InvoiceComponent
  )
},
{path:"product",loadChildren:()=>import("./fatura/components/products/products.component").then(
  module=>module.ProductsComponent
),
}

  ]}
]

@NgModule({
  imports: [
     RouterModule.forRoot(routes)
  ],
  exports:[RouterModule]
})
export class AppRoutingModule { }
