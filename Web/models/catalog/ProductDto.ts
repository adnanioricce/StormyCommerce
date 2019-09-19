import { CategoryDto } from './categoryDto';
import { VendorDto } from './vendorDto';
import { BrandDto } from './vendorDto';
import { MediaDto } from '../common/mediaDto';

export class ProductDto implements IProductDto {
    id?: number | undefined;
    productName?: string | undefined;
    slug?: string | undefined;
    quantityPerUnity?: number | undefined;
    unitSize?: string | undefined;
    unitPrice?: number | undefined;
    discount?: number | undefined;
    unitWeight?: number | undefined;
    unitsInStock?: number | undefined;
    unitsOnOrder?: number | undefined;
    price?: string | undefined;
    oldPrice?: string | undefined;
    thumbnailImage?: string | undefined;
    category?: CategoryDto | undefined;
    brand?: BrandDto | undefined;
    vendor?: VendorDto | undefined;
    medias?: MediaDto[] | undefined;

    constructor(data?: IProductDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.id = data["id"];
            this.productName = data["productName"];
            this.slug = data["slug"];
            this.quantityPerUnity = data["quantityPerUnity"];
            this.unitSize = data["unitSize"];
            this.unitPrice = data["unitPrice"];
            this.discount = data["discount"];
            this.unitWeight = data["unitWeight"];
            this.unitsInStock = data["unitsInStock"];
            this.unitsOnOrder = data["unitsOnOrder"];
            this.price = data["price"];
            this.oldPrice = data["oldPrice"];
            this.thumbnailImage = data["thumbnailImage"];
            this.category = data["category"] ? CategoryDto.fromJS(data["category"]) : <any>undefined;
            this.brand = data["brand"] ? BrandDto.fromJS(data["brand"]) : <any>undefined;
            this.vendor = data["vendor"] ? VendorDto.fromJS(data["vendor"]) : <any>undefined;
            if (Array.isArray(data["medias"])) {
                this.medias = [] as any;
                for (let item of data["medias"])
                    this.medias!.push(MediaDto.fromJS(item));
            }
        }
    }

    static fromJS(data: any): ProductDto {
        data = typeof data === 'object' ? data : {};
        let result = new ProductDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["productName"] = this.productName;
        data["slug"] = this.slug;
        data["quantityPerUnity"] = this.quantityPerUnity;
        data["unitSize"] = this.unitSize;
        data["unitPrice"] = this.unitPrice;
        data["discount"] = this.discount;
        data["unitWeight"] = this.unitWeight;
        data["unitsInStock"] = this.unitsInStock;
        data["unitsOnOrder"] = this.unitsOnOrder;
        data["price"] = this.price;
        data["oldPrice"] = this.oldPrice;
        data["thumbnailImage"] = this.thumbnailImage;
        data["category"] = this.category ? this.category.toJSON() : <any>undefined;
        data["brand"] = this.brand ? this.brand.toJSON() : <any>undefined;
        data["vendor"] = this.vendor ? this.vendor.toJSON() : <any>undefined;
        if (Array.isArray(this.medias)) {
            data["medias"] = [];
            for (let item of this.medias)
                data["medias"].push(item.toJSON());
        }
        return data; 
    }
}

export interface IProductDto {
    id?: number | undefined;
    productName?: string | undefined;
    slug?: string | undefined;
    quantityPerUnity?: number | undefined;
    unitSize?: string | undefined;
    unitPrice?: number | undefined;
    discount?: number | undefined;
    unitWeight?: number | undefined;
    unitsInStock?: number | undefined;
    unitsOnOrder?: number | undefined;
    price?: string | undefined;
    oldPrice?: string | undefined;
    thumbnailImage?: string | undefined;
    category?: CategoryDto | undefined;
    brand?: BrandDto | undefined;
    vendor?: VendorDto | undefined;
    medias?: MediaDto[] | undefined;
}