
export class SignInVm implements ISignInVm {
    email!: string;
    password!: string;
    username?: string | undefined;

    constructor(data?: ISignInVm) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.email = data["email"];
            this.password = data["password"];
            this.username = data["username"];
        }
    }

    static fromJS(data: any): SignInVm {
        data = typeof data === 'object' ? data : {};
        let result = new SignInVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["email"] = this.email;
        data["password"] = this.password;
        data["username"] = this.username;
        return data; 
    }
}

export interface ISignInVm {
    email: string;
    password: string;
    username?: string | undefined;
}