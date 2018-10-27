import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Routes, RouterModule } from '@angular/router';

import { SignUpComponent } from '../../Components/Authorization/sign-up/sign-up.component';
import { SignInComponent } from '../../Components/Authorization/sign-in/sign-in.component';
import { HomeComponent } from '../../Components/Home/home/home.component';
import { Page404Component } from '../../Components/page404/page404.component';
import { DoctorListComponent } from '../../Components/DoctorList/doctor-list/doctor-list.component';
import { AdminPanelComponent } from '../../Components/adminpanel/adminpanel.component';

import { AuthGuard } from '../../Services/Guards/auth.guard';
import { PatientGuard } from '../../Services/Guards/patient.guard';
import { DoctorGuard } from '../../Services/Guards/doctor.guard';
import { ModeratorGuard } from '../../Services/Guards/moderator.guard';
import { AdminGuard } from '../../Services/Guards/admin.guard';

import { ADMIN_PANEL, DOCTOR_LIST, PAGE_404 } from '../../config';
import { SIGN_IN } from '../../config';
import { SIGN_UP } from '../../config';

const ROUTES: Routes = [
  { path: '', component: HomeComponent },
  { path: SIGN_UP, component: SignUpComponent },
  { path: SIGN_IN, component: SignInComponent },
  { path: PAGE_404, component: Page404Component },
  { path: DOCTOR_LIST, component: DoctorListComponent},
  { path: ADMIN_PANEL, component:AdminPanelComponent,canActivate: [AdminGuard]},

  { path: '**', redirectTo: '404' },
]

@NgModule({
  imports: [
    CommonModule,
    RouterModule.forRoot(ROUTES)
  ],
  declarations: [],
  exports: [RouterModule]
})
export class RoutingModule { }

export const ROUTING_COMPONENTS = [
  SignUpComponent,
  SignInComponent,
  HomeComponent,
  Page404Component,
  AdminPanelComponent,
  DoctorListComponent,
]
