import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NFLDivisionsComponent } from './nfldivisions.component';

describe('NfldivisionsComponent', () => {
  let component: NFLDivisionsComponent;
  let fixture: ComponentFixture<NFLDivisionsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NFLDivisionsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NFLDivisionsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
