import { NgModule } from '@angular/core'
import { CommonModule } from '@angular/common'
import { ReactiveFormsModule } from '@angular/forms'
import { MatDialogModule } from '@angular/material/dialog'
import { BrowserModule } from '@angular/platform-browser'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'

import { NgxLoadingModule } from 'ngx-loading'
import { ToastrModule } from 'ngx-toastr'

import { AppRoutingModule } from './app-routing.module'
import { AppComponent } from './app.component'

import { DashboardComponent } from './pages/dashboard/dashboard.component'

import { AddNewUserComponent } from './pages/dialogs/add-new-user/add-new-user.component'
import { FindUserComponent } from './pages/dialogs/find-user/find-user.component'

import { FooterComponent } from './pages/shared/footer/footer.component'
import { NavbarComponent } from './pages/shared/navbar/navbar.component'
import { LoaderComponent } from './pages/shared/loader/loader.component'

@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    NavbarComponent,
    FooterComponent,
    AddNewUserComponent,
    FindUserComponent,
    LoaderComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CommonModule,
    MatDialogModule,
    NgxLoadingModule.forRoot({
      fullScreenBackdrop: true
    }),
    ReactiveFormsModule,
    ToastrModule.forRoot()
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule {

}
