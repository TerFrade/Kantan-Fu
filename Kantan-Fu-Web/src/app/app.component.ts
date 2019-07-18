import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {

  isAdmin: boolean = false;

  constructor() { }

  ngOnInit() {
    console.log("hello")
    this.isAdmin = localStorage.getItem("adminData") ? true : false;
  }

}
