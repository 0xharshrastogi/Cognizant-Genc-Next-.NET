import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { Employee } from 'Models/Employee';
import { EmployeeService } from '../employee.service';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrls: ['./employee-list.component.css']
})
export class EmployeeListComponent implements OnInit {
  
  //Creating a list to store the employee data.
  employeeList:Employee[]=[];

  //Creating a list to store the filtered employees.
  filteredEmployees:Employee[]=[];

  //Requisite property for search box.
  searchKey:string="";

  //Necessary dependency injection.
  constructor(private obj:EmployeeService,private router:ActivatedRoute){}

  ngOnInit(): void 
  {
    this.employeeList=this.obj.getAllEmployees();
  }

  //search function.
  search():void
  {
    //Using filter method to fetch requisite details.
    if(this.searchKey!="")
    this.filteredEmployees=this.employeeList.filter((emp_item)=>emp_item.name.toLowerCase().indexOf(this.searchKey.toLocaleLowerCase())!=-1);
    else
    this.filteredEmployees=[];
    
  }

}
