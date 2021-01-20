import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MoviesComponent } from './movies.component';
import { RouterModule, Routes } from '@angular/router';

const MoviesRoutes: Routes = [
  {path: 'movies', component: MoviesComponent}
]

@NgModule({
  declarations: [],
  imports: [
    CommonModule,
    RouterModule.forRoot(MoviesRoutes)
  ]
})
export class MoviesModule { }
