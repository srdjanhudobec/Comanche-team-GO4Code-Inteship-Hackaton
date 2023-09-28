import { User } from "./user.model";

export class LoggedInUser {
    
    constructor(private _token: string, private _expiration: string, private _user: User){}

    get token() {
        return this._token;
    }

    get user() {
        return this._user;
    }
}