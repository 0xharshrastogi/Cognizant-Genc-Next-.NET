import { Component, OnInit } from "@angular/core";
import { Department } from "./department";
import { Employee } from "./employee";
import { Skill } from "./skill";

@Component({
  selector: "app-employee",
  templateUrl: "./employee.component.html",
  styleUrls: ["./employee.component.css"],
})
export class EmployeeComponent implements OnInit {
  title = "Employee Information";
  employee!: Employee;

  department!: Department;
  skill!: Skill[];

  constructor() {}

  ngOnInit(): void {
    this.department = { department_id: 1, department_name: "payroll" };
    this.skill = [
      { id: 1, name: "HTML" },
      { id: 2, name: "CSS" },
      { id: 3, name: "JAVASCRIPT" },
    ];

    this.employee = {
      id: 1,
      name: "John",
      salary: 90000,
      permanent: true,
      dept: this.department,
      skill: this.skill,
      dateOfbirth: new Date("12/31/2000"),
      joiningDate: new Date("05/20/2020"),
    };
  }

  display() {
    console.log(JSON.stringify(this.employee));
  }

  displayId() {
    return this.employee.id;
  }
  displayName() {
    return this.employee.name;
  }
  displaySalary() {
    return this.employee.salary;
  }
  displayPermanentOrNot() {
    return this.employee.permanent;
  }
}
