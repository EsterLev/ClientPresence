import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import {AccordionModule} from 'primeng/accordion';     //accordion and accordion tab
// import {MenuItem} from 'primeng/api';
// import { LoginComponent } from './modules/login/login/login.component';
// import { PrimeComponent } from './modules/prime-ng/prime/prime.component';
import { LoginModule } from './modules/login/login.module';
import { PrimeNgModule } from './modules/prime-ng/prime-ng.module';
import {ButtonModule} from 'primeng/button';
import { KindergartenModule } from './modules/kindergarten/kindergarten.module';


@NgModule({
  declarations: [
    AppComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    LoginModule,
    PrimeNgModule,
    AccordionModule,
    ButtonModule,
    KindergartenModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }