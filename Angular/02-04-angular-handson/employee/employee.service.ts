import { Injectable } from "@angular/core";
import { Employee } from "./Employee";

@Injectable({
  providedIn: "root",
})
export class EmployeeService {
  //Creating a list of Employees.
  employeeList: Employee[] = [
    {
      id: 1,
      name: "John",
      salary: 40000,
      permanent: true,
      department: { id: 1, name: "PayRoll" },
      skill: [
        { id: 1, name: "PHP" },
        { id: 2, name: "MYSQL" },
        { id: 3, name: "React" },
      ],
      dateOfBirth: new Date("1997-07-20"),
      // photoURL:"assets/Images/john.jpg"
    },
    {
      id: 2,
      name: "Ria",
      salary: 20000,
      permanent: true,
      department: { id: 2, name: "Internal" },
      skill: [
        { id: 1, name: "JAVA" },
        { id: 2, name: "SpringBoot" },
        { id: 3, name: "Angular" },
      ],
      dateOfBirth: new Date("1998-06-1"),
      //photoURL:"assets/Images/ria.jpg"
    },
    {
      id: 3,
      name: "Henry",
      salary: 30000,
      permanent: false,
      department: { id: 3, name: "HR" },
      skill: [
        { id: 1, name: "C#" },
        { id: 2, name: "ASP.NET MVC" },
        { id: 3, name: "VUE" },
      ],
      dateOfBirth: new Date("1993-08-15"),
      // photoURL:"assets/Images/henry.jpg"
    },
    {
      id: 4,
      name: "Jenna",
      salary: 50000,
      permanent: true,
      department: { id: 4, name: "Internal" },
      skill: [
        { id: 1, name: "Go" },
        { id: 2, name: "ASP.NET CORE" },
        { id: 3, name: "Python" },
      ],
      dateOfBirth: new Date("1994-09-13"),
      //photoURL:"assets/Images/jenna.jpg"
    },
    {
      id: 5,
      name: "Harry",
      salary: 10000,
      permanent: false,
      department: { id: 5, name: "External" },
      skill: [
        { id: 1, name: "HTML" },
        { id: 2, name: "CSS" },
        { id: 3, name: "JavaScript" },
      ],
      dateOfBirth: new Date("1997-02-18"),
      //photoURL:"assets/Images/harry.jpg"
    },
  ];

  constructor() {}

  //Creating an empty employee object.
  empty_emp: any = {};

  //Get all employees.
  getAllEmployees(): Employee[] {
    return this.employeeList;
  }

  //Get employee by id.
  getEmployee(employeeId: number): Employee {
    this.employeeList.forEach((item) => {
      if (item.id == employeeId) this.empty_emp = item;
    });

    return this.empty_emp;
  }
}
