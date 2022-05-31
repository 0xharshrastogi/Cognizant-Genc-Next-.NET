import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormsModule } from '@angular/forms';
import { DebugElement } from '@angular/core';

import { QuantitySelectorComponent } from './quantity-selector.component';

describe('QuantitySelectorComponent', () => {
  let component: QuantitySelectorComponent;
  let fixture: ComponentFixture<QuantitySelectorComponent>;
  let debugElement: DebugElement;
  debugElement = fixture.debugElement;
  let clickMeButton = debugElement.nativeElement.querySelector('#clickMe');
   debugElement.nativeElement.querySelector('#simpleClick').textContent;
   fixture.detectChanges() 
  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuantitySelectorComponent ],
      imports:[FormsModule]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuantitySelectorComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
