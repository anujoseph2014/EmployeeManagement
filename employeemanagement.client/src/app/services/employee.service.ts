import { Injectable } from '@angular/core';
import { HttpClient, HttpEvent, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  readonly apiUrl = 'https://localhost:44313/api/';
  constructor(private http: HttpClient) { }

  getEmployeeList(): Observable<any[]> {
    return this.http.get<any[]>(this.apiUrl + 'Employee/GetEmployees');
  }
  addEmployee(emp: any): Observable<any> {
    const httpOptions = { headers: new HttpHeaders({ 'Content-Type': 'application/json' }) };
    return this.http.post<any>(this.apiUrl + 'Employee/CreateEmployee', emp);
  }
}
