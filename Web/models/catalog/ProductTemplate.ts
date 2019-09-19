import { ProductTemplateProductAttribute  } from "./productTemplateProductAttribute";
export class ProductTemplate implements IProductTemplate {
    name?: string | undefined;
    readonly productAttributes?: ProductTemplateProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductTemplate) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.name = data["name"];
            if (Array.isArray(data["productAttributes"])) {
                (<any>this).productAttributes = [] as any;
                for (let item of data["productAttributes"])
                    (<any>this).productAttributes!.push(ProductTemplateProductAttribute.fromJS(item));
            }
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductTemplate {
        data = typeof data === 'object' ? data : {};
        let result = new ProductTemplate();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        if (Array.isArray(this.productAttributes)) {
            data["productAttributes"] = [];
            for (let item of this.productAttributes)
                data["productAttributes"].push(item.toJSON());
        }
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductTemplate {
    name?: string | undefined;
    productAttributes?: ProductTemplateProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}