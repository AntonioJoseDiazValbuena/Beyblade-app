import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BeybladeBattle, Disk, Driver, /*Frame,*/ Layer } from '../app.models';
import { map } from 'rxjs/operators';

const baseURL = 'https://localhost:44339/BeybladeManagement'

@Injectable({
  providedIn: 'root'
})
export class ManagementService {

  constructor(private http: HttpClient) { }

  battle(beybladeBattle: BeybladeBattle): Observable<string> {
    const url = `${baseURL}/Battle`;

    return this.http.post<{ response: string }>(url, beybladeBattle).pipe(
      map((data) => data.response)
    );
  }

  obtainLayers(): Observable<Layer[]> {
    const url = `${baseURL}/Layers`;

    return this.http.get<Layer[]>(url);
  }

  registerLayer(layer: Layer): Observable<void> {
    const url = `${baseURL}/Layer`;

    return this.http.post<void>(url, layer);
  }

  obtainDisks(): Observable<Disk[]> {
    const url = `${baseURL}/Disks`;

    return this.http.get<Disk[]>(url);
  }

  registerDisk(disk: Disk): Observable<void> {
    const url = `${baseURL}/Disk`;

    return this.http.post<void>(url, disk);
  }

  /*obtainFrames(): Observable<Frame[]>{
    const url = `${baseURL}/Frames`;

    return this.http.get<Frame[]>(url);
  }

  registerFrame(frame: Frame): Observable<void>{
    const url = `${baseURL}/Frame`;

    return this.http.post<void>(url, frame);
  }*/

  obtainDrivers(): Observable<Driver[]> {
    const url = `${baseURL}/Drivers`;

    return this.http.get<Driver[]>(url);
  }

  registerDriver(driver: Driver): Observable<void> {
    const url = `${baseURL}/Driver`;

    return this.http.post<void>(url, driver);
  }
}
