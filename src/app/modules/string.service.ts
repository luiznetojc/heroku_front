import { HttpClient, HttpErrorResponse, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, throwError } from 'rxjs';
import { RequestString } from './Models/request-string';
import { ResponseString } from './Models/response-string';

@Injectable({
  providedIn: 'root'
})
export class StringService {
  constructor(private http: HttpClient) { }
  URL = "https://localhost:44378/";
  httpOptions = {
    headers: new HttpHeaders({ 'Content-Type': 'application/json',  'Access-Control-Allow-Origin': '*'})
  }
  send_service(str:RequestString): Observable<ResponseString>{
    console.log(str);
      return this.http.post<ResponseString>(this.URL+'api/String/p', str, this.httpOptions)
  }
}
