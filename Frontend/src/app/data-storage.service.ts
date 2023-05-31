import { Injectable } from "@angular/core";
import { HttpClient } from '@angular/common/http';
import { TesztService } from "./tesz-form/teszt.service";
import { Teszt } from "./interfaces";

@Injectable({
    providedIn: 'root'
})

export class DataStorageService {
    constructor(private http: HttpClient, private ts: TesztService) { }

    fetchTesztek() {
        return this.http.get<Teszt[]>(URL + '/tesztek').subscribe((data: Teszt[])=> {
            this.ts.setTesztek(data)
        })
    }
}

export const URL = 'https://localhost:7258'