import { Component } from '@angular/core';
 @Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'firstapp';
  firstName = 'Arthi';
  lastName = 'Singaravelan';
  inputType='text';
  inputValue='Computer';
  firstheading='HeadingClass';
  colorValue="blue";
  domain="Angular";
  date=new Date();
  price='100';
  executeClickEvent(event:any)
  {
    alert("Button is clicked");
    console.log(event);
  }
}
