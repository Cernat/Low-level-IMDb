import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { AuthService } from '../services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  public text: string = "test text";
  public inputValue: string;

  /*
  public loginForm = this.fb.group({
    Email: ['', Validators.email],
    Password: ['', Validators.required]
  });
  */
  public dateNow = new Date();

  constructor(
    //private fb: FormBuilder,
    private authenticationService: AuthService,
    private router: Router,
    //private toastService: ToastrService,
    private route: ActivatedRoute
    ) { }

  ngOnInit() {
  }

  changeText(value: string){
    this.text = value;
  }

  changeTextFromInput(){
    this.text = this.inputValue;
  }

  /*
  login() {
    this.authenticationService.login(this.loginForm.value).subscribe(data => {
      console.log('Successfully logged in.', data);
          this.router.navigateByUrl('movies');
    });
  }
 */
}
