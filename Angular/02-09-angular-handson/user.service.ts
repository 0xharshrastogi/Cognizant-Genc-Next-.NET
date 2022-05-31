import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Observable } from "rxjs";
import { User } from "./model/user.model";

@Injectable({
  providedIn: "root",
})
export class UserService {
  private _url: string = "https://reqres.in/api/users?page=2";

  constructor(private http: HttpClient) {}

  getAllUsers(): Observable<User[]> {
    return this.http.get<User[]>(this._url);
  }
}
