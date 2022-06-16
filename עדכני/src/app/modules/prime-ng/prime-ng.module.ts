import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {BrowserModule} from '@angular/platform-browser';
import {BrowserAnimationsModule} from '@angular/platform-browser/animations';
import { PrimeComponent } from './prime/prime.component';

import { ButtonModule } from 'primeng/button';
import { CardModule, } from 'primeng/card';


@NgModule({
  declarations: [PrimeComponent],
  imports: [
    CommonModule,
    BrowserModule,
    BrowserAnimationsModule,
    CardModule,
    ButtonModule
  ],
  exports:[
    PrimeComponent
  ]
})
export class PrimeNgModule { }
