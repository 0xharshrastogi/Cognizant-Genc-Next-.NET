import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  
  loggedIn:boolean=false;

  constructor() { }

  //login method.
  login():void
  {
      this.loggedIn=true;
  }
  
  //logout method.
  logout():void
  {
      this.loggedIn=false;
  }

  //isLoggedIn method.
  isLoggedIn():boolean
  {
    return this.loggedIn;
  }
}
