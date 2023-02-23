import { NgModule } from '@angular/core';
import { DynamicLayoutComponent } from '@abp/ng.core';
import { Routes, RouterModule } from '@angular/router';
import { LogCenterComponent } from './components/log-center.component';

const routes: Routes = [
  {
    path: '',
    pathMatch: 'full',
    component: DynamicLayoutComponent,
    children: [
      {
        path: '',
        component: LogCenterComponent,
      },
    ],
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class LogCenterRoutingModule {}
