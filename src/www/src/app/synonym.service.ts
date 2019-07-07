import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

@Injectable()
export class SynonymService {
  private headers: HttpHeaders;
  private accessPointUrl: string = 'https://localhost:44321/api/synonym';

  constructor(private http: HttpClient) {
    this.headers = new HttpHeaders({'Content-Type': 'application/json; charset=utf-8'});
  }

  public get() {
    // Get all jogging data
    return this.http.get(this.accessPointUrl, {headers: this.headers});
  }

  public add(synonym) {
    return this.http.post(this.accessPointUrl, synonym, {headers: this.headers});
  }
}
