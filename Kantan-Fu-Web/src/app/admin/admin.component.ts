import { Component, OnInit } from '@angular/core';
import { MatDialog, MatDialogRef } from '@angular/material/dialog';
import { Location } from '@angular/common';
import { toBase64String } from '@angular/compiler/src/output/source_map';

@Component({
  selector: 'app-admin',
  templateUrl: './admin.component.html',
  styleUrls: ['./admin.component.scss']
})

export class AdminComponent implements OnInit {
  adminDetails: any;

  constructor(private dialog: MatDialog) { }

  ngOnInit() {
    this.adminDetails = localStorage.getItem("adminData") ? JSON.parse(localStorage.getItem("adminData")) : false;

    if (!this.adminDetails) {
      this.dialog.open(AdminLoginComponent, {
        disableClose: true,
        autoFocus: false,
        width: '500px;'
      });
    }
  }
}














//Admin Login Dialog Class
@Component({
  templateUrl: './admin-login.component.html',
  styleUrls: ['./admin.component.scss']
})
export class AdminLoginComponent {

  adminData: any = {
    name: "Boetie",
    username: "",
    password: ""
  };

  badLogin: boolean = false;

  constructor(private dialogRef: MatDialogRef<AdminLoginComponent>, private location: Location) { }

  login() {
    if (btoa(this.adminData.username) != "RGFycmVs" && btoa(this.adminData.password) != "MjU2ODRtZ3Q=") {
      this.badLogin = true;
    } else {
      localStorage.setItem("adminData", JSON.stringify(this.adminData));
      this.dialogRef.close();
    }
  }

  back() {
    this.location.back();
  }
}
