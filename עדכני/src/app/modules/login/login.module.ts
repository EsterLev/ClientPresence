import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { BrowserModule } from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { FormsModule, ReactiveFormsModule } from "@angular/forms";
import { LoginComponent } from './login/login.component';
import { PrimeNgModule } from '../prime-ng/prime-ng.module';
import { ButtonModule } from 'primeng/button';
import { CardModule, } from 'primeng/card';
import {PasswordModule} from 'primeng/password';
import { DividerModule } from "primeng/divider";
import {InputTextModule} from 'primeng/inputtext';
import { HttpClientModule } from '@angular/common/http';
import {MessagesModule} from 'primeng/messages';
import {MessageModule} from 'primeng/message';
import {RippleModule} from 'primeng/ripple';

@NgModule({
  declarations: [LoginComponent],
  imports: [
    HttpClientModule,
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    MessagesModule,
    MessageModule,
    PrimeNgModule,
    CardModule,
    ButtonModule,
    PasswordModule,
    DividerModule,
    FormsModule,
    InputTextModule,
    RippleModule,
    ReactiveFormsModule,
    FormsModule,
  ],
  exports:[LoginComponent]
})
export class LoginModule { }
