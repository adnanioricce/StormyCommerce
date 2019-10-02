import { ProductDto } from "../catalog/ProductDto";

export class OrderItemDto implements IOrderItemDto {
    readonly productName?: string | undefined;
    readonly price?: string | undefined;
    readonly quantity?: number | undefined;
    readonly product?: ProductDto | undefined;

    constructor(data?: IOrderItemDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).productName = data["productName"];
            (<any>this).price = data["price"];
            (<any>this).quantity = data["quantity"];
            (<any>this).product = data["product"] ? ProductDto.fromJS(data["product"]) : <any>undefined;
        }
    }

    static fromJS(data: any): OrderItemDto {
        data = typeof data === 'object' ? data : {};
        let result = new OrderItemDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productName"] = this.productName;
        data["price"] = this.price;
        data["quantity"] = this.quantity;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        return data; 
    }
}

export interface IOrderItemDto {
    productName?: string | undefined;
    price?: string | undefined;
    quantity?: number | undefined;
    product?: ProductDto | undefined;
}