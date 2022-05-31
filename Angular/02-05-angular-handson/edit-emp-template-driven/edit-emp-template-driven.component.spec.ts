import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditEmpTemplateDrivenComponent } from './edit-emp-template-driven.component';

describe('EditEmpTemplateDrivenComponent', () => {
  let component: EditEmpTemplateDrivenComponent;
  let fixture: ComponentFixture<EditEmpTemplateDrivenComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditEmpTemplateDrivenComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditEmpTemplateDrivenComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
