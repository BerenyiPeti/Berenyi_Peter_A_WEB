import { Component, OnDestroy } from '@angular/core';
import { OnInit } from '@angular/core';
import { DataStorageService } from '../data-storage.service';
import { TesztService } from './teszt.service';
import { Kategoria, Teszt } from '../interfaces';
import { Subscription } from 'rxjs';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-tesz-form',
  templateUrl: './tesz-form.component.html',
  styleUrls: ['./tesz-form.component.css']
})
export class TeszFormComponent implements OnInit, OnDestroy {
  constructor(private ds: DataStorageService, private ts: TesztService) { }
  
  tesztek: Teszt[]
  kategoriak: Kategoria[]
  tesztekSub: Subscription
  kategoriakSub: Subscription

  ngOnInit(): void {
    this.ds.fetchTesztek()
    this.ds.fetchKategoriak()
    
    this.tesztekSub = this.ts.tesztekChanged.subscribe((data) => {
      this.tesztek = data
      console.log(this.tesztek);
      
    })

    this.kategoriakSub = this.ts.kategoriakChanged.subscribe((data) => {
      this.kategoriak = data
      console.log(this.kategoriak);
      console.log(this.kategoriak[0].kategoriaNev);
      
      
    })
    
  }

  ngOnDestroy(): void {
    this.tesztekSub.unsubscribe()
    this.kategoriakSub.unsubscribe()
  }

  onSubmit(form: NgForm) {
    console.log(form.value);
    
  }
}
