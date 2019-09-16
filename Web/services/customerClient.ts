import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { Address, CustomerReviewDto, StormyCustomer, CustomerDto } from './stormyApi';
import { throwException } from '../models/apiException';

export interface ICustomerClient {
    /**
     * @param address (optional) 
     * @return Success
     */
    addAddress(address?: Address | null | undefined): Promise<void>;
    /**
     * @param review (optional) 
     * @return Success
     */
    writeReview(review?: CustomerReviewDto | null | undefined): Promise<void>;
    /**
     * @param minLimit (optional) 
     * @param maxLimit (optional) 
     * @return Success
     */
    getCustomers(minLimit?: number | null | undefined, maxLimit?: number | null | undefined): Promise<StormyCustomer[]>;
    /**
     * @param email (optional) 
     * @param username (optional) 
     * @return Success
     */
    getCustomerByEmailOrUsername(email?: string | null | undefined, username?: string | null | undefined): Promise<CustomerDto>;
    /**
     * @param customerDto (optional) 
     * @return Success
     */
    createCustomer(customerDto?: CustomerDto | null | undefined): Promise<void>;
}

export class CustomerClient implements ICustomerClient {
    private instance: AxiosInstance;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, instance?: AxiosInstance) {
        this.instance = instance ? instance : axios.create();
        this.baseUrl = baseUrl ? baseUrl : "https://localhost:443";
    }

    /**
     * @param address (optional) 
     * @return Success
     */
    addAddress(address?: Address | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/address/create";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(address);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processAddAddress(_response);
        });
    }

    protected processAddAddress(response: AxiosResponse): Promise<void> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            return Promise.resolve<void>(<any>_responseText);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<void>(<any>null);
    }

    /**
     * @param review (optional) 
     * @return Success
     */
    writeReview(review?: CustomerReviewDto | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/review/create";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(review);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processWriteReview(_response);
        });
    }

    protected processWriteReview(response: AxiosResponse): Promise<void> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            return Promise.resolve<void>(<any>_responseText);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<void>(<any>null);
    }

    /**
     * @param minLimit (optional) 
     * @param maxLimit (optional) 
     * @return Success
     */
    getCustomers(minLimit?: number | null | undefined, maxLimit?: number | null | undefined): Promise<StormyCustomer[]> {
        let url_ = this.baseUrl + "/admin/customer/list?";
        if (minLimit !== undefined)
            url_ += "minLimit=" + encodeURIComponent("" + minLimit) + "&"; 
        if (maxLimit !== undefined)
            url_ += "maxLimit=" + encodeURIComponent("" + maxLimit) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetCustomers(_response);
        });
    }

    protected processGetCustomers(response: AxiosResponse): Promise<StormyCustomer[]> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            let result200: any = null;
            let resultData200  = _responseText;
            if (Array.isArray(resultData200)) {
                result200 = [] as any;
                for (let item of resultData200)
                    result200!.push(StormyCustomer.fromJS(item));
            }
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<StormyCustomer[]>(<any>null);
    }

    /**
     * @param email (optional) 
     * @param username (optional) 
     * @return Success
     */
    getCustomerByEmailOrUsername(email?: string | null | undefined, username?: string | null | undefined): Promise<CustomerDto> {
        let url_ = this.baseUrl + "/customer/getbyemail?";
        if (email !== undefined)
            url_ += "email=" + encodeURIComponent("" + email) + "&"; 
        if (username !== undefined)
            url_ += "username=" + encodeURIComponent("" + username) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetCustomerByEmailOrUsername(_response);
        });
    }

    protected processGetCustomerByEmailOrUsername(response: AxiosResponse): Promise<CustomerDto> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            let result200: any = null;
            let resultData200  = _responseText;
            result200 = CustomerDto.fromJS(resultData200);
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<CustomerDto>(<any>null);
    }

    /**
     * @param customerDto (optional) 
     * @return Success
     */
    createCustomer(customerDto?: CustomerDto | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/createcustomer";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(customerDto);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processCreateCustomer(_response);
        });
    }

    protected processCreateCustomer(response: AxiosResponse): Promise<void> {
        const status = response.status;
        let _headers: any = {};
        if (response.headers && typeof response.headers === "object") {
            for (let k in response.headers) {
                if (response.headers.hasOwnProperty(k)) {
                    _headers[k] = response.headers[k];
                }
            }
        }
        if (status === 200) {
            const _responseText = response.data;
            return Promise.resolve<void>(<any>_responseText);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<void>(<any>null);
    }
}