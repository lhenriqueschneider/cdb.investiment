
import { Observable, retry } from 'rxjs';
import { Injectable } from '@angular/core';
import * as CdbInvestmentConstants from '../constants/cbd-investment.constants';
import { cdbInvestmentModel } from '../models/cdb-investment.models';
import { HttpClient, HttpParams } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class cdbInvestmentService {


  private readonly cbdInvestmentCalculate = 'investment/calculateCdb'

  constructor(private httpClient: HttpClient) { }

  calculate(monetaryValue: number, mounth: number): Observable<cdbInvestmentModel> {


    let url = CdbInvestmentConstants.baseAdress + this.cbdInvestmentCalculate;

    let params = new HttpParams();
    params = params.append('monetaryValue', monetaryValue);
    params = params.append('mounth', mounth);


    return this.httpClient.get<cdbInvestmentModel>(url, { params: params }).pipe(retry(2));
  }
}
