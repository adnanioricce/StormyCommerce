export class CategoryDto implements ICategoryDto {
    readonly id?: number | undefined;
    readonly name?: string | undefined;
    readonly slug?: string | undefined;
    readonly displayOrder?: number | undefined;
    readonly childrens?: CategoryDto[] | undefined;
    readonly parent?: CategoryDto | undefined;
    readonly description?: string | undefined;
    readonly thumbnailImageUrl?: string | undefined;

    constructor(data?: ICategoryDto) {
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
            (<any>this).name = data["name"];
            (<any>this).slug = data["slug"];
            (<any>this).displayOrder = data["displayOrder"];
            if (Array.isArray(data["childrens"])) {
                (<any>this).childrens = [] as any;
                for (let item of data["childrens"])
                    (<any>this).childrens!.push(CategoryDto.fromJS(item));
            }
            (<any>this).parent = data["parent"] ? CategoryDto.fromJS(data["parent"]) : <any>undefined;
            (<any>this).description = data["description"];
            (<any>this).thumbnailImageUrl = data["thumbnailImageUrl"];
        }
    }

    static fromJS(data: any): CategoryDto {
        data = typeof data === 'object' ? data : {};
        let result = new CategoryDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["name"] = this.name;
        data["slug"] = this.slug;
        data["displayOrder"] = this.displayOrder;
        if (Array.isArray(this.childrens)) {
            data["childrens"] = [];
            for (let item of this.childrens)
                data["childrens"].push(item.toJSON());
        }
        data["parent"] = this.parent ? this.parent.toJSON() : <any>undefined;
        data["description"] = this.description;
        data["thumbnailImageUrl"] = this.thumbnailImageUrl;
        return data; 
    }
}

export interface ICategoryDto {
    id?: number | undefined;
    name?: string | undefined;
    slug?: string | undefined;
    displayOrder?: number | undefined;
    childrens?: CategoryDto[] | undefined;
    parent?: CategoryDto | undefined;
    description?: string | undefined;
    thumbnailImageUrl?: string | undefined;
}

