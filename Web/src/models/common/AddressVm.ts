
export default class AddressVm implements IAddressVm {
    city?: string | undefined;
    cpf?: string | undefined;
    complement?: string | undefined;
    firstAddress?: string | undefined;
    phoneNumber?: string | undefined;
    postalCode?: string | undefined;
    secondAddress?: string | undefined;
    state?: string | undefined;
    street?: string | undefined;
    whoReceives?: string | undefined;
    number?: string | undefined;

    constructor(data?: IAddressVm) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.city = data["city"];
            this.cpf = data["cpf"];
            this.complement = data["complement"];
            this.firstAddress = data["firstAddress"];
            this.phoneNumber = data["phoneNumber"];
            this.postalCode = data["postalCode"];
            this.secondAddress = data["secondAddress"];
            this.state = data["state"];
            this.street = data["street"];
            this.whoReceives = data["whoReceives"];
            this.number = data["number"];
        }
    }

    static fromJS(data: any): AddressVm {
        data = typeof data === 'object' ? data : {};
        let result = new AddressVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["city"] = this.city;
        data["cpf"] = this.cpf;
        data["complement"] = this.complement;
        data["firstAddress"] = this.firstAddress;
        data["phoneNumber"] = this.phoneNumber;
        data["postalCode"] = this.postalCode;
        data["secondAddress"] = this.secondAddress;
        data["state"] = this.state;
        data["street"] = this.street;
        data["whoReceives"] = this.whoReceives;
        data["number"] = this.number;
        return data; 
    }
}

export interface IAddressVm {
    city?: string | undefined;
    cpf?: string | undefined;
    complement?: string | undefined;
    firstAddress?: string | undefined;
    phoneNumber?: string | undefined;
    postalCode?: string | undefined;
    secondAddress?: string | undefined;
    state?: string | undefined;
    street?: string | undefined;
    whoReceives?: string | undefined;
    number?: string | undefined;
}