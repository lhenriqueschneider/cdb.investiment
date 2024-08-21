import { Component, OnInit } from '@angular/core';
import { cdbInvestmentService } from './services/cdb-investment.service';
import { cdbInvestmentModel } from './models/cdb-investment.models';
import { AbstractControl, FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  protected checkoutForm = this.formBuilder.group({
    monetaryValue: [0, Validators.required],
    mounth: [0, Validators.required]
  });

  protected cdbInvestimentResponse: cdbInvestmentModel = {
    NetAmount: 0,
    TotalAmount: 0
  }
  title = 'Cdb.Investment.Web'

  ngOnInit() {
  }

  constructor(
    private cdbInvestmentService: cdbInvestmentService,
    private formBuilder: FormBuilder

  ) {
  }

  // Method to calculate the investment
  protected calculateInvestment() {

    let resultForm = this.checkoutForm.value;

    let monetaryValue = Number(resultForm.monetaryValue);
    let mounth = Number(resultForm.mounth);

    if (monetaryValue <= 0) {
      alert('O valor monetário tem que ser maior positivo'); return;
    }

    if (mounth <= 0) {
      alert('Necessário informar um prazo maior ou igual a 1'); return;
    }

    this.cdbInvestmentService.calculate(monetaryValue, mounth).subscribe(data => {
      this.cdbInvestimentResponse = data;
    });
  }
}
