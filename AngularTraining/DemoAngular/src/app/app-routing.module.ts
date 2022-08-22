import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TestAComponent } from './test-a/test-a.component';
import { TestBComponent } from './test-b/test-b.component';
import { TestCComponent } from './test-c/test-c.component';

const routes: Routes = [
  { path: 'TestA', component: TestAComponent },
  { path: 'TestB', component: TestBComponent },
  { path: 'dashboard', component: TestCComponent },
  { path: '',   redirectTo: '/dashboard', pathMatch: 'full' },
  { path: '**', component: TestCComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
