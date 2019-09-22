import AddressVm from '../common/AddressVm';
import { ProductDto } from '../catalog/ProductDto';
export class CheckoutOrderVm implements ICheckoutOrderVm {
    address?: AddressVm | undefined;
    deliveryCost?: number | undefined;
    discount?: number | undefined;
    items?: ProductDto[] | undefined;
    paymentMethod?: string | undefined;
    totalPrice?: number | undefined;
    shippingFee?: number | undefined;

    constructor(data?: ICheckoutOrderVm) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.address = data["address"] ? AddressVm.fromJS(data["address"]) : <any>undefined;
            this.deliveryCost = data["deliveryCost"];
            this.discount = data["discount"];
            if (Array.isArray(data["items"])) {
                this.items = [] as any;
                for (let item of data["items"])
                    this.items!.push(ProductDto.fromJS(item));
            }
            this.paymentMethod = data["paymentMethod"];
            this.totalPrice = data["totalPrice"];
            this.shippingFee = data["shippingFee"];
        }
    }

    static fromJS(data: any): CheckoutOrderVm {
        data = typeof data === 'object' ? data : {};
        let result = new CheckoutOrderVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["address"] = this.address ? this.address.toJSON() : <any>undefined;
        data["deliveryCost"] = this.deliveryCost;
        data["discount"] = this.discount;
        if (Array.isArray(this.items)) {
            data["items"] = [];
            for (let item of this.items)
                data["items"].push(item.toJSON());
        }
        data["paymentMethod"] = this.paymentMethod;
        data["totalPrice"] = this.totalPrice;
        data["shippingFee"] = this.shippingFee;
        return data; 
    }
}

export interface ICheckoutOrderVm {
    address?: AddressVm | undefined;
    deliveryCost?: number | undefined;
    discount?: number | undefined;
    items?: ProductDto[] | undefined;
    paymentMethod?: string | undefined;
    totalPrice?: number | undefined;
    shippingFee?: number | undefined;
}
