import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ApiHttpService {

  private _httpClient : HttpClient;
  constructor(httpClient : HttpClient) {
    this._httpClient = httpClient
  }

  public get<T>(url : string, options? : any) {
    return this._httpClient.get<T>(url, options);
  }
}
