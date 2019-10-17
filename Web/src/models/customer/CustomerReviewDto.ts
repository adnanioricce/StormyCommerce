
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