import { ProductTemplate } from "./ProductTemplate";
import { ProductAttribute } from "./ProductAttribute";
export class ProductTemplateProductAttribute implements IProductTemplateProductAttribute {
    productTemplateId?: number | undefined;
    productTemplate?: ProductTemplate | undefined;
    productAttributeId?: number | undefined;
    productAttribute?: ProductAttribute | undefined;

    constructor(data?: IProductTemplateProductAttribute) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.productTemplateId = data["productTemplateId"];
            this.productTemplate = data["productTemplate"] ? ProductTemplate.fromJS(data["productTemplate"]) : <any>undefined;
            this.productAttributeId = data["productAttributeId"];
            this.productAttribute = data["productAttribute"] ? ProductAttribute.fromJS(data["productAttribute"]) : <any>undefined;
        }
    }

    static fromJS(data: any): ProductTemplateProductAttribute {
        data = typeof data === 'object' ? data : {};
        let result = new ProductTemplateProductAttribute();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productTemplateId"] = this.productTemplateId;
        data["productTemplate"] = this.productTemplate ? this.productTemplate.toJSON() : <any>undefined;
        data["productAttributeId"] = this.productAttributeId;
        data["productAttribute"] = this.productAttribute ? this.productAttribute.toJSON() : <any>undefined;
        return data; 
    }
}

export interface IProductTemplateProductAttribute {
    productTemplateId?: number | undefined;
    productTemplate?: ProductTemplate | undefined;
    productAttributeId?: number | undefined;
    productAttribute?: ProductAttribute | undefined;
}
