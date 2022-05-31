import { ComponentFixture, TestBed } from '@angular/core/testing';

import { BuybooksComponent } from './buybooks.component';

describe('BuybooksComponent', () => {
  let component: BuybooksComponent;
  let fixture: ComponentFixture<BuybooksComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ BuybooksComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(BuybooksComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
