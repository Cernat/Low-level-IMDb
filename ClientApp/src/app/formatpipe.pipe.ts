import { Pipe, PipeTransform } from '@angular/core';
import { Person } from './movies/movies.component';
import * as _ from 'lodash';

@Pipe({
  name: 'formatpipe'
})
export class FormatpipePipe implements PipeTransform {

  
  transform(value: Array<Person>, by: string, direction: "asc"): Array<Person> {
    value = _.orderBy(value, [by], direction);
    return value;
  }
  

  /*
 transform(value: string): string {
  return value + 'a vizionat';
 }
  */

}
