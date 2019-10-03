import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { CategoryDto } from '../models/catalog/CategoryDto';
import { Category } from '../models/catalog/Category';
import { throwException } from "../models/apiException";
export interface ICategoryClient {
    /**
     * @return Success
     */
    getAll(): Promise<CategoryDto[]>;
    /**
     * @return Success
     */
    getCategoryById(id: number): Promise<CategoryDto>;
    /**
     * @param category (optional) 
     * @return Success
     */
    createCategory(category?: Category | null | undefined): Promise<void>;
    /**
     * @param category (optional) 
     * @return Success
     */
    editCategory(id: string, category?: Category | null | undefined): Promise<void>;
}

export class CategoryClient implements ICategoryClient {
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
    getAll(): Promise<CategoryDto[]> {
        let url_ = this.baseUrl + "/api/Category/GetAll/list";
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetAll(_response);
        });
    }

    protected processGetAll(response: AxiosResponse): Promise<CategoryDto[]> {
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
                    result200!.push(CategoryDto.fromJS(item));
            }
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<CategoryDto[]>(<any>null);
    }

    /**
     * @return Success
     */
    getCategoryById(id: number): Promise<CategoryDto> {
        let url_ = this.baseUrl + "/api/Category/GetCategoryById/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetCategoryById(_response);
        });
    }

    protected processGetCategoryById(response: AxiosResponse): Promise<CategoryDto> {
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
            result200 = CategoryDto.fromJS(resultData200);
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<CategoryDto>(<any>null);
    }

    /**
     * @param category (optional) 
     * @return Success
     */
    createCategory(category?: Category | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Category/CreateCategory";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(category);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processCreateCategory(_response);
        });
    }

    protected processCreateCategory(response: AxiosResponse): Promise<void> {
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
     * @param category (optional) 
     * @return Success
     */
    editCategory(id: string, category?: Category | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Category/EditCategory/{id}";
        if (id === undefined || id === null)
            throw new Error("The parameter 'id' must be defined.");
        url_ = url_.replace("{id}", encodeURIComponent("" + id)); 
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(category);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "PUT",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processEditCategory(_response);
        });
    }

    protected processEditCategory(response: AxiosResponse): Promise<void> {
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
