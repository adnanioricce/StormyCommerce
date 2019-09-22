
export class ResetPasswordViewModel implements IResetPasswordViewModel {
    email!: string;
    password!: string;
    confirmPassword?: string | undefined;
    code?: string | undefined;

    constructor(data?: IResetPasswordViewModel) {
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
            this.code = data["code"];
        }
    }

    static fromJS(data: any): ResetPasswordViewModel {
        data = typeof data === 'object' ? data : {};
        let result = new ResetPasswordViewModel();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["email"] = this.email;
        data["password"] = this.password;
        data["confirmPassword"] = this.confirmPassword;
        data["code"] = this.code;
        return data; 
    }
}

export interface IResetPasswordViewModel {
    email: string;
    password: string;
    confirmPassword?: string | undefined;
    code?: string | undefined;
}
