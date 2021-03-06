import { Component, EventEmitter, Input, OnInit, Output, ViewChild } from '@angular/core';
import { AbstractControl, FormBuilder, FormGroup, FormGroupDirective, ValidatorFn, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { PolicyDocumentComponent } from '@components/policy-document/policy-document.component';
import { Account } from '@models/account.model';
import { SepApplication } from '@models/sep-application.model';
import { IndexDBService } from '@services/index-db.service';
import { FormBase } from '@shared/form-base';
import { Observable } from 'rxjs';
import { from } from 'rxjs/internal/observable/from';
import { of } from 'rxjs/internal/observable/of';
import { map } from 'rxjs/operators';

@Component({
  selector: 'app-applicant',
  templateUrl: './applicant.component.html',
  styleUrls: ['./applicant.component.scss']
})
export class ApplicantComponent implements OnInit {
  policySlug = "sep-terms-and-conditions";
  @ViewChild("policyDocs", { static: true })
  policyDocs: PolicyDocumentComponent;
  @Input() account: Account;
  _app: SepApplication = {} as SepApplication;
  @Input()
  set application(value) {
    this._app = value;
    if (this.form) {
      this.form.patchValue(value);
    }
  };
  get application() {
    return this._app;
  }
  @Output()
  saveComplete = new EventEmitter<boolean>();
  form: FormGroup;


  constructor(private fb: FormBuilder,
    private router: Router,
    private ctrlContainer: FormGroupDirective,
    private db: IndexDBService) {
  }

  ngOnInit(): void {
    this.form = this.fb.group({
      eventName: ['', [Validators.required]],
      applicantInfo: [''],
      agreeToTnC: ['', [this.customRequiredCheckboxValidator()]],
      dateAgreedToTnC: ['']
    });

    this.ctrlContainer.form.addControl("eligibility", this.form);

    if (this.application) {
      this.form.patchValue(this.application);
    }

    this.form.get('agreeToTnC').valueChanges
      .subscribe((agree: boolean) => {
        if (agree) {
          this.form.get('dateAgreedToTnC').setValue(new Date());
        }
      });

    this.policyDocs.setSlug(this.policySlug);
  }

  customRequiredCheckboxValidator(): ValidatorFn {
    return (control: AbstractControl): { [key: string]: any } | null => {
      if (control.value === true) {
        return null;
      } else {
        return { 'shouldBeTrue': 'But value is false' };
      }
    };
  }

  isValid(){
    this.form.markAsTouched();
    return this.form.valid;
  }

  save(): Observable<number> {
    const data = {
      ...this.application,
      lastUpdated: new Date(),
      status: 'unsubmitted',
      stepsCompleted: (steps =>{
        const step = 'applicant';
        if(steps.indexOf(step) === -1){
          steps.push(step);
        }
        return steps;
      })(this?.application?.stepsCompleted || []),
      contact: {
        firstname: this?.account?.primarycontact?.firstname,
        lastname: this?.account?.primarycontact?.lastname,
        address1_line1: this?.account?.primarycontact?.address1_line1,
        address1_city: this?.account?.primarycontact?.address1_city,
        address1_stateorprovince: this?.account?.primarycontact?.address1_stateorprovince,
        address1_postalcode: this?.account?.primarycontact?.address1_postalcode,

        telephone1: this?.account?.primarycontact?.telephone1,
        emailaddress1: this?.account?.primarycontact?.emailaddress1,
      },
      ...this.form.value
    } as SepApplication;

    if (data.id) {
      this.db.applications.update(data.id, data);
      return of(data.id);
    } else {
      data.dateCreated = new Date();
      return from(this.db.addSepApplication(data));
    }
  }

  next(){  
    if(this.isValid()){
      this.save().subscribe((appId: number) => {
        this.router.navigateByUrl(`/sep/application/${appId}/eligibility`);
      });
    }
  }

  saveForLater(){  
      this.save()
      .subscribe( id => {
        this.router.navigateByUrl('/sep/my-applications')
      });
  }
}
