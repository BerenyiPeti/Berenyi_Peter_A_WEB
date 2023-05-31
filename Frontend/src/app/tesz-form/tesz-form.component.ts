import { Component, OnDestroy } from '@angular/core';
import { OnInit } from '@angular/core';
import { DataStorageService } from '../data-storage.service';
import { TesztService } from './teszt.service';
import { Teszt } from '../interfaces';
import { Subscription } from 'rxjs';

@Component({
  selector: 'app-tesz-form',
  templateUrl: './tesz-form.component.html',
  styleUrls: ['./tesz-form.component.css']
})
export class TeszFormComponent implements OnInit, OnDestroy {
  constructor(private ds: DataStorageService, private ts: TesztService) { }
  
  tesztek: Teszt[]
  tesztekSub: Subscription

  ngOnInit(): void {
    this.ds.fetchTesztek()
    
    this.tesztekSub = this.ts.tesztekChanged.subscribe((data) => {
      this.tesztek = data
      console.log(this.tesztek);
      
    })
    
  }

  ngOnDestroy(): void {
    this.tesztekSub.unsubscribe()
  }
}
