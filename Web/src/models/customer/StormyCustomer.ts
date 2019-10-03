import { Address } from "../common/Address";
import { Review } from "./Review";
import { Wishlist } from "./WishList";
export class StormyCustomer implements IStormyCustomer {
    userId?: string | undefined;
    cpf?: string | undefined;
    normalizedEmail?: string | undefined;
    phoneNumber?: string | undefined;
    phoneNumberConfirmed?: boolean | undefined;
    emailConfirmed?: boolean | undefined;
    customerAddresses?: Address[] | undefined;
    defaultShippingAddress?: Address | undefined;
    defaultShippingAddressId?: number | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultBillingAddressId?: number | undefined;
    customerReviewsId?: number | undefined;
    customerReviews?: Review[] | undefined;
    customerWishlistId?: number | undefined;
    customerWishlist?: Wishlist | undefined;
    userName?: string | undefined;
    fullName?: string | undefined;
    email?: string | undefined;
    createdOn?: Date | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IStormyCustomer) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.userId = data["userId"];
            this.cpf = data["cpf"];
            this.normalizedEmail = data["normalizedEmail"];
            this.phoneNumber = data["phoneNumber"];
            this.phoneNumberConfirmed = data["phoneNumberConfirmed"];
            this.emailConfirmed = data["emailConfirmed"];
            if (Array.isArray(data["customerAddresses"])) {
                this.customerAddresses = [] as any;
                for (let item of data["customerAddresses"])
                    this.customerAddresses!.push(Address.fromJS(item));
            }
            this.defaultShippingAddress = data["defaultShippingAddress"] ? Address.fromJS(data["defaultShippingAddress"]) : <any>undefined;
            this.defaultShippingAddressId = data["defaultShippingAddressId"];
            this.defaultBillingAddress = data["defaultBillingAddress"] ? Address.fromJS(data["defaultBillingAddress"]) : <any>undefined;
            this.defaultBillingAddressId = data["defaultBillingAddressId"];
            this.customerReviewsId = data["customerReviewsId"];
            if (Array.isArray(data["customerReviews"])) {
                this.customerReviews = [] as any;
                for (let item of data["customerReviews"])
                    this.customerReviews!.push(Review.fromJS(item));
            }
            this.customerWishlistId = data["customerWishlistId"];
            this.customerWishlist = data["customerWishlist"] ? Wishlist.fromJS(data["customerWishlist"]) : <any>undefined;
            this.userName = data["userName"];
            this.fullName = data["fullName"];
            this.email = data["email"];
            this.createdOn = data["createdOn"] ? new Date(data["createdOn"].toString()) : <any>undefined;
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StormyCustomer {
        data = typeof data === 'object' ? data : {};
        let result = new StormyCustomer();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userId"] = this.userId;
        data["cpf"] = this.cpf;
        data["normalizedEmail"] = this.normalizedEmail;
        data["phoneNumber"] = this.phoneNumber;
        data["phoneNumberConfirmed"] = this.phoneNumberConfirmed;
        data["emailConfirmed"] = this.emailConfirmed;
        if (Array.isArray(this.customerAddresses)) {
            data["customerAddresses"] = [];
            for (let item of this.customerAddresses)
                data["customerAddresses"].push(item.toJSON());
        }
        data["defaultShippingAddress"] = this.defaultShippingAddress ? this.defaultShippingAddress.toJSON() : <any>undefined;
        data["defaultShippingAddressId"] = this.defaultShippingAddressId;
        data["defaultBillingAddress"] = this.defaultBillingAddress ? this.defaultBillingAddress.toJSON() : <any>undefined;
        data["defaultBillingAddressId"] = this.defaultBillingAddressId;
        data["customerReviewsId"] = this.customerReviewsId;
        if (Array.isArray(this.customerReviews)) {
            data["customerReviews"] = [];
            for (let item of this.customerReviews)
                data["customerReviews"].push(item.toJSON());
        }
        data["customerWishlistId"] = this.customerWishlistId;
        data["customerWishlist"] = this.customerWishlist ? this.customerWishlist.toJSON() : <any>undefined;
        data["userName"] = this.userName;
        data["fullName"] = this.fullName;
        data["email"] = this.email;
        data["createdOn"] = this.createdOn ? this.createdOn.toISOString() : <any>undefined;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IStormyCustomer {
    userId?: string | undefined;
    cpf?: string | undefined;
    normalizedEmail?: string | undefined;
    phoneNumber?: string | undefined;
    phoneNumberConfirmed?: boolean | undefined;
    emailConfirmed?: boolean | undefined;
    customerAddresses?: Address[] | undefined;
    defaultShippingAddress?: Address | undefined;
    defaultShippingAddressId?: number | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultBillingAddressId?: number | undefined;
    customerReviewsId?: number | undefined;
    customerReviews?: Review[] | undefined;
    customerWishlistId?: number | undefined;
    customerWishlist?: Wishlist | undefined;
    userName?: string | undefined;
    fullName?: string | undefined;
    email?: string | undefined;
    createdOn?: Date | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}
