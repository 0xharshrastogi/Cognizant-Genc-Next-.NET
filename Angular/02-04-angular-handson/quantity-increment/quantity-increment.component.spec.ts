import { ComponentFixture, TestBed } from '@angular/core/testing';

import { QuantityIncrementComponent } from './quantity-increment.component';

describe('QuantityIncrementComponent', () => {
  let component: QuantityIncrementComponent;
  let fixture: ComponentFixture<QuantityIncrementComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ QuantityIncrementComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(QuantityIncrementComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
