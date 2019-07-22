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

  adminCreateType: string;

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

  adminDetails: any = {
    name: "Boetie",
    username: "",
    password: ""
  };

  badLogin: boolean = false;

  constructor(private dialogRef: MatDialogRef<AdminLoginComponent>, private location: Location) { }

  login() {
    if (btoa(this.adminDetails.username) != "RGFycmVs" && btoa(this.adminDetails.password) != "MjU2ODRtZ3Q=") {
      this.badLogin = true;
    } else {
      localStorage.setItem("adminDetails", JSON.stringify(this.adminDetails));
      window.location.reload();
      this.dialogRef.close();
    }
  }

  back() {
    this.location.back();
  }
}
