import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { Observable } from 'rxjs';
import { ApiService } from './api.service';
//import {ToastrService} from 'ngx-toastr';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  private readonly url = 'api/auth';
  private readonly endpoint = 'auth';
  constructor(private apiService: ApiService,
              private router: Router
              //private toastService: ToastrService) 
              ){ }

  isAuthenticated(){

    return this.apiService.get(this.url + '/isAuth');
  }

  /*
  login(userCredentials): Observable<any> {
    return this.apiService.post<any>('${this.endpoint}/login', userCredentials).pipe(
      map((response: any) => {
        if (response.success) {
          localStorage.setItem('userProfile', response.userProfile);
        }
      })
    );
  }

  isLoggedIn(): boolean {
    const userProfile = localStorage.getItem('userProfile');
    console.log(userProfile);
    return !!userProfile;
  }

  logout() {
    this.apiService.post<any>('${this.endpoint}/logout', null)
      .subscribe(response => {
        if (response.success) {
          this.onLogoutSuccess();
        }
      }, () => {
        this.toastService.error('Logout unsuccessful.');
      });
  }

  onLogoutSuccess(): void {
    localStorage.removeItem('userProfile');
    this.router.navigate(['auth/login']);
  }

  updatePassword(passwordInfo): Observable<any> {
    return this.apiService.put<any>('${this.endpoint}/change-password', passwordInfo);
  }

  forgotPassword(email): Observable<any> {
    return this.apiService.post<any>('${this.endpoint}/forgot-password', email);
  }

  resetPassword(newPasswordInfo): Observable<any> {
    return this.apiService.put('${this.endpoint}/reset-password', newPasswordInfo);
  }

  deleteAccount(): Observable<any> {
    return this.apiService.post('${this.endpoint}/remove-account');
  }

  register(userData): Observable<any> {
    return this.apiService.post<any>('${this.endpoint}/register', userData).pipe(
      map((response: any) =>{
        if(response.succes) {
          localStorage.setItem('userProfile', response.userProfile);
        }
      })
    );
  }
*/
}
