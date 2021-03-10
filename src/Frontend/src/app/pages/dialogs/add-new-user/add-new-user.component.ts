import { Component, OnInit } from '@angular/core'
import { FormBuilder, FormGroup, Validators } from '@angular/forms'

import { AddUserRequestModel } from 'src/app/models/requestModels/AddUserRequestModel'
import { AddUserValidator } from '../../validators/addUserValidator'

@Component({
  selector: 'app-add-new-user',
  templateUrl: './add-new-user.component.html',
  styleUrls: ['./add-new-user.component.css']
})

export class AddNewUserComponent implements OnInit {
  constructor(private formBuilder: FormBuilder) {

  }

  userForm: FormGroup

  user: AddUserRequestModel

  ngOnInit(): void {
    this.createUserForm()
  }

  createUserForm(): void {
    this.userForm = this.formBuilder.group({
      cpf: ['', Validators.compose([
        Validators.required,
        AddUserValidator.CPFValidation
      ])],
      name: ['', Validators.compose([
        Validators.required,
        Validators.maxLength(120)
      ])]
    })
  }

  add(): void {
    const formData = this.userForm.value

    const user = new AddUserRequestModel(formData.cpf, formData.name)

    console.log(user)

    this.userForm.reset()
  }

  get cpf(): any {
    return this.userForm.get('cpf')
  }

  get name(): any {
    return this.userForm.get('name')
  }
}
