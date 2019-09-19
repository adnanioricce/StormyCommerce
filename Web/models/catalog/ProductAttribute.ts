export class ProductAttribute implements IProductAttribute {
    groupId?: number | undefined;
    group?: ProductAttributeGroup | undefined;
    name?: string | undefined;
    readonly productTemplates?: ProductTemplateProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductAttribute) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.groupId = data["groupId"];
            this.group = data["group"] ? ProductAttributeGroup.fromJS(data["group"]) : <any>undefined;
            this.name = data["name"];
            if (Array.isArray(data["productTemplates"])) {
                (<any>this).productTemplates = [] as any;
                for (let item of data["productTemplates"])
                    (<any>this).productTemplates!.push(ProductTemplateProductAttribute.fromJS(item));
            }
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductAttribute {
        data = typeof data === 'object' ? data : {};
        let result = new ProductAttribute();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["groupId"] = this.groupId;
        data["group"] = this.group ? this.group.toJSON() : <any>undefined;
        data["name"] = this.name;
        if (Array.isArray(this.productTemplates)) {
            data["productTemplates"] = [];
            for (let item of this.productTemplates)
                data["productTemplates"].push(item.toJSON());
        }
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductAttribute {
    groupId?: number | undefined;
    group?: ProductAttributeGroup | undefined;
    name?: string | undefined;
    productTemplates?: ProductTemplateProductAttribute[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}