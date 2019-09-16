import { throwException } from "../models/apiException";
import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { OrderDto } from "./stormyApi";
export interface IOrderClient {
    /**
     * @param orderDto (optional) 
     * @return Success
     */
    createOrder(orderDto?: OrderDto | null | undefined): Promise<void>;
}

export class OrderClient implements IOrderClient {
    private instance: AxiosInstance;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, instance?: AxiosInstance) {
        this.instance = instance ? instance : axios.create();
        this.baseUrl = baseUrl ? baseUrl : "https://localhost:443";
    }

    /**
     * @param orderDto (optional) 
     * @return Success
     */
    createOrder(orderDto?: OrderDto | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/create";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(orderDto);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processCreateOrder(_response);
        });
    }

    protected processCreateOrder(response: AxiosResponse): Promise<void> {
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