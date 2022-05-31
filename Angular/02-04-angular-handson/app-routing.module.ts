import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { EditEmpComponent } from "./edit-emp/edit-emp.component";
import { QuantityIncrementComponent } from "./quantity-increment/quantity-increment.component";
import { QuantitySelectorComponent } from "./quantity-selector/quantity-selector.component";
import { ViewEmpComponent } from "./view-emp/view-emp.component";

const routes: Routes = [
  { path: "view-emp", component: ViewEmpComponent },
  { path: "edit-emp", component: EditEmpComponent },
  { path: "quantity-increment", component: QuantityIncrementComponent },
  { path: "quantity-selector", component: QuantitySelectorComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
