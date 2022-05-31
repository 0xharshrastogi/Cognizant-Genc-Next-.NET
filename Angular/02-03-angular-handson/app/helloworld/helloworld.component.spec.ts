import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HelloworldComponent } from './helloworld.component';

describe('HelloworldComponent', () => {
  let component: HelloworldComponent;
  let fixture: ComponentFixture<HelloworldComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HelloworldComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(HelloworldComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
