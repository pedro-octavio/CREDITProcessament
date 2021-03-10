import { NgModule } from '@angular/core'
import { BrowserModule } from '@angular/platform-browser'

import { AppRoutingModule } from './app-routing.module'
import { AppComponent } from './app.component'

import { DashboardComponent } from './pages/dashboard/dashboard.component'
import { NavbarComponent } from './pages/shared/navbar/navbar.component'
import { FooterComponent } from './pages/shared/footer/footer.component'
import { BrowserAnimationsModule } from '@angular/platform-browser/animations'
import { AddNewUserComponent } from './pages/dialogs/add-new-user/add-new-user.component'
import { MatDialogModule } from '@angular/material/dialog'
import { ReactiveFormsModule } from '@angular/forms'


@NgModule({
  declarations: [
    AppComponent,
    DashboardComponent,
    NavbarComponent,
    FooterComponent,
    AddNewUserComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatDialogModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})

export class AppModule {

}
