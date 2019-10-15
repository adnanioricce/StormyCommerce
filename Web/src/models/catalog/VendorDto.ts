export class VendorDto implements IVendorDto {
    placeholder?: any | undefined;
    constructor(data?: IVendorDto) {
        if (data) {
            for (var property in data) {
                if (data.hasOwnProperty(property))
                    (<any>this)[property] = (<any>data)[property];
            }
        }
    }

    init(data?: any) {
        this.placeholder = data;
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

export interface IVendorDto {
}