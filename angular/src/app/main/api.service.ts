import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class ApiService {

  constructor(private http: HttpClient) { }

  fetchPhoneBookData(): Observable<any> {
    var data = this.http.get('https://localhost:44301/api/services/app/Person/GetPeople')
    console.log(data);  
    return data;
  }
  fetchFilmListData(): Observable<any> {
    var data = this.http.get('https://localhost:44301/api/services/app/Film/GetFilms')
    console.log(data);  
    return data;
  }
}
