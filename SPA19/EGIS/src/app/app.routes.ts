import { Routes } from '@angular/router';
import { MasterCodeComponent } from './toims/master-code/master-code.component';
import { DashboardComponent } from './toims/dashboard/dashboard/dashboard.component';
import { MasterSubcodeComponent } from './toims/master-subcode/master-subcode/master-subcode.component';

export const routes: Routes = [
  {
    path :'',
    component: DashboardComponent
  }
  ,
  {
    path : "master",
    component : MasterCodeComponent
  },
  {
    path : "mastersubcode",
    component: MasterSubcodeComponent
  }
];
