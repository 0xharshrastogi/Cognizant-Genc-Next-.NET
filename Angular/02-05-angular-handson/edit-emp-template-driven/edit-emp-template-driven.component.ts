import { Component, OnInit } from '@angular/core';
import { Department } from '../employee/Department';
import { Employee } from '../employee/Employee';

@Component({
  selector: 'app-edit-emp-template-driven',
  templateUrl: './edit-emp-template-driven.component.html',
  styleUrls: ['./edit-emp-template-driven.component.css']
})
export class EditEmpTemplateDrivenComponent implements OnInit {

  //Creating an object of Employee type.
  employee:Employee=
  {
     id:3,
     name:"John",
     salary:10000,
     permanent:false,
     department:{id:1,name:"PayRoll"},
     skill:[{id:1,name:"HTML"},{id:2,name:"CSS"},{id:3,name:"JavaScript"}],
     dateOfBirth:new Date("2000-07-15"),
     //photoURL:""
  };

  //Creating array for drop down list.
  departments:Department[]=[];
  
  constructor() { }

  ngOnInit(): void 
  {
    this.departments=[{id:1,name:"Payroll"},{id:2,name:"Internal"},{id:3,name:"HR"}];
  }

  onSubmit():void
  {
    console.log(this.employee);
  }

}