export class Category implements ICategory {
    name?: string | undefined;
    slug?: string | undefined;
    metaTitle?: string | undefined;
    metaKeywords?: string | undefined;
    metaDescription?: string | undefined;
    description?: string | undefined;
    displayOrder?: number | undefined;
    isPublished?: boolean | undefined;
    includeInMenu?: boolean | undefined;
    parentId?: number | undefined;
    parent?: Category | undefined;
    readonly childrens?: Category[] | undefined;
    thumbnailImageUrl?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: ICategory) {
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
            this.slug = data["slug"];
            this.metaTitle = data["metaTitle"];
            this.metaKeywords = data["metaKeywords"];
            this.metaDescription = data["metaDescription"];
            this.description = data["description"];
            this.displayOrder = data["displayOrder"];
            this.isPublished = data["isPublished"];
            this.includeInMenu = data["includeInMenu"];
            this.parentId = data["parentId"];
            this.parent = data["parent"] ? Category.fromJS(data["parent"]) : <any>undefined;
            if (Array.isArray(data["childrens"])) {
                (<any>this).childrens = [] as any;
                for (let item of data["childrens"])
                    (<any>this).childrens!.push(Category.fromJS(item));
            }
            this.thumbnailImageUrl = data["thumbnailImageUrl"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Category {
        data = typeof data === 'object' ? data : {};
        let result = new Category();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["slug"] = this.slug;
        data["metaTitle"] = this.metaTitle;
        data["metaKeywords"] = this.metaKeywords;
        data["metaDescription"] = this.metaDescription;
        data["description"] = this.description;
        data["displayOrder"] = this.displayOrder;
        data["isPublished"] = this.isPublished;
        data["includeInMenu"] = this.includeInMenu;
        data["parentId"] = this.parentId;
        data["parent"] = this.parent ? this.parent.toJSON() : <any>undefined;
        if (Array.isArray(this.childrens)) {
            data["childrens"] = [];
            for (let item of this.childrens)
                data["childrens"].push(item.toJSON());
        }
        data["thumbnailImageUrl"] = this.thumbnailImageUrl;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface ICategory {
    name?: string | undefined;
    slug?: string | undefined;
    metaTitle?: string | undefined;
    metaKeywords?: string | undefined;
    metaDescription?: string | undefined;
    description?: string | undefined;
    displayOrder?: number | undefined;
    isPublished?: boolean | undefined;
    includeInMenu?: boolean | undefined;
    parentId?: number | undefined;
    parent?: Category | undefined;
    childrens?: Category[] | undefined;
    thumbnailImageUrl?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

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

export class AddressVm implements IAddressVm {
    city?: string | undefined;
    cpf?: string | undefined;
    complement?: string | undefined;
    firstAddress?: string | undefined;
    phoneNumber?: string | undefined;
    postalCode?: string | undefined;
    secondAddress?: string | undefined;
    state?: string | undefined;
    street?: string | undefined;
    whoReceives?: string | undefined;
    number?: string | undefined;

    constructor(data?: IAddressVm) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.city = data["city"];
            this.cpf = data["cpf"];
            this.complement = data["complement"];
            this.firstAddress = data["firstAddress"];
            this.phoneNumber = data["phoneNumber"];
            this.postalCode = data["postalCode"];
            this.secondAddress = data["secondAddress"];
            this.state = data["state"];
            this.street = data["street"];
            this.whoReceives = data["whoReceives"];
            this.number = data["number"];
        }
    }

    static fromJS(data: any): AddressVm {
        data = typeof data === 'object' ? data : {};
        let result = new AddressVm();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["city"] = this.city;
        data["cpf"] = this.cpf;
        data["complement"] = this.complement;
        data["firstAddress"] = this.firstAddress;
        data["phoneNumber"] = this.phoneNumber;
        data["postalCode"] = this.postalCode;
        data["secondAddress"] = this.secondAddress;
        data["state"] = this.state;
        data["street"] = this.street;
        data["whoReceives"] = this.whoReceives;
        data["number"] = this.number;
        return data; 
    }
}

export interface IAddressVm {
    city?: string | undefined;
    cpf?: string | undefined;
    complement?: string | undefined;
    firstAddress?: string | undefined;
    phoneNumber?: string | undefined;
    postalCode?: string | undefined;
    secondAddress?: string | undefined;
    state?: string | undefined;
    street?: string | undefined;
    whoReceives?: string | undefined;
    number?: string | undefined;
}

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

export class BrandDto implements IBrandDto {
    readonly name?: string | undefined;
    readonly slug?: string | undefined;
    readonly website?: string | undefined;

    constructor(data?: IBrandDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).name = data["name"];
            (<any>this).slug = data["slug"];
            (<any>this).website = data["website"];
        }
    }

    static fromJS(data: any): BrandDto {
        data = typeof data === 'object' ? data : {};
        let result = new BrandDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["slug"] = this.slug;
        data["website"] = this.website;
        return data; 
    }
}

export interface IBrandDto {
    name?: string | undefined;
    slug?: string | undefined;
    website?: string | undefined;
}

export class VendorDto implements IVendorDto {

    constructor(data?: IVendorDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        data = data;
    }

    static fromJS(data: any): VendorDto {
        data = typeof data === 'object' ? data : {};
        let result = new VendorDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        return data; 
    }
}
///wtf?
export interface IVendorDto {
}

export class MediaDto implements IMediaDto {
    readonly filename?: string | undefined;

    constructor(data?: IMediaDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).filename = data["filename"];
        }
    }

    static fromJS(data: any): MediaDto {
        data = typeof data === 'object' ? data : {};
        let result = new MediaDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["filename"] = this.filename;
        return data; 
    }
}

export interface IMediaDto {
    filename?: string | undefined;
}

