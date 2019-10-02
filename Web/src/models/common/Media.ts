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
export enum MediaType {
    _1 = 1,
    _5 = 5,
    _10 = 10,
}