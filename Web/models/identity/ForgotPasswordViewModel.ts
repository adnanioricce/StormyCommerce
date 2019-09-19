
export class ForgotPasswordViewModel implements IForgotPasswordViewModel {
    email!: string;

    constructor(data?: IForgotPasswordViewModel) {
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
        }
    }

    static fromJS(data: any): ForgotPasswordViewModel {
        data = typeof data === 'object' ? data : {};
        let result = new ForgotPasswordViewModel();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["email"] = this.email;
        return data; 
    }
}

export interface IForgotPasswordViewModel {
    email: string;
}
