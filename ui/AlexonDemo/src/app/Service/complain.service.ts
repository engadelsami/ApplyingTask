
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { GetComplainsModel } from '../Models/GetComplainsModel';
@Injectable({
  providedIn: 'root'
})
export class ComplainService {

  url=environment.baseUrl;
  constructor(private httpClient : HttpClient )
  {}
  GetComplains() : Observable<GetComplainsModel[]>
  {
    return this.httpClient.get<GetComplainsModel[]>(this.url+"Complain/GetComplains");
  }
}
