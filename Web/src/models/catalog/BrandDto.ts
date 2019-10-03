
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