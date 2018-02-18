import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';

import { catchError, map, tap } from 'rxjs/operators';
import { Observable } from 'rxjs/Observable';
import { of } from 'rxjs/observable/of';

import { Form } from '../app-data/form';
import { Ctrl } from '../app-data/ctrl';

const httpOptions = {
  	headers: new HttpHeaders({ 'Content-Type': 'application/json' })
};

@Injectable()

export class WizardService {
	private formsUrl = 'api/wizard/getAllForms';

  constructor(private http: HttpClient) { }
	
  getForms(): Observable<Form[]> {
    return this.http.get<Form[]>(this.formsUrl)
    					 .pipe(tap(forms=> this.log('fetched forms')), catchError(this.handleError('getForms', []))
    );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {
 
      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead
 
      // TODO: better job of transforming error for user consumption
      this.log(`${operation} failed: ${error.message}`);
 
      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }

  private log(message: string) {
    //this.messageService.add('HeroService: ' + message);
  }
}