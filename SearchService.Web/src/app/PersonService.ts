import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Person } from './Person';

@Injectable({
  providedIn: 'root'
})
export class PersonService {
  private apiUrl = 'http://localhost:5015/api/SearchService/SearchPerson';

  constructor(private http: HttpClient) { }

  searchPeople(searchName: string): Observable<Person[]> {
    return this.http.get<Person[]>(`${this.apiUrl}?name=${searchName}`);
  }
}
