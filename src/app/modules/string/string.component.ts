import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ResponseString } from '../Models/response-string';
import { StringService } from '../string.service';
import { RequestString } from '../Models/request-string';
import { DashboardService } from '../dashboard.service';
import { MatGridTileHeaderCssMatStyler } from '@angular/material';

@Component({
  selector: 'app-string',
  templateUrl: './string.component.html',
  styleUrls: ['./string.component.scss']
})
export class StringComponent implements OnInit {

  constructor(private stringSvc: StringService) { }
  Response!: Observable<ResponseString>;
  ngOnInit() {
  }
  public str = " ";
  send!: RequestString;
  response!:any;
  send_string(){
      this.send = {} as RequestString;
      this.response = {} as ResponseString;
      this.send.string = this.str;
      if(this.str.length >= 1){
        this.response = this.stringSvc.send_service(this.send)
      }
    
      
      
  }
}
