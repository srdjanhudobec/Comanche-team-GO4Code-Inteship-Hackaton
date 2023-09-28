import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthResponse, AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  

  public loginFailMsg: any;
  public registeredUser: any;

  constructor(
    private authService: AuthService,
    private router: Router
  ) {}

  ngOnInit(): void {
    if (localStorage.getItem("registeredUser") != null) {
      this.registeredUser = JSON.parse(localStorage.getItem("registeredUser")!);
    }
  }

  login() {
    this.authService.login(this.loginForm.value).subscribe({
      next: (response: AuthResponse) => {
        this.router.navigateByUrl('/posts');
      },
      error: (error) => {
        console.log(error);
        if (error.status === 401) {
          this.loginFailMsg = "The username or password is incorrect!"
        }
      }
    });
  }

  public loginForm = new FormGroup ({
    username: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required])
  })

  get username() {
    return this.loginForm.get('username');
  }
  get password() {
    return this.loginForm.get('password');
  }

  isValid(input: any): boolean {
    if (input) {
      if (input.valid && input.touched) {
        return true;
      }
    }
    return false;
  }

  isInvalid(input: any): boolean {
    if (input) {
      if (input.invalid && input.touched) {
        return true;
      }
    }
    return false;
  }

  ngOnDestroy() {
    this.resetRegisteredUser();
    this.loginFailMsg = null;
  }

  resetRegisteredUser() {
    this.registeredUser = null;
    localStorage.removeItem("registeredUser");
  }

  resetloginFailMsg() {
    this.loginFailMsg = null;
  }

}