export class Address implements IAddress {
    street?: string | undefined;
    firstAddress?: string | undefined;
    secondAddress?: string | undefined;
    city?: string | undefined;
    district?: string | undefined;
    state?: string | undefined;
    postalCode?: string | undefined;
    number?: string | undefined;
    complement?: string | undefined;
    phoneNumber?: string | undefined;
    country?: string | undefined;
    whoReceives?: string | undefined;
    ownerId?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IAddress) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.street = data["street"];
            this.firstAddress = data["firstAddress"];
            this.secondAddress = data["secondAddress"];
            this.city = data["city"];
            this.district = data["district"];
            this.state = data["state"];
            this.postalCode = data["postalCode"];
            this.number = data["number"];
            this.complement = data["complement"];
            this.phoneNumber = data["phoneNumber"];
            this.country = data["country"];
            this.whoReceives = data["whoReceives"];
            this.ownerId = data["ownerId"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Address {
        data = typeof data === 'object' ? data : {};
        let result = new Address();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["street"] = this.street;
        data["firstAddress"] = this.firstAddress;
        data["secondAddress"] = this.secondAddress;
        data["city"] = this.city;
        data["district"] = this.district;
        data["state"] = this.state;
        data["postalCode"] = this.postalCode;
        data["number"] = this.number;
        data["complement"] = this.complement;
        data["phoneNumber"] = this.phoneNumber;
        data["country"] = this.country;
        data["whoReceives"] = this.whoReceives;
        data["ownerId"] = this.ownerId;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IAddress {
    street?: string | undefined;
    firstAddress?: string | undefined;
    secondAddress?: string | undefined;
    city?: string | undefined;
    district?: string | undefined;
    state?: string | undefined;
    postalCode?: string | undefined;
    number?: string | undefined;
    complement?: string | undefined;
    phoneNumber?: string | undefined;
    country?: string | undefined;
    whoReceives?: string | undefined;
    ownerId?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class CustomerReviewDto implements ICustomerReviewDto {
    readonly id?: number | undefined;
    readonly title?: string | undefined;
    readonly comment?: string | undefined;
    readonly email?: string | undefined;
    readonly reviewerName?: string | undefined;
    readonly userName?: string | undefined;
    readonly ratingLevel?: number | undefined;

    constructor(data?: ICustomerReviewDto) {
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
            (<any>this).title = data["title"];
            (<any>this).comment = data["comment"];
            (<any>this).email = data["email"];
            (<any>this).reviewerName = data["reviewerName"];
            (<any>this).userName = data["userName"];
            (<any>this).ratingLevel = data["ratingLevel"];
        }
    }

    static fromJS(data: any): CustomerReviewDto {
        data = typeof data === 'object' ? data : {};
        let result = new CustomerReviewDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["id"] = this.id;
        data["title"] = this.title;
        data["comment"] = this.comment;
        data["email"] = this.email;
        data["reviewerName"] = this.reviewerName;
        data["userName"] = this.userName;
        data["ratingLevel"] = this.ratingLevel;
        return data; 
    }
}

export interface ICustomerReviewDto {
    id?: number | undefined;
    title?: string | undefined;
    comment?: string | undefined;
    email?: string | undefined;
    reviewerName?: string | undefined;
    userName?: string | undefined;
    ratingLevel?: number | undefined;
}

export class StormyCustomer implements IStormyCustomer {
    userId?: string | undefined;
    cpf?: string | undefined;
    normalizedEmail?: string | undefined;
    phoneNumber?: string | undefined;
    phoneNumberConfirmed?: boolean | undefined;
    emailConfirmed?: boolean | undefined;
    customerAddresses?: Address[] | undefined;
    defaultShippingAddress?: Address | undefined;
    defaultShippingAddressId?: number | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultBillingAddressId?: number | undefined;
    customerReviewsId?: number | undefined;
    customerReviews?: Review[] | undefined;
    customerWishlistId?: number | undefined;
    customerWishlist?: Wishlist | undefined;
    userName?: string | undefined;
    fullName?: string | undefined;
    email?: string | undefined;
    createdOn?: Date | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IStormyCustomer) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.userId = data["userId"];
            this.cpf = data["cpf"];
            this.normalizedEmail = data["normalizedEmail"];
            this.phoneNumber = data["phoneNumber"];
            this.phoneNumberConfirmed = data["phoneNumberConfirmed"];
            this.emailConfirmed = data["emailConfirmed"];
            if (Array.isArray(data["customerAddresses"])) {
                this.customerAddresses = [] as any;
                for (let item of data["customerAddresses"])
                    this.customerAddresses!.push(Address.fromJS(item));
            }
            this.defaultShippingAddress = data["defaultShippingAddress"] ? Address.fromJS(data["defaultShippingAddress"]) : <any>undefined;
            this.defaultShippingAddressId = data["defaultShippingAddressId"];
            this.defaultBillingAddress = data["defaultBillingAddress"] ? Address.fromJS(data["defaultBillingAddress"]) : <any>undefined;
            this.defaultBillingAddressId = data["defaultBillingAddressId"];
            this.customerReviewsId = data["customerReviewsId"];
            if (Array.isArray(data["customerReviews"])) {
                this.customerReviews = [] as any;
                for (let item of data["customerReviews"])
                    this.customerReviews!.push(Review.fromJS(item));
            }
            this.customerWishlistId = data["customerWishlistId"];
            this.customerWishlist = data["customerWishlist"] ? Wishlist.fromJS(data["customerWishlist"]) : <any>undefined;
            this.userName = data["userName"];
            this.fullName = data["fullName"];
            this.email = data["email"];
            this.createdOn = data["createdOn"] ? new Date(data["createdOn"].toString()) : <any>undefined;
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StormyCustomer {
        data = typeof data === 'object' ? data : {};
        let result = new StormyCustomer();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userId"] = this.userId;
        data["cpf"] = this.cpf;
        data["normalizedEmail"] = this.normalizedEmail;
        data["phoneNumber"] = this.phoneNumber;
        data["phoneNumberConfirmed"] = this.phoneNumberConfirmed;
        data["emailConfirmed"] = this.emailConfirmed;
        if (Array.isArray(this.customerAddresses)) {
            data["customerAddresses"] = [];
            for (let item of this.customerAddresses)
                data["customerAddresses"].push(item.toJSON());
        }
        data["defaultShippingAddress"] = this.defaultShippingAddress ? this.defaultShippingAddress.toJSON() : <any>undefined;
        data["defaultShippingAddressId"] = this.defaultShippingAddressId;
        data["defaultBillingAddress"] = this.defaultBillingAddress ? this.defaultBillingAddress.toJSON() : <any>undefined;
        data["defaultBillingAddressId"] = this.defaultBillingAddressId;
        data["customerReviewsId"] = this.customerReviewsId;
        if (Array.isArray(this.customerReviews)) {
            data["customerReviews"] = [];
            for (let item of this.customerReviews)
                data["customerReviews"].push(item.toJSON());
        }
        data["customerWishlistId"] = this.customerWishlistId;
        data["customerWishlist"] = this.customerWishlist ? this.customerWishlist.toJSON() : <any>undefined;
        data["userName"] = this.userName;
        data["fullName"] = this.fullName;
        data["email"] = this.email;
        data["createdOn"] = this.createdOn ? this.createdOn.toISOString() : <any>undefined;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IStormyCustomer {
    userId?: string | undefined;
    cpf?: string | undefined;
    normalizedEmail?: string | undefined;
    phoneNumber?: string | undefined;
    phoneNumberConfirmed?: boolean | undefined;
    emailConfirmed?: boolean | undefined;
    customerAddresses?: Address[] | undefined;
    defaultShippingAddress?: Address | undefined;
    defaultShippingAddressId?: number | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultBillingAddressId?: number | undefined;
    customerReviewsId?: number | undefined;
    customerReviews?: Review[] | undefined;
    customerWishlistId?: number | undefined;
    customerWishlist?: Wishlist | undefined;
    userName?: string | undefined;
    fullName?: string | undefined;
    email?: string | undefined;
    createdOn?: Date | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class Review implements IReview {
    stormyCustomerId?: number | undefined;
    author?: StormyCustomer | undefined;
    title?: string | undefined;
    comment?: string | undefined;
    reviewerName?: string | undefined;
    ratingLevel?: number | undefined;
    status?: ReviewStatus | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IReview) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.stormyCustomerId = data["stormyCustomerId"];
            this.author = data["author"] ? StormyCustomer.fromJS(data["author"]) : <any>undefined;
            this.title = data["title"];
            this.comment = data["comment"];
            this.reviewerName = data["reviewerName"];
            this.ratingLevel = data["ratingLevel"];
            this.status = data["status"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Review {
        data = typeof data === 'object' ? data : {};
        let result = new Review();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["stormyCustomerId"] = this.stormyCustomerId;
        data["author"] = this.author ? this.author.toJSON() : <any>undefined;
        data["title"] = this.title;
        data["comment"] = this.comment;
        data["reviewerName"] = this.reviewerName;
        data["ratingLevel"] = this.ratingLevel;
        data["status"] = this.status;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IReview {
    stormyCustomerId?: number | undefined;
    author?: StormyCustomer | undefined;
    title?: string | undefined;
    comment?: string | undefined;
    reviewerName?: string | undefined;
    ratingLevel?: number | undefined;
    status?: ReviewStatus | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class Wishlist implements IWishlist {
    customerId?: number | undefined;
    customer?: StormyCustomer | undefined;
    wishlistItems?: WishlistItem[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IWishlist) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.customerId = data["customerId"];
            this.customer = data["customer"] ? StormyCustomer.fromJS(data["customer"]) : <any>undefined;
            if (Array.isArray(data["wishlistItems"])) {
                this.wishlistItems = [] as any;
                for (let item of data["wishlistItems"])
                    this.wishlistItems!.push(WishlistItem.fromJS(item));
            }
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Wishlist {
        data = typeof data === 'object' ? data : {};
        let result = new Wishlist();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["customerId"] = this.customerId;
        data["customer"] = this.customer ? this.customer.toJSON() : <any>undefined;
        if (Array.isArray(this.wishlistItems)) {
            data["wishlistItems"] = [];
            for (let item of this.wishlistItems)
                data["wishlistItems"].push(item.toJSON());
        }
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IWishlist {
    customerId?: number | undefined;
    customer?: StormyCustomer | undefined;
    wishlistItems?: WishlistItem[] | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class WishlistItem implements IWishlistItem {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    wishlistId?: number | undefined;
    wishlist?: Wishlist | undefined;
    addedAt?: Date | undefined;
    deleted?: boolean | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IWishlistItem) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.wishlistId = data["wishlistId"];
            this.wishlist = data["wishlist"] ? Wishlist.fromJS(data["wishlist"]) : <any>undefined;
            this.addedAt = data["addedAt"] ? new Date(data["addedAt"].toString()) : <any>undefined;
            this.deleted = data["deleted"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): WishlistItem {
        data = typeof data === 'object' ? data : {};
        let result = new WishlistItem();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["wishlistId"] = this.wishlistId;
        data["wishlist"] = this.wishlist ? this.wishlist.toJSON() : <any>undefined;
        data["addedAt"] = this.addedAt ? this.addedAt.toISOString() : <any>undefined;
        data["deleted"] = this.deleted;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IWishlistItem {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    wishlistId?: number | undefined;
    wishlist?: Wishlist | undefined;
    addedAt?: Date | undefined;
    deleted?: boolean | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

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

export class StormyVendor implements IStormyVendor {
    companyName?: string | undefined;
    contactTitle?: string | undefined;
    addressId?: number | undefined;
    address?: Address | undefined;
    phone?: string | undefined;
    email?: string | undefined;
    webSite?: string | undefined;
    typeGoods?: string | undefined;
    sizeUrl?: string | undefined;
    logo?: string | undefined;
    note?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IStormyVendor) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.companyName = data["companyName"];
            this.contactTitle = data["contactTitle"];
            this.addressId = data["addressId"];
            this.address = data["address"] ? Address.fromJS(data["address"]) : <any>undefined;
            this.phone = data["phone"];
            this.email = data["email"];
            this.webSite = data["webSite"];
            this.typeGoods = data["typeGoods"];
            this.sizeUrl = data["sizeUrl"];
            this.logo = data["logo"];
            this.note = data["note"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): StormyVendor {
        data = typeof data === 'object' ? data : {};
        let result = new StormyVendor();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["companyName"] = this.companyName;
        data["contactTitle"] = this.contactTitle;
        data["addressId"] = this.addressId;
        data["address"] = this.address ? this.address.toJSON() : <any>undefined;
        data["phone"] = this.phone;
        data["email"] = this.email;
        data["webSite"] = this.webSite;
        data["typeGoods"] = this.typeGoods;
        data["sizeUrl"] = this.sizeUrl;
        data["logo"] = this.logo;
        data["note"] = this.note;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IStormyVendor {
    companyName?: string | undefined;
    contactTitle?: string | undefined;
    addressId?: number | undefined;
    address?: Address | undefined;
    phone?: string | undefined;
    email?: string | undefined;
    webSite?: string | undefined;
    typeGoods?: string | undefined;
    sizeUrl?: string | undefined;
    logo?: string | undefined;
    note?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class Brand implements IBrand {
    name?: string | undefined;
    slug?: string | undefined;
    description?: string | undefined;
    website?: string | undefined;
    logoImage?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IBrand) {
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
            this.slug = data["slug"];
            this.description = data["description"];
            this.website = data["website"];
            this.logoImage = data["logoImage"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Brand {
        data = typeof data === 'object' ? data : {};
        let result = new Brand();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["slug"] = this.slug;
        data["description"] = this.description;
        data["website"] = this.website;
        data["logoImage"] = this.logoImage;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IBrand {
    name?: string | undefined;
    slug?: string | undefined;
    description?: string | undefined;
    website?: string | undefined;
    logoImage?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class Media implements IMedia {
    caption?: string | undefined;
    fileSize?: number | undefined;
    fileName?: string | undefined;
    mediaType?: MediaType | undefined;
    seoFileName?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IMedia) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.caption = data["caption"];
            this.fileSize = data["fileSize"];
            this.fileName = data["fileName"];
            this.mediaType = data["mediaType"];
            this.seoFileName = data["seoFileName"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): Media {
        data = typeof data === 'object' ? data : {};
        let result = new Media();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["caption"] = this.caption;
        data["fileSize"] = this.fileSize;
        data["fileName"] = this.fileName;
        data["mediaType"] = this.mediaType;
        data["seoFileName"] = this.seoFileName;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IMedia {
    caption?: string | undefined;
    fileSize?: number | undefined;
    fileName?: string | undefined;
    mediaType?: MediaType | undefined;
    seoFileName?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class ProductLink implements IProductLink {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    linkedProductId?: number | undefined;
    linkedProduct?: StormyProduct | undefined;
    linkType?: ProductLinkLinkType | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductLink) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.linkedProductId = data["linkedProductId"];
            this.linkedProduct = data["linkedProduct"] ? StormyProduct.fromJS(data["linkedProduct"]) : <any>undefined;
            this.linkType = data["linkType"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductLink {
        data = typeof data === 'object' ? data : {};
        let result = new ProductLink();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["linkedProductId"] = this.linkedProductId;
        data["linkedProduct"] = this.linkedProduct ? this.linkedProduct.toJSON() : <any>undefined;
        data["linkType"] = this.linkType;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductLink {
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    linkedProductId?: number | undefined;
    linkedProduct?: StormyProduct | undefined;
    linkType?: ProductLinkLinkType | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

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

export class ProductAttributeValue implements IProductAttributeValue {
    attributeId?: number | undefined;
    attribute?: ProductAttribute | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductAttributeValue) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.attributeId = data["attributeId"];
            this.attribute = data["attribute"] ? ProductAttribute.fromJS(data["attribute"]) : <any>undefined;
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.value = data["value"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductAttributeValue {
        data = typeof data === 'object' ? data : {};
        let result = new ProductAttributeValue();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["attributeId"] = this.attributeId;
        data["attribute"] = this.attribute ? this.attribute.toJSON() : <any>undefined;
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["value"] = this.value;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductAttributeValue {
    attributeId?: number | undefined;
    attribute?: ProductAttribute | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

export class ProductOptionValue implements IProductOptionValue {
    optionId?: number | undefined;
    option?: ProductOption | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    displayType?: string | undefined;
    sortIndex?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductOptionValue) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            this.optionId = data["optionId"];
            this.option = data["option"] ? ProductOption.fromJS(data["option"]) : <any>undefined;
            this.productId = data["productId"];
            this.product = data["product"] ? StormyProduct.fromJS(data["product"]) : <any>undefined;
            this.value = data["value"];
            this.displayType = data["displayType"];
            this.sortIndex = data["sortIndex"];
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductOptionValue {
        data = typeof data === 'object' ? data : {};
        let result = new ProductOptionValue();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["optionId"] = this.optionId;
        data["option"] = this.option ? this.option.toJSON() : <any>undefined;
        data["productId"] = this.productId;
        data["product"] = this.product ? this.product.toJSON() : <any>undefined;
        data["value"] = this.value;
        data["displayType"] = this.displayType;
        data["sortIndex"] = this.sortIndex;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductOptionValue {
    optionId?: number | undefined;
    option?: ProductOption | undefined;
    productId?: number | undefined;
    product?: StormyProduct | undefined;
    value?: string | undefined;
    displayType?: string | undefined;
    sortIndex?: number | undefined;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

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

export class ProductOption implements IProductOption {
    name!: string;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;

    constructor(data?: IProductOption) {
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
            this.lastModified = data["lastModified"] ? new Date(data["lastModified"].toString()) : <any>undefined;
            this.isDeleted = data["isDeleted"];
            this.id = data["id"];
        }
    }

    static fromJS(data: any): ProductOption {
        data = typeof data === 'object' ? data : {};
        let result = new ProductOption();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["name"] = this.name;
        data["lastModified"] = this.lastModified ? this.lastModified.toISOString() : <any>undefined;
        data["isDeleted"] = this.isDeleted;
        data["id"] = this.id;
        return data; 
    }
}

export interface IProductOption {
    name: string;
    lastModified?: Date | undefined;
    isDeleted?: boolean | undefined;
    id?: number | undefined;
}

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

export class CustomerDto implements ICustomerDto {
    readonly userName?: string | undefined;
    readonly email?: string | undefined;
    readonly customerAddresses?: Address[] | undefined;
    readonly defaultBillingAddress?: Address | undefined;
    readonly defaultShippingAddress?: Address | undefined;
    readonly cpf?: string | undefined;
    readonly phoneNumber?: string | undefined;
    readonly fullName?: string | undefined;

    constructor(data?: ICustomerDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        if (data) {
            (<any>this).userName = data["userName"];
            (<any>this).email = data["email"];
            if (Array.isArray(data["customerAddresses"])) {
                (<any>this).customerAddresses = [] as any;
                for (let item of data["customerAddresses"])
                    (<any>this).customerAddresses!.push(Address.fromJS(item));
            }
            (<any>this).defaultBillingAddress = data["defaultBillingAddress"] ? Address.fromJS(data["defaultBillingAddress"]) : <any>undefined;
            (<any>this).defaultShippingAddress = data["defaultShippingAddress"] ? Address.fromJS(data["defaultShippingAddress"]) : <any>undefined;
            (<any>this).cpf = data["cpf"];
            (<any>this).phoneNumber = data["phoneNumber"];
            (<any>this).fullName = data["fullName"];
        }
    }

    static fromJS(data: any): CustomerDto {
        data = typeof data === 'object' ? data : {};
        let result = new CustomerDto();
        result.init(data);
        return result;
    }

    toJSON(data?: any) {
        data = typeof data === 'object' ? data : {};
        data["userName"] = this.userName;
        data["email"] = this.email;
        if (Array.isArray(this.customerAddresses)) {
            data["customerAddresses"] = [];
            for (let item of this.customerAddresses)
                data["customerAddresses"].push(item.toJSON());
        }
        data["defaultBillingAddress"] = this.defaultBillingAddress ? this.defaultBillingAddress.toJSON() : <any>undefined;
        data["defaultShippingAddress"] = this.defaultShippingAddress ? this.defaultShippingAddress.toJSON() : <any>undefined;
        data["cpf"] = this.cpf;
        data["phoneNumber"] = this.phoneNumber;
        data["fullName"] = this.fullName;
        return data; 
    }
}

export interface ICustomerDto {
    userName?: string | undefined;
    email?: string | undefined;
    customerAddresses?: Address[] | undefined;
    defaultBillingAddress?: Address | undefined;
    defaultShippingAddress?: Address | undefined;
    cpf?: string | undefined;
    phoneNumber?: string | undefined;
    fullName?: string | undefined;
}

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

export enum ReviewStatus {
    _1 = 1,
    _5 = 5,
    _8 = 8,
}

export enum MediaType {
    _1 = 1,
    _5 = 5,
    _10 = 10,
}

export enum ProductLinkLinkType {
    _1 = 1,
    _2 = 2,
    _3 = 3,
    _4 = 4,
}

export enum OrderDtoStatus {
    _1 = 1,
    _10 = 10,
    _20 = 20,
    _30 = 30,
    _35 = 35,
    _40 = 40,
    _50 = 50,
    _60 = 60,
    _70 = 70,
    _80 = 80,
    _90 = 90,
    _100 = 100,
}

export enum OrderDtoShippingStatus {
    _1 = 1,
    _5 = 5,
    _10 = 10,
    _15 = 15,
    _20 = 20,
}


