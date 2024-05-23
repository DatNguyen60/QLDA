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
  addFilm(filmData: any): Observable<void> {
    return this.http.post<void>('https://localhost:44301/api/services/app/Film/CreateFilm', filmData);
  }
  deleteFilm(filmId: any): Observable<void> {
    return this.http.delete<void>('https://localhost:44301/api/services/app/Film/DeleteFilm?Id=' + filmId);
  }

}
