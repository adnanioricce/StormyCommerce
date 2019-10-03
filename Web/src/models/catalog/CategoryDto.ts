
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