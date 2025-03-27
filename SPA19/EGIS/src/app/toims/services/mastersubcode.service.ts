import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { createMasterSubCodeDto, MasterSubcode } from '../models/submastercode';
import { Observable } from 'rxjs';


@Injectable({
  providedIn: 'root'
})
export class MastersubcodeService {

  private apiUrl ='https://localhost:7285/api/MasterTableSubCode'
 
  constructor(private http:HttpClient) { }

  getMasteSubCodes():Observable<MasterSubcode[]>{
    return this.http.get<MasterSubcode[]>(this.apiUrl);
  }

  updateMasterSubCode(mscode:MasterSubcode):Observable<void>{
    return this.http.put<void>(`${this.apiUrl}/${mscode.id}`,mscode);
  }

  createMasterSubCode(data:createMasterSubCodeDto):Observable<createMasterSubCodeDto>{
    data.id= 0;
    return this.http.post<createMasterSubCodeDto>(this.apiUrl + '/Create',data);
  }

  
  deleteMasterSubCode(id:number):Observable<void>{
    
    return this.http.delete<void>(`${this.apiUrl}/${id}`);
  }
}

