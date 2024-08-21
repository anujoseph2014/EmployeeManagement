import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { EmployeeService } from '../../services/employee.service';

@Component({
  selector: 'app-new-employee',
  templateUrl: './new-employee.component.html',
  styleUrls: ['./new-employee.component.css']
})
export class NewEmployeeComponent implements OnInit {
  addEmployeeForm!: FormGroup;
  submitted: boolean = false;
  constructor(private router: Router, private service: EmployeeService)
{ }

  ngOnInit(): void {
    this.addEmployeeForm = new FormGroup({
      firstName: new FormControl('',Validators.required),
      lastName: new FormControl('', Validators.required),
      position: new FormControl('', Validators.required),
      department: new FormControl('', Validators.required),
      salary: new FormControl('', Validators.required),
    });
  }
  saveEmployeeInfo() {
    if (this.addEmployeeForm.valid) {
      this.submitted = true;
      let
        val = {
          FirstName: this.addEmployeeForm.controls['firstName'].value,
          LastName: this.addEmployeeForm.controls['lastName'].value,
          Department: this.addEmployeeForm.controls['department'].value,
          Position: this.addEmployeeForm.controls['position'].value,
          Salary: this.addEmployeeForm.controls['salary'].value
        };

      this.service.addEmployee(val).subscribe(res => {
        alert(res.toString());
        this.router.navigate(['']);
      });
    }
    else {
      this.submitted = false;
    }
  }
}
