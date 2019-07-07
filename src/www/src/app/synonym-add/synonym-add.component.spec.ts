import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SynonymAddComponent } from './synonym-add.component';

describe('SynonymAddComponent', () => {
  let component: SynonymAddComponent;
  let fixture: ComponentFixture<SynonymAddComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SynonymAddComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SynonymAddComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
