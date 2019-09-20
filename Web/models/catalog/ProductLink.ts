import { StormyProduct } from "./StormyProduct";
import { ProductLinkType } from "./ProductLinkType";

export class ProductLink implements IProductLink {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    linkedProductId?: number | undefined;
    linkedProduct?: StormyProduct | undefined;
    linkType?: ProductLinkType | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductLink) {
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
            this.linkedProductId = data["linkedProductId"];
            this.linkedProduct = data["linkedProduct"] ? StormyProduct.fromJS(data["linkedProduct"]) : <any>undefined;
            this.linkType = data["linkType"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductLink {
        data = typeof data === 'object' ? data : {};
        let result = new ProductLink();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["linkedProductId"] = this.linkedProductId;
        data["linkedProduct"] = this.linkedProduct ? this.linkedProduct.toJSON() : <any>undefined;
        data["linkType"] = this.linkType;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductLink {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    linkedProductId?: number | undefined;
    linkedProduct?: StormyProduct | undefined;
    linkType?: ProductLinkType | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}