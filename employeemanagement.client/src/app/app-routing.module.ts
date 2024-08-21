import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './components/home/home.component';
import { FormsModule } from '@angular/forms';
import { NewEmployeeComponent } from './components/new-employee/new-employee.component';

const routes: Routes = [
  { path: '', redirectTo: 'Home', pathMatch: 'full' },
  { path: '', component: HomeComponent, pathMatch: 'full' },
  { path: 'newEmployee', component: NewEmployeeComponent, pathMatch: 'full' },
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forRoot(routes),
    CommonModule,
    FormsModule
  ],
  exports: [RouterModule],

})
export class AppRoutingModule { }
