import { Injectable } from "@angular/core";
import { Kategoria, Teszt } from "../interfaces";
import { Subject, findIndex } from "rxjs";

@Injectable({
    providedIn: 'root'
})

export class TesztService {
    tesztekChanged = new Subject<Teszt[]>();
    kategoriakChanged = new Subject<Kategoria[]>();

    private tesztek: Teszt[]
    private kategoriak: Kategoria[]

    setTesztek(tesztek: Teszt[]) {
        this.tesztek = tesztek
        this.tesztekChanged.next(this.tesztek.slice())
    } 

    setKategoriak(kategoriak: Kategoria[]) {
        this.kategoriak = kategoriak
        this.kategoriakChanged.next(this.kategoriak.slice())
    } 

}

