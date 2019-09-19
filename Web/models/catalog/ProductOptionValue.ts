export class ProductOptionValue implements IProductOptionValue {
    optionId?: number | undefined;
    option?: ProductOption | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    displayType?: string | undefined;
    sortIndex?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductOptionValue) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.optionId = data["optionId"];
            this.option = data["option"] ? ProductOption.fromJS(data["option"]) : <any>undefined;
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.value = data["value"];
            this.displayType = data["displayType"];
            this.sortIndex = data["sortIndex"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductOptionValue {
        data = typeof data === 'object' ? data : {};
        let result = new ProductOptionValue();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["optionId"] = this.optionId;
        data["option"] = this.option ? this.option.toJSON() : <any>undefined;
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["value"] = this.value;
        data["displayType"] = this.displayType;
        data["sortIndex"] = this.sortIndex;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductOptionValue {
    optionId?: number | undefined;
    option?: ProductOption | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    displayType?: string | undefined;
    sortIndex?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}