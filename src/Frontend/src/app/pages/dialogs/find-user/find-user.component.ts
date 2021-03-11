import { Component, OnInit } from '@angular/core'
import { FormBuilder, FormGroup, Validators } from '@angular/forms'
import { MatDialogRef } from '@angular/material/dialog'

import { ToastrService } from 'ngx-toastr'
import { FindUserByCPFRequestModel } from 'src/app/models/requestModels/FindUserByCPFRequestModel'
import { UserValidator } from '../../validators/UserValidator'

@Component({
  selector: 'app-find-user',
  templateUrl: './find-user.component.html',
  styleUrls: ['./find-user.component.css',
    '../../../../assets/css/elements.css',
    '../../../../assets/css/margin.css',
    '../../../../assets/css/buttons.css',
    '../../../../assets/css/font-size.css',
    '../../../../assets/css/width.css',
    '../../../../assets/css/text-align.css',
    '../../../../assets/css/shared.css']
})

export class FindUserComponent implements OnInit {
  constructor(private dialogRef: MatDialogRef<FindUserComponent>, private formBuilder: FormBuilder, private toastrService: ToastrService) {

  }

  userForm: FormGroup

  user: FindUserByCPFRequestModel

  ngOnInit(): void {
    this.createFindUserForm()
  }

  createFindUserForm(): void {
    this.userForm = this.formBuilder.group({
      cpf: ['', Validators.compose([
        Validators.required,
        UserValidator.CPFValidation
      ])]
    })
  }

  find(): void {
    const formData = this.userForm.value

    const user = new FindUserByCPFRequestModel(formData.cpf)

    this.toastrService.info('User Found Successfully.', 'User')

    this.dialogRef.close()
  }

  get cpf(): any {
    return this.userForm.get('cpf')
  }
}
