import { Address } from "../common/Address";

export class CustomerDto implements ICustomerDto {
    readonly userName?: string | undefined;
    readonly email?: string | undefined;
    readonly customerAddresses?: Address[] | undefined;
    readonly defaultBillingAddress?: Address | undefined;
    readonly defaultShippingAddress?: Address | undefined;
    readonly cpf?: string | undefined;
    readonly phoneNumber?: string | undefined;
    readonly fullName?: string | undefined;

    constructor(data?: ICustomerDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).userName = data["userName"];
            (<any>this).email = data["email"];
            if (Array.isArray(data["customerAddresses"])) {
                (<any>this).customerAddresses = [] as any;
                for (let item of data["customerAddresses"])
                    (<any>this).customerAddresses!.push(Address.fromJS(item));
            }
            (<any>this).defaultBillingAddress = data["defaultBillingAddress"] ? Address.fromJS(data["defaultBillingAddress"]) : <any>undefined;
            (<any>this).defaultShippingAddress = data["defaultShippingAddress"] ? Address.fromJS(data["defaultShippingAddress"]) : <any>undefined;
            (<any>this).cpf = data["cpf"];
            (<any>this).phoneNumber = data["phoneNumber"];
            (<any>this).fullName = data["fullName"];
        }
    }

    static fromJS(data: any): CustomerDto {
        data = typeof data === 'object' ? data : {};
        let result = new CustomerDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userName"] = this.userName;
        data["email"] = this.email;
        if (Array.isArray(this.customerAddresses)) {
            data["customerAddresses"] = [];
            for (let item of this.customerAddresses)
                data["customerAddresses"].push(item.toJSON());
        }
        data["defaultBillingAddress"] = this.defaultBillingAddress ? this.defaultBillingAddress.toJSON() : <any>undefined;
        data["defaultShippingAddress"] = this.defaultShippingAddress ? this.defaultShippingAddress.toJSON() : <any>undefined;
        data["cpf"] = this.cpf;
        data["phoneNumber"] = this.phoneNumber;
        data["fullName"] = this.fullName;
        return data; 
    }
}

export interface ICustomerDto {
    userName?: string | undefined;
    email?: string | undefined;
    customerAddresses?: Address[] | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultShippingAddress?: Address | undefined;
    cpf?: string | undefined;
    phoneNumber?: string | undefined;
    fullName?: string | undefined;
}