import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quantity-increment',
  templateUrl: './quantity-increment.component.html',
  styleUrls: ['./quantity-increment.component.css']
})
export class QuantityIncrementComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }
  msg:string | undefined;

   clickEvent(){
    this.msg='Click me Button is Clicked!!';
    return this.msg;
  }

}
