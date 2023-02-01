import { ComponentFixture, TestBed } from '@angular/core/testing';

import { HandMadeComponent } from './hand-made.component';

describe('HandMadeComponent', () => {
  let component: HandMadeComponent;
  let fixture: ComponentFixture<HandMadeComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ HandMadeComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(HandMadeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
