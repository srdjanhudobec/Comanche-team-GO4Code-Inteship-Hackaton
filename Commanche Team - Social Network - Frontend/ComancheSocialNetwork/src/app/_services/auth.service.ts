import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable, tap } from 'rxjs';
import { Router } from '@angular/router';
import { LoggedInUser } from '../_model/loggedInUser.model';
import { User } from '../_model/user.model';


export interface AuthResponse {
  token: string,
  expiration: string,
  u: User
}

type User1 = {
  username?: string | null | undefined;
  password?: string | null;
};

type User2 = {
  username?: string | null | undefined;
  password?: string | null;
  nickname?: string | null;
  firstName?: string | null;
  lastName?: string | null;
  email?: string | null;
};

type PartialUser = Partial<{ username: string | null; password: string | null; }>;


@Injectable({
  providedIn: 'root'
})
export class AuthService {

  host = 'http://localhost:5204/api/Auth/';

  user: BehaviorSubject<LoggedInUser | null> = new BehaviorSubject<LoggedInUser | null>(null);

  constructor(
    private http: HttpClient,
    private router: Router
  ) { }

  public login(loginData: User1): Observable<AuthResponse> {
    return this.http.post<AuthResponse>(this.host + 'login', loginData).pipe(tap((data) => {
      let loggedInUser = new LoggedInUser(data.token, data.expiration, data.u);
      this.user.next(loggedInUser);
      localStorage.setItem('user', JSON.stringify(data));
    }));
  }

  public register(registerData: User2): Observable<LoggedInUser> {
    return this.http.post<any>(this.host + 'register-user', registerData);
  }

  loginAuto() {
    let user = localStorage.getItem('user');
    if (user) {
      let userJson: LoggedInUser = JSON.parse(user);
      this.user.next(userJson);
    }
  }

  logout() {
    localStorage.removeItem('user');
    this.user.next(null);
    this.router.navigate(['/login']);
  }

}
