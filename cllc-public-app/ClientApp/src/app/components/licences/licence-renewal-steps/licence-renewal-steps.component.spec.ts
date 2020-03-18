import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { LicenceRenewalStepsComponent } from './licence-renewal-steps.component';
import { NO_ERRORS_SCHEMA } from '@angular/core';
import { FeatureFlagService } from '@services/feature-flag.service';
import { of } from 'rxjs';
import { MatIconModule } from '@angular/material';

describe('LicenceRenewalStepsComponent', () => {
  let component: LicenceRenewalStepsComponent;
  let fixture: ComponentFixture<LicenceRenewalStepsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [LicenceRenewalStepsComponent],
      imports:[MatIconModule,],
      providers: [
        { provide: FeatureFlagService, useValue: { featureOn: () => of(true) } }
      ],
      schemas: [NO_ERRORS_SCHEMA]
    })
      .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(LicenceRenewalStepsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
