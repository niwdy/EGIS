import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { createMasterCodeDto, Mastercode } from '../models/mastercode';

@Injectable({
  providedIn: 'root'
})
export class MastercodeService {

  private apiUrl ='https://localhost:7285/api/MasterTableCode'
 
  constructor(private http:HttpClient) { }

  getMasteCodes():Observable<Mastercode[]>{
    return this.http.get<Mastercode[]>(this.apiUrl);
  }

  updateMasterCode(mcode:Mastercode):Observable<void>{
    return this.http.put<void>(`${this.apiUrl}/${mcode.id}`,mcode);
  }

  createMasterCode(data:createMasterCodeDto):Observable<createMasterCodeDto>{
    data.id= 0;
    return this.http.post<createMasterCodeDto>(this.apiUrl + '/Create',data);
  }

  
  deleteMasterCode(id:number):Observable<void>{
    
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }

}
