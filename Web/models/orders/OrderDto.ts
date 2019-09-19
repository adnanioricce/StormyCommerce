import { Address } from "../common/address";
import { OrderItemDto } from "./OrderItemDto";
import { OrderDtoStatus } from "./OrderDtoStatus";
import { OrderDtoShippingStatus } from "./OrderDtoShippingStatus";

export class OrderDto implements IOrderDto {
    readonly orderUniqueKey?: string | undefined;
    readonly shippingMethod?: string | undefined;
    readonly paymentMethod?: string | undefined;
    readonly trackNumber?: string | undefined;
    readonly comment?: string | undefined;
    readonly discount?: number | undefined;
    readonly tax?: number | undefined;
    readonly totalWeight?: number | undefined;
    readonly totalPrice?: number | undefined;
    readonly deliveryCost?: number | undefined;
    readonly shippingAddress?: Address | undefined;
    readonly orderDate?: Date | undefined;
    readonly shippedDate?: Date | undefined;
    readonly deliveryDate?: Date | undefined;
    readonly paymentDate?: Date | undefined;
    readonly items?: OrderItemDto[] | undefined;
    readonly status?: OrderDtoStatus | undefined;
    readonly shippingStatus?: OrderDtoShippingStatus | undefined;
    isCancelled?: boolean | undefined;

    constructor(data?: IOrderDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).orderUniqueKey = data["orderUniqueKey"];
            (<any>this).shippingMethod = data["shippingMethod"];
            (<any>this).paymentMethod = data["paymentMethod"];
            (<any>this).trackNumber = data["trackNumber"];
            (<any>this).comment = data["comment"];
            (<any>this).discount = data["discount"];
            (<any>this).tax = data["tax"];
            (<any>this).totalWeight = data["totalWeight"];
            (<any>this).totalPrice = data["totalPrice"];
            (<any>this).deliveryCost = data["deliveryCost"];
            (<any>this).shippingAddress = data["shippingAddress"] ? Address.fromJS(data["shippingAddress"]) : <any>undefined;
            (<any>this).orderDate = data["orderDate"] ? new Date(data["orderDate"].toString()) : <any>undefined;
            (<any>this).shippedDate = data["shippedDate"] ? new Date(data["shippedDate"].toString()) : <any>undefined;
            (<any>this).deliveryDate = data["deliveryDate"] ? new Date(data["deliveryDate"].toString()) : <any>undefined;
            (<any>this).paymentDate = data["paymentDate"] ? new Date(data["paymentDate"].toString()) : <any>undefined;
            if (Array.isArray(data["items"])) {
                (<any>this).items = [] as any;
                for (let item of data["items"])
                    (<any>this).items!.push(OrderItemDto.fromJS(item));
            }
            (<any>this).status = data["status"];
            (<any>this).shippingStatus = data["shippingStatus"];
            this.isCancelled = data["isCancelled"];
        }
    }

    static fromJS(data: any): OrderDto {
        data = typeof data === 'object' ? data : {};
        let result = new OrderDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["orderUniqueKey"] = this.orderUniqueKey;
        data["shippingMethod"] = this.shippingMethod;
        data["paymentMethod"] = this.paymentMethod;
        data["trackNumber"] = this.trackNumber;
        data["comment"] = this.comment;
        data["discount"] = this.discount;
        data["tax"] = this.tax;
        data["totalWeight"] = this.totalWeight;
        data["totalPrice"] = this.totalPrice;
        data["deliveryCost"] = this.deliveryCost;
        data["shippingAddress"] = this.shippingAddress ? this.shippingAddress.toJSON() : <any>undefined;
        data["orderDate"] = this.orderDate ? this.orderDate.toISOString() : <any>undefined;
        data["shippedDate"] = this.shippedDate ? this.shippedDate.toISOString() : <any>undefined;
        data["deliveryDate"] = this.deliveryDate ? this.deliveryDate.toISOString() : <any>undefined;
        data["paymentDate"] = this.paymentDate ? this.paymentDate.toISOString() : <any>undefined;
        if (Array.isArray(this.items)) {
            data["items"] = [];
            for (let item of this.items)
                data["items"].push(item.toJSON());
        }
        data["status"] = this.status;
        data["shippingStatus"] = this.shippingStatus;
        data["isCancelled"] = this.isCancelled;
        return data; 
    }
}

export interface IOrderDto {
    orderUniqueKey?: string | undefined;
    shippingMethod?: string | undefined;
    paymentMethod?: string | undefined;
    trackNumber?: string | undefined;
    comment?: string | undefined;
    discount?: number | undefined;
    tax?: number | undefined;
    totalWeight?: number | undefined;
    totalPrice?: number | undefined;
    deliveryCost?: number | undefined;
    shippingAddress?: Address | undefined;
    orderDate?: Date | undefined;
    shippedDate?: Date | undefined;
    deliveryDate?: Date | undefined;
    paymentDate?: Date | undefined;
    items?: OrderItemDto[] | undefined;
    status?: OrderDtoStatus | undefined;
    shippingStatus?: OrderDtoShippingStatus | undefined;
    isCancelled?: boolean | undefined;
}