import { Injectable } from '@angular/core';
import { Http, Headers, Response } from '@angular/http';
import { Observable } from 'rxjs';
import { HttpHeaders, HttpClient } from '@angular/common/http';
import { debounce, catchError } from 'rxjs/operators';
import { DataService } from './data.service';
import { LegalEntity } from '@models/legal-entity.model';

@Injectable()
export class LegalEntityDataService extends DataService {

  headers: HttpHeaders = new HttpHeaders({
    'Content-Type': 'application/json'
  });

  constructor(private http: HttpClient) {
    super();
  }

  /**
   * Get legal entities from Dynamics filtered by position
   * @param positionType
   */
  getLegalEntitiesbyPosition(parentLegalEntityId, positionType: string) {
    const apiPath = `api/legalentities/position/${parentLegalEntityId}/${positionType}`;
    return this.http.get<LegalEntity[]>(apiPath, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  getBusinessProfileSummary() {
    const apiPath = 'api/legalentities/business-profile-summary/';
    return this.http.get<LegalEntity[]>(apiPath, { headers: this.headers })
      .pipe(catchError(this.handleError));

  }

  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createLegalEntity(data: LegalEntity) {
    return this.http.post<LegalEntity>('api/legalentities/', data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * update a  legal entity in Dynamics
   * @param data - legal entity data
   */
  updateLegalEntity(data: LegalEntity, id: string) {
    return this.http.put<LegalEntity>(`api/legalentities/${id}`, data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * delete a  legal entity in Dynamics
   * @param data - legal entity data
   */
  deleteLegalEntity(id: string) {
    return this.http.post<LegalEntity>(`api/legalentities/${id}/delete`, {}, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }


  /**
   * Create a new legal entity in Dynamics
   * @param data - legal entity data
   */
  createChildLegalEntity(data: LegalEntity) {
    return this.http.post<LegalEntity>('api/legalentities/child-legal-entity', data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }

  /**
   * Send a consent request to the emails received as parameter
   * @param data - array of emails
   */
  sendConsentRequestEmail(data: string[]) {
    const legalEntityId: string = data[0];
    const apiPath = 'api/legalentities/' + legalEntityId + '/sendconsentrequests';
    return this.http.post(apiPath, data, { headers: this.headers })
      .pipe(catchError(this.handleError));
  }
}
