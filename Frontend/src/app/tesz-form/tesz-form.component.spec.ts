import { ComponentFixture, TestBed } from '@angular/core/testing';

import { TeszFormComponent } from './tesz-form.component';

describe('TeszFormComponent', () => {
  let component: TeszFormComponent;
  let fixture: ComponentFixture<TeszFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ TeszFormComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(TeszFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
