import { Component, OnInit } from '@angular/core';
import { Local } from 'protractor/built/driverProviders';

@Component({
  selector: 'app-contact',
  templateUrl: './contact.component.html',
  styleUrls: ['./contact.component.css']
})
export class ContactComponent implements OnInit{
  public submitted: boolean;
  private readonly _tokenKey = 'form_submitted';
  constructor() {
    this.submitted = false;
  }

  public ngOnInit() {
    if (localStorage.getItem(this._tokenKey) === "true") {
      this.submitted = true;
    }
  }

  public submitForm() {
    localStorage.setItem(this._tokenKey, "true");
    this.submitted = true;
  }
}
