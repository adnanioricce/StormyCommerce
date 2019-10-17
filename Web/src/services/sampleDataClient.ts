import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { throwException } from '../models/apiException';

export interface ISampleDataApiClient {
    /**
     * @return Success
     */
    seedDatabase(): Promise<void>;
}

export class SampleDataApiClient implements ISampleDataApiClient {
    private instance: AxiosInstance;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, instance?: AxiosInstance) {
        this.instance = instance ? instance : axios.create();
        this.baseUrl = baseUrl ? baseUrl : "https://localhost:443";
    }

    /**
     * @return Success
     */
    seedDatabase(): Promise<void> {
        let url_ = this.baseUrl + "/seed";
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processSeedDatabase(_response);
        });
    }

    protected processSeedDatabase(response: AxiosResponse): Promise<void> {
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