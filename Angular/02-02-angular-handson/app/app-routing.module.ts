import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { BooksComponent } from './books/books.component';
import { BuybooksComponent } from './buybooks/buybooks.component';
import { BuycoursesComponent } from './buycourses/buycourses.component';
import { CoursesComponent } from './courses/courses.component';

const routes: Routes = [
{
  path:'view-courses',
  component:CoursesComponent
},
{
  path:'view-books',
  component:BooksComponent
},
{
  path:'buy-courses',
  component:BuycoursesComponent
},
{
  path:'buy-books',
  component:BuybooksComponent
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
