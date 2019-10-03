import { ProductAttribute } from "./ProductAttribute";

export class ProductAttributeGroup implements IProductAttributeGroup {
    name!: string;
    attributes?: ProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductAttributeGroup) {
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
            if (Array.isArray(data["attributes"])) {
                this.attributes = [] as any;
                for (let item of data["attributes"])
                    this.attributes!.push(ProductAttribute.fromJS(item));
            }
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductAttributeGroup {
        data = typeof data === 'object' ? data : {};
        let result = new ProductAttributeGroup();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        if (Array.isArray(this.attributes)) {
            data["attributes"] = [];
            for (let item of this.attributes)
                data["attributes"].push(item.toJSON());
        }
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductAttributeGroup {
    name: string;
    attributes?: ProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}