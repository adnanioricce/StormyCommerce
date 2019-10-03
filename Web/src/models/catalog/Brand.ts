
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