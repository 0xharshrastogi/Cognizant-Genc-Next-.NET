import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-quantity-selector',
  templateUrl: './quantity-selector.component.html',
  styleUrls: ['./quantity-selector.component.css']
})
export class QuantitySelectorComponent implements OnInit {
//Requisite variables.
value:number=0;
result:string="";
quantity:number=0;
flag:boolean=true;
constructor() { }

ngOnInit(): void {
}

//click function invoked on the Click Me button click.
click():void
{
  this.result="Click Me button clicked!";  
}

//inc function invoked on the Add button click.
inc():void
{
  this.value+=1;
}

//minus function invoked when minus button is clicked.
minus():void
{
  this.quantity-=1;
  if(this.quantity==0)
  this.flag=true;
  
}

//plus function invoked when plus button is clicked.
plus():void
{
  this.quantity+=1;
  if(this.quantity>0)
  this.flag=false;
}

}
