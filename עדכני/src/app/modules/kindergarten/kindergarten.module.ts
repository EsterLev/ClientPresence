import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FileUploadModule } from 'primeng/fileupload';
import { HttpClientModule } from '@angular/common/http'
import { PrimeNgModule } from '../prime-ng/prime-ng.module';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { MessagesModule } from 'primeng/messages';
import { MessageModule } from 'primeng/message';
import { CardModule } from 'primeng/card';
import { ButtonModule } from 'primeng/button';
import { FormsModule } from '@angular/forms';
import { NewGroupComponent } from './new-group/new-group.component';
import { MessageService } from 'primeng/api';



@NgModule({
  declarations: [NewGroupComponent],
  imports: [
    CommonModule,
    FileUploadModule,
    HttpClientModule,
    PrimeNgModule,
    BrowserAnimationsModule,
    MessagesModule,
    MessageModule,
    CardModule,
    ButtonModule,
    FormsModule,
  ],
  exports: [NewGroupComponent],
  providers: [MessageService ]
})
export class KindergartenModule { }
