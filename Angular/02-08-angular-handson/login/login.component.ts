import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  
  //Required properties.
  username:string="";
  password:string="";
  invalid:string="";
  
  //Injecting the auth service inside this component.
  constructor(private auth:AuthService,private router:Router) { }

  ngOnInit(): void {
  }

  login(formdata:any):void
  {
    if(!(formdata.user_name=="user1"&&formdata.pass_word=="user1"))
    this.invalid="Invalid Username/Password";
    else
    {
      this.invalid="";
      this.auth.login();
      this.router.navigate(['employees']);
    }
  }

}
