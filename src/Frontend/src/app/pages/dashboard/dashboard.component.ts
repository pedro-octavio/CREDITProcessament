import { Component, OnInit } from '@angular/core'
import { MatDialog } from '@angular/material/dialog'

import { GetAllUsersResponseModel } from 'src/app/models/responseModels/GetAllUsersResponseModel'

import { AddNewUserComponent } from '../dialogs/add-new-user/add-new-user.component'
import { FindUserComponent } from '../dialogs/find-user/find-user.component'

@Component({
  selector: 'app-dashboard',
  templateUrl: './dashboard.component.html',
  styleUrls: ['./dashboard.component.css']
})

export class DashboardComponent implements OnInit {
  constructor(private dialog: MatDialog) {

  }

  users: GetAllUsersResponseModel[]

  ngOnInit(): void {
    this.users = [
      { name: 'Fernando Marcos Vinicius da Luz', cpf: '95592318049' },
      { name: 'Sandra Eloá Vanessa da Silva', cpf: '25028704961' },
      { name: 'Pedro Henrique Renato Antonio Ramos', cpf: '05018869585' },
      { name: 'Antonio Gustavo Porto', cpf: '94784584727' },
      { name: 'Calebe Juan Moreira', cpf: '98954405967' },
      { name: 'Esther Tatiane Figueiredo', cpf: '73467889905' },
      { name: 'Miguel Cláudio Lorenzo Castro', cpf: '21717101445' },
      { name: 'Regina Isabela Larissa Moreira', cpf: '00621343706' },
      { name: 'Manoel Theo Ribeiro', cpf: '00621343706' },
      { name: 'César Lucas Enzo Jesus', cpf: '17098943185' },
      { name: 'Giovanni Victor Cardoso', cpf: '09216712376' },
      { name: 'Vanessa Elza Freitas', cpf: '93680444060' },
      { name: 'Luís Luiz Nicolas Jesus', cpf: '92293953408' },
      { name: 'Felipe Luís Cauê Araújo', cpf: '48833940420' },
    ]
  }

  openAddNewUserDialog(): void {
    this.dialog.open(AddNewUserComponent, {
      width: '450px'
    })
  }

  openFindUser(): void {
    this.dialog.open(FindUserComponent, {
      width: '450px'
    })
  }
}
