import { StormyCustomer } from "./StormyCustomer";
import { WishlistItem } from "./WishListItem";

export class Wishlist implements IWishlist {
         customerId?: number | undefined;
         customer?: StormyCustomer | undefined;
         wishlistItems?: WishlistItem[] | undefined;
         lastModified?: Date | undefined;
         isDeleted?: boolean | undefined;
         id?: number | undefined;
     
         constructor(data?: IWishlist) {
             if (data) {
                 for (var property in data) {
                     if (data.hasOwnProperty(property))
                         (<any>this)[property] = (<any>data)[property];
                }
            }
        }
 
     init(data?: any) {
         if (data) {
             this.customerId = data["customerId"];
             this.customer = data["customer"] ? StormyCustomer.fromJS(data["customer"]) : <any>undefined;
             if (Array.isArray(data["wishlistItems"])) {
                 this.wishlistItems = [] as any;
                 for (let item of data["wishlistItems"])
                this.wishlistItems!.push(WishlistItem.fromJS(item));
             }
             this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
             this.isDeleted = data["isDeleted"];
             this.id = data["id"];
         }
     }
 
     static fromJS(data: any): Wishlist {
         data = typeof data === 'object' ? data : {};
         let result = new Wishlist();
         result.init(data);
         return result;
     }
    toJSON(data?: any) {
             data = typeof data === 'object' ? data : {};
             data["customerId"] = this.customerId;
             data["customer"] = this.customer ? this.customer.toJSON() : <any>undefined;
             if (Array.isArray(this.wishlistItems)) {
                 data["wishlistItems"] = [];
                 for (let item of this.wishlistItems)
                     data["wishlistItems"].push(item.toJSON());
             }
             data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
             data["isDeleted"] = this.isDeleted;
             data["id"] = this.id;
             return data; 
         }
     }
     
export interface IWishlist {
    customerId?: number | undefined;
    customer?: StormyCustomer | undefined;
    wishlistItems?: WishlistItem[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}