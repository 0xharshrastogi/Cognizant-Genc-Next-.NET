import { Component, OnInit } from '@angular/core';
import { Courses } from '../course';

@Component({
  selector: 'app-buycourses',
  templateUrl: './buycourses.component.html',
  styleUrls: ['./buycourses.component.css']
})
export class BuycoursesComponent implements OnInit {
id=1;
name="Angular";
price=500.00;
desc="Front End Framework";
obj=new Courses(1,"Angular",5000,"Front End Applications");
  constructor() { }

  ngOnInit(): void {
  }

}
