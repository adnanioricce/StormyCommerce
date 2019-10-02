import { StormyProduct } from "../catalog/StormyProduct";
import { Wishlist } from "./WishList";

export class WishlistItem implements IWishlistItem {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    wishlistId?: number | undefined;
    wishlist?: Wishlist | undefined;
    addedAt?: Date | undefined;
    deleted?: boolean | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IWishlistItem) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.wishlistId = data["wishlistId"];
            this.wishlist = data["wishlist"] ? Wishlist.fromJS(data["wishlist"]) : <any>undefined;
            this.addedAt = data["addedAt"] ? new Date(data["addedAt"].toString()) : <any>undefined;
            this.deleted = data["deleted"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): WishlistItem {
        data = typeof data === 'object' ? data : {};
        let result = new WishlistItem();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["wishlistId"] = this.wishlistId;
        data["wishlist"] = this.wishlist ? this.wishlist.toJSON() : <any>undefined;
        data["addedAt"] = this.addedAt ? this.addedAt.toISOString() : <any>undefined;
        data["deleted"] = this.deleted;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IWishlistItem {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    wishlistId?: number | undefined;
    wishlist?: Wishlist | undefined;
    addedAt?: Date | undefined;
    deleted?: boolean | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}
