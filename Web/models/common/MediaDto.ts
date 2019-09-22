
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