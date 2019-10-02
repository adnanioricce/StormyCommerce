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