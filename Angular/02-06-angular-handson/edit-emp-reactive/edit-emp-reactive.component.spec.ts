import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditEmpReactiveComponent } from './edit-emp-reactive.component';

describe('EditEmpReactiveComponent', () => {
  let component: EditEmpReactiveComponent;
  let fixture: ComponentFixture<EditEmpReactiveComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditEmpReactiveComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditEmpReactiveComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
