import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.css']
})
export class RegisterComponent implements OnInit {

  public registrationFailMsg: any;

  constructor(
    private authService: AuthService,
    private router: Router
  ) { }

  ngOnInit(): void {
  }

  public registerForm = new FormGroup ({
    username: new FormControl('', [Validators.required]),
    nickname: new FormControl('', [Validators.required]),
    email: new FormControl('', [Validators.required]),
    firstName: new FormControl('', [Validators.required]),
    lastName: new FormControl('', [Validators.required]),
    password: new FormControl('', [Validators.required])
  })

  get username() {
    return this.registerForm.get('username');
  }
  get nickname() {
    return this.registerForm.get('username');
  }
  get email() {
    return this.registerForm.get('email');
  }
  get firstName() {
    return this.registerForm.get('firstName');
  }
  get lastName() {
    return this.registerForm.get('lastName');
  }
  get password() {
    return this.registerForm.get('password');
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

  register() {
    this.authService.register(this.registerForm.value).subscribe({
      next: () => {
        localStorage.setItem("isUserRegistred", JSON.stringify(true));
        this.router.navigate(['/login']);
      },
      error: (error) => {
        console.log(error);
        this.registrationFailMsg = 'Couldnt register';
      }
    });
  }

  resetRegistrationFailMsg() {
    this.registrationFailMsg = null;
  }

}