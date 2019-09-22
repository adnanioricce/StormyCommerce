
export class Address implements IAddress {
    street?: string | undefined;
    firstAddress?: string | undefined;
    secondAddress?: string | undefined;
    city?: string | undefined;
    district?: string | undefined;
    state?: string | undefined;
    postalCode?: string | undefined;
    number?: string | undefined;
    complement?: string | undefined;
    phoneNumber?: string | undefined;
    country?: string | undefined;
    whoReceives?: string | undefined;
    ownerId?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IAddress) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.street = data["street"];
            this.firstAddress = data["firstAddress"];
            this.secondAddress = data["secondAddress"];
            this.city = data["city"];
            this.district = data["district"];
            this.state = data["state"];
            this.postalCode = data["postalCode"];
            this.number = data["number"];
            this.complement = data["complement"];
            this.phoneNumber = data["phoneNumber"];
            this.country = data["country"];
            this.whoReceives = data["whoReceives"];
            this.ownerId = data["ownerId"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Address {
        data = typeof data === 'object' ? data : {};
        let result = new Address();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["street"] = this.street;
        data["firstAddress"] = this.firstAddress;
        data["secondAddress"] = this.secondAddress;
        data["city"] = this.city;
        data["district"] = this.district;
        data["state"] = this.state;
        data["postalCode"] = this.postalCode;
        data["number"] = this.number;
        data["complement"] = this.complement;
        data["phoneNumber"] = this.phoneNumber;
        data["country"] = this.country;
        data["whoReceives"] = this.whoReceives;
        data["ownerId"] = this.ownerId;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IAddress {
    street?: string | undefined;
    firstAddress?: string | undefined;
    secondAddress?: string | undefined;
    city?: string | undefined;
    district?: string | undefined;
    state?: string | undefined;
    postalCode?: string | undefined;
    number?: string | undefined;
    complement?: string | undefined;
    phoneNumber?: string | undefined;
    country?: string | undefined;
    whoReceives?: string | undefined;
    ownerId?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}
