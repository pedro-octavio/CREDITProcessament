import { Component, OnInit } from '@angular/core'
import { FormBuilder } from '@angular/forms'
import { MatDialogRef } from '@angular/material/dialog'

import { ToastrService } from 'ngx-toastr'

@Component({
  selector: 'app-find-user',
  templateUrl: './find-user.component.html',
  styleUrls: ['./find-user.component.css']
})

export class FindUserComponent implements OnInit {
  constructor(private dialogRef: MatDialogRef<FindUserComponent>, private formBuilder: FormBuilder, private toastrService: ToastrService) {

  }

  ngOnInit(): void {

  }
}
