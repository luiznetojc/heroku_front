import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { ResponseString } from '../Models/response-string';
import { StringService } from '../string.service';
import { RequestString } from '../Models/request-string';
import { DashboardService } from '../dashboard.service';

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
  public string = "sdfsdf";
  send!: RequestString;
  send_string(str:string){
      this.send = {} as RequestString;
      this.send.String = str;
      this.Response = this.stringSvc.send_service(this.send);
  }
}
