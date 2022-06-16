import { HttpClient } from "@angular/common/http";
import { Injectable } from '@angular/core';
import { Observable } from "rxjs";
import { User } from 'src/app/models/user.model';

@Injectable({
    providedIn: "root"
})
export class LoginService {

    constructor(private _http: HttpClient) {

    }

    getAllUsers():  Observable<User[]> {
        return this._http.get<User[]>("/api/User/GetAllUsers")
    }

    getUserById(id: number): Observable<User> {
        return this._http.get<User>("/api/User/GetUserById/" + id);
    }

    addUser(user: User): Observable<void> {
        return this._http.post<void>("/api/User/AddUser" , user);
    }

    UpdateUser(id:number,user: User): Observable<void> {
        return this._http.put<void>("/api/User/UpdateUser/" + id,user);
    }
    

    DeleteUser(id: number): Observable<void> {
        return this._http.delete<void>("/api/User/DeleteUser/"+ id);
    }

}