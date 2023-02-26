import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Customer } from 'src/app/models/customer.model';
import { CustomersService } from 'src/app/services/customers.service';

@Component({
  selector: 'app-manage-clients',
  templateUrl: './manage-clients.component.html',
  styleUrls: ['./manage-clients.component.css']
})
export class ManageClientsComponent implements OnInit {

  customers: Customer[] = [];

  // addingVisibility: boolean = false;

  constructor(private customersService: CustomersService, private router: Router) { }

  ngOnInit(): void {
    this.customersService.getAllCustomers()
      .subscribe({
        next: (customers) => {
          this.customers = customers;
        }
      })

  }

}
