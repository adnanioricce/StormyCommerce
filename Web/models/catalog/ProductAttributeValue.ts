
export class ProductAttributeValue implements IProductAttributeValue {
    attributeId?: number | undefined;
    attribute?: ProductAttribute | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductAttributeValue) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.attributeId = data["attributeId"];
            this.attribute = data["attribute"] ? ProductAttribute.fromJS(data["attribute"]) : <any>undefined;
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.value = data["value"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductAttributeValue {
        data = typeof data === 'object' ? data : {};
        let result = new ProductAttributeValue();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["attributeId"] = this.attributeId;
        data["attribute"] = this.attribute ? this.attribute.toJSON() : <any>undefined;
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["value"] = this.value;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductAttributeValue {
    attributeId?: number | undefined;
    attribute?: ProductAttribute | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}