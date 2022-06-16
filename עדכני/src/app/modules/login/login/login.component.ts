import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, MinLengthValidator, Validators } from '@angular/forms';
import { PrimeNGConfig } from 'primeng/api';
import { User } from 'src/app/models/user.model';
import { LoginService } from '../login.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss'],
  // styles: [
  //   `
  //     :host ::ng-deep .p-password input {
  //       width: 15rem;
  //     }
  //   `
  // ]
})
export class LoginComponent implements OnInit {

  // password = "";
  // user_name = "";
  img="../../../assets/lll.png"
  users:User[]=[];
  user:User=new User();

  constructor(private primengConfig: PrimeNGConfig,private _loginService: LoginService) {
  }

  loginForm: FormGroup = new FormGroup({
    "user_name": new FormControl("", Validators.required),
    "password": new FormControl("", [Validators.required, Validators.minLength(4)]),
  })

  ngOnInit() {
    this.primengConfig.ripple = true;
  }

  login(){
    this._loginService.getAllUsers().subscribe(data => {
      this.users = data;
      this.user=new User();
            // this.loginForm.controls["user_name"].errors?.minLength

      // this.loginForm.controls["user_name"].touched
      this.user=this.users.find((u)=>u.userName===this.loginForm.controls["user_name"].value && u.password===this.loginForm.controls["password"].value)||this.user;
      if(this.user.id!==undefined){
        alert("שלום "+this.user.firstName+" "+this.user.lastName);
      }
    })
  }

}
