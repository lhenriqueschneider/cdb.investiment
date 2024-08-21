import { TestBed } from '@angular/core/testing';
import { HttpClientTestingModule, HttpTestingController } from '@angular/common/http/testing';
import { cdbInvestmentService } from './cdb-investment.service';
import { cdbInvestmentModel } from '../models/cdb-investment.models';

describe('cdbInvestmentService', () => {
  let service: cdbInvestmentService;
  let httpMock: HttpTestingController;

  beforeEach(() => {
    TestBed.configureTestingModule({
      imports: [HttpClientTestingModule],
      providers: [cdbInvestmentService]
    });
    service = TestBed.inject(cdbInvestmentService);
    httpMock = TestBed.inject(HttpTestingController);
  });

  afterEach(() => {
    httpMock.verify();
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });

  it('should calculate CDB investment', () => {
    const monetaryValue = 1000;
    const mounth = 12;
    const expectedResponse: cdbInvestmentModel = {
      NetAmount: 1000,
      TotalAmount: 0.1
    };

    service.calculate(monetaryValue, mounth).subscribe(response => {
      expect(response.TotalAmount).toEqual(expectedResponse.TotalAmount);
    });

    const request = httpMock.expectOne(req => req.url === 'investment/calculateCdb' && req.method === 'GET' && req.params.get('monetaryValue') === '1000' && req.params.get('mounth') === '12');
    expect(request.request.method).toBe('GET');
    request.flush(expectedResponse);
  });
});
