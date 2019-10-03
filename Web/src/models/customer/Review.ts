import { StormyCustomer } from "./StormyCustomer";
import { ReviewStatus } from "./ReviewStatus";

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