import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from '../employee/Employee';
import { EmployeeService } from '../employee/employee.service';

@Component({
  selector: 'app-view-emp',
  templateUrl: './view-emp.component.html',
  styleUrls: ['./view-emp.component.css']
})
export class ViewEmpComponent implements OnInit {

  //Creating a list of employees.
  employee_list:Employee[]=[];
  
  //Necessary dependency injection.
  constructor(private obj:EmployeeService,private route:ActivatedRoute){}
  
  ngOnInit(): void {
    //Gathering employee list from service.
    this.employee_list=this.obj.getAllEmployees();
    
  }

}
