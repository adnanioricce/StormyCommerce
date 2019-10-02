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