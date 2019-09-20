import { ProductLink } from "./ProductLink";
import { Media } from "../common/Media";
import { ProductAttribute } from "./ProductAttribute";
import { StormyVendor } from "./StormyVendor";
import { Brand } from "./Brand";
import { Category } from "./Category";
import { ProductAttributeValue } from "./ProductAttributeValue";
import { ProductOptionValue } from "./ProductOptionValue";

export class StormyProduct implements IStormyProduct {
    sku?: string | undefined;
    gtin?: string | undefined;
    normalizedName?: string | undefined;
    productName?: string | undefined;
    slug?: string | undefined;
    metaKeywords?: string | undefined;
    metaDescription?: string | undefined;
    metaTitle?: string | undefined;
    createdById?: number | undefined;
    brandId?: number | undefined;
    mediaId?: number | undefined;
    vendorId?: number | undefined;
    categoryId?: number | undefined;
    productLinksId?: number | undefined;
    taxClassId?: number | undefined;
    latestUpdatedById?: number | undefined;
    vendor?: StormyVendor | undefined;
    brand?: Brand | undefined;
    category?: Category | undefined;
    typeName?: string | undefined;
    shortDescription?: string | undefined;
    description?: string | undefined;
    specification?: string | undefined;
    quantityPerUnity?: number | undefined;
    unitSize?: number | undefined;
    unitPrice?: number | undefined;
    discount?: number | undefined;
    unitWeight?: number | undefined;
    unitsInStock?: number | undefined;
    unitsOnOrder?: number | undefined;
    reviewsCount?: number | undefined;
    productAvailable?: boolean | undefined;
    discountAvailable?: boolean | undefined;
    stockTrackingIsEnabled?: boolean | undefined;
    thumbnailImage?: string | undefined;
    readonly medias?: Media[] | undefined;
    readonly links?: ProductLink[] | undefined;
    readonly linkedProductLinks?: ProductLink[] | undefined;
    productAttributes?: ProductAttribute[] | undefined;
    readonly attributeValues?: ProductAttributeValue[] | undefined;
    readonly optionValues?: ProductOptionValue[] | undefined;
    ranking?: number | undefined;
    note?: string | undefined;
    price?: string | undefined;
    oldPrice?: string | undefined;
    specialPrice?: string | undefined;
    specialPriceStart?: Date | undefined;
    specialPriceEnd?: Date | undefined;
    hasDiscountApplied?: boolean | undefined;
    isPublished?: boolean | undefined;
    status?: string | undefined;
    notReturnable?: boolean | undefined;
    availableForPreorder?: boolean | undefined;
    hasOptions?: boolean | undefined;
    isVisibleIndividually?: boolean | undefined;
    isFeatured?: boolean | undefined;
    isCallForPricing?: boolean | undefined;
    isAllowToOrder?: boolean | undefined;
    productCost?: number | undefined;
    preOrderAvailabilityStartDate?: Date | undefined;
    publishedOn?: Date | undefined;
    createdOn?: Date | undefined;
    latestUpdatedOn?: Date | undefined;
    allowCustomerReview?: boolean | undefined;
    approvedRatingSum?: number | undefined;
    notApprovedRatingSum?: number | undefined;
    approvedTotalReviews?: number | undefined;
    notApprovedTotalReviews?: number | undefined;
    ratingAverage?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IStormyProduct) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.sku = data["sku"];
            this.gtin = data["gtin"];
            this.normalizedName = data["normalizedName"];
            this.productName = data["productName"];
            this.slug = data["slug"];
            this.metaKeywords = data["metaKeywords"];
            this.metaDescription = data["metaDescription"];
            this.metaTitle = data["metaTitle"];
            this.createdById = data["createdById"];
            this.brandId = data["brandId"];
            this.mediaId = data["mediaId"];
            this.vendorId = data["vendorId"];
            this.categoryId = data["categoryId"];
            this.productLinksId = data["productLinksId"];
            this.taxClassId = data["taxClassId"];
            this.latestUpdatedById = data["latestUpdatedById"];
            this.vendor = data["vendor"] ? StormyVendor.fromJS(data["vendor"]) : <any>undefined;
            this.brand = data["brand"] ? Brand.fromJS(data["brand"]) : <any>undefined;
            this.category = data["category"] ? Category.fromJS(data["category"]) : <any>undefined;
            this.typeName = data["typeName"];
            this.shortDescription = data["shortDescription"];
            this.description = data["description"];
            this.specification = data["specification"];
            this.quantityPerUnity = data["quantityPerUnity"];
            this.unitSize = data["unitSize"];
            this.unitPrice = data["unitPrice"];
            this.discount = data["discount"];
            this.unitWeight = data["unitWeight"];
            this.unitsInStock = data["unitsInStock"];
            this.unitsOnOrder = data["unitsOnOrder"];
            this.reviewsCount = data["reviewsCount"];
            this.productAvailable = data["productAvailable"];
            this.discountAvailable = data["discountAvailable"];
            this.stockTrackingIsEnabled = data["stockTrackingIsEnabled"];
            this.thumbnailImage = data["thumbnailImage"];
            if (Array.isArray(data["medias"])) {
                (<any>this).medias = [] as any;
                for (let item of data["medias"])
                    (<any>this).medias!.push(Media.fromJS(item));
            }
            if (Array.isArray(data["links"])) {
                (<any>this).links = [] as any;
                for (let item of data["links"])
                    (<any>this).links!.push(ProductLink.fromJS(item));
            }
            if (Array.isArray(data["linkedProductLinks"])) {
                (<any>this).linkedProductLinks = [] as any;
                for (let item of data["linkedProductLinks"])
                    (<any>this).linkedProductLinks!.push(ProductLink.fromJS(item));
            }
            if (Array.isArray(data["productAttributes"])) {
                this.productAttributes = [] as any;
                for (let item of data["productAttributes"])
                    this.productAttributes!.push(ProductAttribute.fromJS(item));
            }
            if (Array.isArray(data["attributeValues"])) {
                (<any>this).attributeValues = [] as any;
                for (let item of data["attributeValues"])
                    (<any>this).attributeValues!.push(ProductAttributeValue.fromJS(item));
            }
            if (Array.isArray(data["optionValues"])) {
                (<any>this).optionValues = [] as any;
                for (let item of data["optionValues"])
                    (<any>this).optionValues!.push(ProductOptionValue.fromJS(item));
            }
            this.ranking = data["ranking"];
            this.note = data["note"];
            this.price = data["price"];
            this.oldPrice = data["oldPrice"];
            this.specialPrice = data["specialPrice"];
            this.specialPriceStart = data["specialPriceStart"] ? new Date(data["specialPriceStart"].toString()) : <any>undefined;
            this.specialPriceEnd = data["specialPriceEnd"] ? new Date(data["specialPriceEnd"].toString()) : <any>undefined;
            this.hasDiscountApplied = data["hasDiscountApplied"];
            this.isPublished = data["isPublished"];
            this.status = data["status"];
            this.notReturnable = data["notReturnable"];
            this.availableForPreorder = data["availableForPreorder"];
            this.hasOptions = data["hasOptions"];
            this.isVisibleIndividually = data["isVisibleIndividually"];
            this.isFeatured = data["isFeatured"];
            this.isCallForPricing = data["isCallForPricing"];
            this.isAllowToOrder = data["isAllowToOrder"];
            this.productCost = data["productCost"];
            this.preOrderAvailabilityStartDate = data["preOrderAvailabilityStartDate"] ? new Date(data["preOrderAvailabilityStartDate"].toString()) : <any>undefined;
            this.publishedOn = data["publishedOn"] ? new Date(data["publishedOn"].toString()) : <any>undefined;
            this.createdOn = data["createdOn"] ? new Date(data["createdOn"].toString()) : <any>undefined;
            this.latestUpdatedOn = data["latestUpdatedOn"] ? new Date(data["latestUpdatedOn"].toString()) : <any>undefined;
            this.allowCustomerReview = data["allowCustomerReview"];
            this.approvedRatingSum = data["approvedRatingSum"];
            this.notApprovedRatingSum = data["notApprovedRatingSum"];
            this.approvedTotalReviews = data["approvedTotalReviews"];
            this.notApprovedTotalReviews = data["notApprovedTotalReviews"];
            this.ratingAverage = data["ratingAverage"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StormyProduct {
        data = typeof data === 'object' ? data : {};
        let result = new StormyProduct();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["sku"] = this.sku;
        data["gtin"] = this.gtin;
        data["normalizedName"] = this.normalizedName;
        data["productName"] = this.productName;
        data["slug"] = this.slug;
        data["metaKeywords"] = this.metaKeywords;
        data["metaDescription"] = this.metaDescription;
        data["metaTitle"] = this.metaTitle;
        data["createdById"] = this.createdById;
        data["brandId"] = this.brandId;
        data["mediaId"] = this.mediaId;
        data["vendorId"] = this.vendorId;
        data["categoryId"] = this.categoryId;
        data["productLinksId"] = this.productLinksId;
        data["taxClassId"] = this.taxClassId;
        data["latestUpdatedById"] = this.latestUpdatedById;
        data["vendor"] = this.vendor ? this.vendor.toJSON() : <any>undefined;
        data["brand"] = this.brand ? this.brand.toJSON() : <any>undefined;
        data["category"] = this.category ? this.category.toJSON() : <any>undefined;
        data["typeName"] = this.typeName;
        data["shortDescription"] = this.shortDescription;
        data["description"] = this.description;
        data["specification"] = this.specification;
        data["quantityPerUnity"] = this.quantityPerUnity;
        data["unitSize"] = this.unitSize;
        data["unitPrice"] = this.unitPrice;
        data["discount"] = this.discount;
        data["unitWeight"] = this.unitWeight;
        data["unitsInStock"] = this.unitsInStock;
        data["unitsOnOrder"] = this.unitsOnOrder;
        data["reviewsCount"] = this.reviewsCount;
        data["productAvailable"] = this.productAvailable;
        data["discountAvailable"] = this.discountAvailable;
        data["stockTrackingIsEnabled"] = this.stockTrackingIsEnabled;
        data["thumbnailImage"] = this.thumbnailImage;
        if (Array.isArray(this.medias)) {
            data["medias"] = [];
            for (let item of this.medias)
                data["medias"].push(item.toJSON());
        }
        if (Array.isArray(this.links)) {
            data["links"] = [];
            for (let item of this.links)
                data["links"].push(item.toJSON());
        }
        if (Array.isArray(this.linkedProductLinks)) {
            data["linkedProductLinks"] = [];
            for (let item of this.linkedProductLinks)
                data["linkedProductLinks"].push(item.toJSON());
        }
        if (Array.isArray(this.productAttributes)) {
            data["productAttributes"] = [];
            for (let item of this.productAttributes)
                data["productAttributes"].push(item.toJSON());
        }
        if (Array.isArray(this.attributeValues)) {
            data["attributeValues"] = [];
            for (let item of this.attributeValues)
                data["attributeValues"].push(item.toJSON());
        }
        if (Array.isArray(this.optionValues)) {
            data["optionValues"] = [];
            for (let item of this.optionValues)
                data["optionValues"].push(item.toJSON());
        }
        data["ranking"] = this.ranking;
        data["note"] = this.note;
        data["price"] = this.price;
        data["oldPrice"] = this.oldPrice;
        data["specialPrice"] = this.specialPrice;
        data["specialPriceStart"] = this.specialPriceStart ? this.specialPriceStart.toISOString() : <any>undefined;
        data["specialPriceEnd"] = this.specialPriceEnd ? this.specialPriceEnd.toISOString() : <any>undefined;
        data["hasDiscountApplied"] = this.hasDiscountApplied;
        data["isPublished"] = this.isPublished;
        data["status"] = this.status;
        data["notReturnable"] = this.notReturnable;
        data["availableForPreorder"] = this.availableForPreorder;
        data["hasOptions"] = this.hasOptions;
        data["isVisibleIndividually"] = this.isVisibleIndividually;
        data["isFeatured"] = this.isFeatured;
        data["isCallForPricing"] = this.isCallForPricing;
        data["isAllowToOrder"] = this.isAllowToOrder;
        data["productCost"] = this.productCost;
        data["preOrderAvailabilityStartDate"] = this.preOrderAvailabilityStartDate ? this.preOrderAvailabilityStartDate.toISOString() : <any>undefined;
        data["publishedOn"] = this.publishedOn ? this.publishedOn.toISOString() : <any>undefined;
        data["createdOn"] = this.createdOn ? this.createdOn.toISOString() : <any>undefined;
        data["latestUpdatedOn"] = this.latestUpdatedOn ? this.latestUpdatedOn.toISOString() : <any>undefined;
        data["allowCustomerReview"] = this.allowCustomerReview;
        data["approvedRatingSum"] = this.approvedRatingSum;
        data["notApprovedRatingSum"] = this.notApprovedRatingSum;
        data["approvedTotalReviews"] = this.approvedTotalReviews;
        data["notApprovedTotalReviews"] = this.notApprovedTotalReviews;
        data["ratingAverage"] = this.ratingAverage;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IStormyProduct {
    sku?: string | undefined;
    gtin?: string | undefined;
    normalizedName?: string | undefined;
    productName?: string | undefined;
    slug?: string | undefined;
    metaKeywords?: string | undefined;
    metaDescription?: string | undefined;
    metaTitle?: string | undefined;
    createdById?: number | undefined;
    brandId?: number | undefined;
    mediaId?: number | undefined;
    vendorId?: number | undefined;
    categoryId?: number | undefined;
    productLinksId?: number | undefined;
    taxClassId?: number | undefined;
    latestUpdatedById?: number | undefined;
    vendor?: StormyVendor | undefined;
    brand?: Brand | undefined;
    category?: Category | undefined;
    typeName?: string | undefined;
    shortDescription?: string | undefined;
    description?: string | undefined;
    specification?: string | undefined;
    quantityPerUnity?: number | undefined;
    unitSize?: number | undefined;
    unitPrice?: number | undefined;
    discount?: number | undefined;
    unitWeight?: number | undefined;
    unitsInStock?: number | undefined;
    unitsOnOrder?: number | undefined;
    reviewsCount?: number | undefined;
    productAvailable?: boolean | undefined;
    discountAvailable?: boolean | undefined;
    stockTrackingIsEnabled?: boolean | undefined;
    thumbnailImage?: string | undefined;
    medias?: Media[] | undefined;
    links?: ProductLink[] | undefined;
    linkedProductLinks?: ProductLink[] | undefined;
    productAttributes?: ProductAttribute[] | undefined;
    attributeValues?: ProductAttributeValue[] | undefined;
    optionValues?: ProductOptionValue[] | undefined;
    ranking?: number | undefined;
    note?: string | undefined;
    price?: string | undefined;
    oldPrice?: string | undefined;
    specialPrice?: string | undefined;
    specialPriceStart?: Date | undefined;
    specialPriceEnd?: Date | undefined;
    hasDiscountApplied?: boolean | undefined;
    isPublished?: boolean | undefined;
    status?: string | undefined;
    notReturnable?: boolean | undefined;
    availableForPreorder?: boolean | undefined;
    hasOptions?: boolean | undefined;
    isVisibleIndividually?: boolean | undefined;
    isFeatured?: boolean | undefined;
    isCallForPricing?: boolean | undefined;
    isAllowToOrder?: boolean | undefined;
    productCost?: number | undefined;
    preOrderAvailabilityStartDate?: Date | undefined;
    publishedOn?: Date | undefined;
    createdOn?: Date | undefined;
    latestUpdatedOn?: Date | undefined;
    allowCustomerReview?: boolean | undefined;
    approvedRatingSum?: number | undefined;
    notApprovedRatingSum?: number | undefined;
    approvedTotalReviews?: number | undefined;
    notApprovedTotalReviews?: number | undefined;
    ratingAverage?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}