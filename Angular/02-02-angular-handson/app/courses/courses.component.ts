import { getLocalePluralCase } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Courses } from '../course';
import { lcourse } from '../newcourse';
@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styleUrls: ['./courses.component.css']
})
export class CoursesComponent implements OnInit {

  constructor() { }
c=lcourse;
selectedCourse:Courses|undefined;
  ngOnInit(): void {
  }
  onClick(scourse:Courses):void{
this.selectedCourse=scourse;
  }

}
