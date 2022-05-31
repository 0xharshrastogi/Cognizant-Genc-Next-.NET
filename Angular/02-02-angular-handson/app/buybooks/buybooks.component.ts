import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-buybooks',
  templateUrl: './buybooks.component.html',
  styleUrls: ['./buybooks.component.css']
})
export class BuybooksComponent implements OnInit {
  firstName:string | undefined;
  id=new FormControl(1,Validators.required);
  name=new FormControl(Validators.minLength(10));
  price=new FormControl(Validators.required);
  desc=new FormControl(Validators.required);
  obj=new FormGroup({firstName: new FormControl('firstname',Validators.required),
  lastName: new FormControl('lastname'),});


  constructor() { }

  ngOnInit(): void {
  }

}
