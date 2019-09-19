export class StormyVendor implements IStormyVendor {
    companyName?: string | undefined;
    contactTitle?: string | undefined;
    addressId?: number | undefined;
    address?: Address | undefined;
    phone?: string | undefined;
    email?: string | undefined;
    webSite?: string | undefined;
    typeGoods?: string | undefined;
    sizeUrl?: string | undefined;
    logo?: string | undefined;
    note?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IStormyVendor) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.companyName = data["companyName"];
            this.contactTitle = data["contactTitle"];
            this.addressId = data["addressId"];
            this.address = data["address"] ? Address.fromJS(data["address"]) : <any>undefined;
            this.phone = data["phone"];
            this.email = data["email"];
            this.webSite = data["webSite"];
            this.typeGoods = data["typeGoods"];
            this.sizeUrl = data["sizeUrl"];
            this.logo = data["logo"];
            this.note = data["note"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StormyVendor {
        data = typeof data === 'object' ? data : {};
        let result = new StormyVendor();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["companyName"] = this.companyName;
        data["contactTitle"] = this.contactTitle;
        data["addressId"] = this.addressId;
        data["address"] = this.address ? this.address.toJSON() : <any>undefined;
        data["phone"] = this.phone;
        data["email"] = this.email;
        data["webSite"] = this.webSite;
        data["typeGoods"] = this.typeGoods;
        data["sizeUrl"] = this.sizeUrl;
        data["logo"] = this.logo;
        data["note"] = this.note;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IStormyVendor {
    companyName?: string | undefined;
    contactTitle?: string | undefined;
    addressId?: number | undefined;
    address?: Address | undefined;
    phone?: string | undefined;
    email?: string | undefined;
    webSite?: string | undefined;
    typeGoods?: string | undefined;
    sizeUrl?: string | undefined;
    logo?: string | undefined;
    note?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}