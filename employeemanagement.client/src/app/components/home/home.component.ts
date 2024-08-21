import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  employeeList: any = [];

  constructor(private router: Router, private service: EmployeeService) { }

  ngOnInit(): void {debugger
    this.loadEmployeeData();
    //this.employeeList = [{ firstName: "Anu", lastName: "Joseph", position: "TL", department:"IT"}];

  }

  addEmployee() {
    this.router.navigate(['newEmployee']);
    
  }
  deleteEmployeeConfirmation(e:any) {

  }

  loadEmployeeData() {
    this.service.getEmployeeList().subscribe(data => {
      this.employeeList = data;
      console.log(data)
    });
  }

  test() {

  }

  close() {

  }

}
