
export class SignUpVm implements ISignUpVm {
    email!: string;
    password!: string;
    confirmPassword?: string | undefined;
    userName?: string | undefined;

    constructor(data?: ISignUpVm) {
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
            this.confirmPassword = data["confirmPassword"];
            this.userName = data["userName"];
        }
    }

    static fromJS(data: any): SignUpVm {
        data = typeof data === 'object' ? data : {};
        let result = new SignUpVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["email"] = this.email;
        data["password"] = this.password;
        data["confirmPassword"] = this.confirmPassword;
        data["userName"] = this.userName;
        return data; 
    }
}

export interface ISignUpVm {
    email: string;
    password: string;
    confirmPassword?: string | undefined;
    userName?: string | undefined;
}