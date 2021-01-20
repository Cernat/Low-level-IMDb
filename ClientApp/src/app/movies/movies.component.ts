import { Component, OnInit } from '@angular/core';

export interface Person {
  name: string;
  age: number;
  height: number;
  weight: number;
}
export const People: Array<Person> = [
  { name: 'Allen', age: 26, height: 150, weight: 88 },
  { name: 'Beth', age: 40, height: 144, weight: 70 },
  { name: 'Tara', age: 16, height: 159, weight: 58 },
  { name: 'Zach', age: 31, height: 193, weight: 72 }
]

@Component({
  selector: 'app-movies',
  templateUrl: './movies.component.html',
  styleUrls: ['./movies.component.css']
})
export class MoviesComponent implements OnInit {

  people: Array<Person>;
  todaysDate: Date;

  constructor() { 
    this.todaysDate = new Date();
   this.people = People;
  }

  ngOnInit() {
  }



}
