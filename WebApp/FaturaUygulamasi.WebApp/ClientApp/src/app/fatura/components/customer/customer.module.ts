import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CustomerComponent } from './customer.component';
import { RouterModule } from '@angular/router'; 
import { FormsComponent } from '../forms/forms/forms.component';



@NgModule({
  declarations: [CustomerComponent,FormsComponent],
  imports: [
    CommonModule,
    RouterModule.forChild([
      {path:"customer",component:CustomerComponent}
    ]),
    //SharedModule
  ],
  providers: [],
  entryComponents: [
   // CustomerComponent,
    FormsComponent
  ],
  exports: [
    RouterModule,
  ]
})
export class CustomerModule { }
