import { CategoryDto } from "./CategoryDto";
import { MediaDto } from "../common/MediaDto";

export class ProductOverviewDto implements IProductOverviewDto {
    readonly id?: number | undefined;
    readonly productName?: string | undefined;
    readonly slug?: string | undefined;
    readonly price?: string | undefined;
    readonly oldPrice?: string | undefined;
    readonly hasDiscountApplied?: boolean | undefined;
    readonly isPublished?: boolean | undefined;
    readonly availableForPreorder?: boolean | undefined;
    readonly thumbnailImage?: string | undefined;
    readonly category?: CategoryDto | undefined;
    readonly medias?: MediaDto[] | undefined;

    constructor(data?: IProductOverviewDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).id = data["id"];
            (<any>this).productName = data["productName"];
            (<any>this).slug = data["slug"];
            (<any>this).price = data["price"];
            (<any>this).oldPrice = data["oldPrice"];
            (<any>this).hasDiscountApplied = data["hasDiscountApplied"];
            (<any>this).isPublished = data["isPublished"];
            (<any>this).availableForPreorder = data["availableForPreorder"];
            (<any>this).thumbnailImage = data["thumbnailImage"];
            (<any>this).category = data["category"] ? CategoryDto.fromJS(data["category"]) : <any>undefined;
            if (Array.isArray(data["medias"])) {
                (<any>this).medias = [] as any;
                for (let item of data["medias"])
                    (<any>this).medias!.push(MediaDto.fromJS(item));
            }
        }
    }

    static fromJS(data: any): ProductOverviewDto {
        data = typeof data === 'object' ? data : {};
        let result = new ProductOverviewDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["productName"] = this.productName;
        data["slug"] = this.slug;
        data["price"] = this.price;
        data["oldPrice"] = this.oldPrice;
        data["hasDiscountApplied"] = this.hasDiscountApplied;
        data["isPublished"] = this.isPublished;
        data["availableForPreorder"] = this.availableForPreorder;
        data["thumbnailImage"] = this.thumbnailImage;
        data["category"] = this.category ? this.category.toJSON() : <any>undefined;
        if (Array.isArray(this.medias)) {
            data["medias"] = [];
            for (let item of this.medias)
                data["medias"].push(item.toJSON());
        }
        return data; 
    }
}

export interface IProductOverviewDto {
    id?: number | undefined;
    productName?: string | undefined;
    slug?: string | undefined;
    price?: string | undefined;
    oldPrice?: string | undefined;
    hasDiscountApplied?: boolean | undefined;
    isPublished?: boolean | undefined;
    availableForPreorder?: boolean | undefined;
    thumbnailImage?: string | undefined;
    category?: CategoryDto | undefined;
    medias?: MediaDto[] | undefined;
}