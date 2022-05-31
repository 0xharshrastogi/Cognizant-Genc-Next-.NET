import { Component, OnInit } from "@angular/core";
import { Department } from "./Department";
import { Employee } from "./Employee";
import { Skill } from "./Skill";
@Component({
  selector: "app-employee",
  templateUrl: "./employee.component.html",
  styleUrls: ["./employee.component.css"],
})
export class EmployeeComponent implements OnInit {
  employee!: Employee;
  department!: Department;
  skill!: Skill[];

  constructor() {}

  ngOnInit(): void {
    this.department = { id: 1, name: "payroll" };
    this.skill = [
      { id: 1, name: "HTML" },
      { id: 2, name: "CSS" },
      { id: 3, name: "JAVASCRIPT" },
    ];
    this.employee = {
      id: 1,
      name: "John",
      salary: 10000,
      permanent: true,
      department: this.department,
      skill: this.skill,
      dateOfBirth: new Date("04/21/2019"),
    };
  }
  display() {
    console.log(JSON.stringify(this.employee));
  }
}
