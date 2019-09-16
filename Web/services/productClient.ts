import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { ProductOverviewDto, ProductDto } from './stormyApi';
import {throwException} from '../models/apiException';
export interface IProductClient {
    /**
     * @param id (optional) 
     * @return Success
     */
    getProductOverview(_0: string, id?: number | null | undefined): Promise<ProductOverviewDto>;
    /**
     * @param startIndex (optional) 
     * @param endIndex (optional) 
     * @return Success
     */
    getAllProducts(startIndex?: number | null | undefined, endIndex?: number | null | undefined): Promise<ProductDto[]>;
    /**
     * @param limit (optional) 
     * @return Success
     */
    getAllProductsOnHomepage(limit?: number | null | undefined): Promise<ProductDto[]>;
    /**
     * @param id (optional) 
     * @return Success
     */
    getProductById(_0: string, id?: number | null | undefined): Promise<ProductDto>;
    /**
     * @param _model (optional) 
     * @return Success
     */
    createProduct(_model?: ProductDto | null | undefined): Promise<void>;
    /**
     * @param _model (optional) 
     * @return Success
     */
    editProduct(_model?: ProductDto | null | undefined): Promise<void>;
    /**
     * @param categoryIds (optional) 
     * @return Success
     */
    getNumberOfProductsInCategory(categoryIds?: number[] | null | undefined): Promise<number>;
    /**
     * @param categoryId (optional) 
     * @param limit (optional) 
     * @return Success
     */
    getAllProductsOnCategory(categoryId?: number | null | undefined, limit?: number | null | undefined): Promise<ProductDto[]>;
}

export default class ProductClient implements IProductClient {
    private instance: AxiosInstance;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, instance?: AxiosInstance) {
        this.instance = instance ? instance : axios.create();
        this.baseUrl = baseUrl ? baseUrl : "https://localhost:443";
    }

    /**
     * @param id (optional) 
     * @return Success
     */
    getProductOverview(_0: string, id?: number | null | undefined): Promise<ProductOverviewDto> {
        let url_ = this.baseUrl + "/api/Product/GetProductOverviewAsync/{0}?";
        if (_0 === undefined || _0 === null)
            throw new Error("The parameter '_0' must be defined.");
        url_ = url_.replace("{0}", encodeURIComponent("" + _0)); 
        if (id !== undefined)
            url_ += "id=" + encodeURIComponent("" + id) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetProductOverview(_response);
        });
    }

    protected processGetProductOverview(response: AxiosResponse): Promise<ProductOverviewDto> {
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
            result200 = ProductOverviewDto.fromJS(resultData200);
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<ProductOverviewDto>(<any>null);
    }

    /**
     * @param startIndex (optional) 
     * @param endIndex (optional) 
     * @return Success
     */
    getAllProducts(startIndex?: number | null | undefined, endIndex?: number | null | undefined): Promise<ProductDto[]> {
        let url_ = this.baseUrl + "/api/Product/GetAllProducts?";
        if (startIndex !== undefined)
            url_ += "startIndex=" + encodeURIComponent("" + startIndex) + "&"; 
        if (endIndex !== undefined)
            url_ += "endIndex=" + encodeURIComponent("" + endIndex) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetAllProducts(_response);
        });
    }

    protected processGetAllProducts(response: AxiosResponse): Promise<ProductDto[]> {
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
                    result200!.push(ProductDto.fromJS(item));
            }
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<ProductDto[]>(<any>null);
    }

    /**
     * @param limit (optional) 
     * @return Success
     */
    getAllProductsOnHomepage(limit?: number | null | undefined): Promise<ProductDto[]> {
        let url_ = this.baseUrl + "/api/Product/GetAllProductsOnHomepage?";
        if (limit !== undefined)
            url_ += "limit=" + encodeURIComponent("" + limit) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetAllProductsOnHomepage(_response);
        });
    }

    protected processGetAllProductsOnHomepage(response: AxiosResponse): Promise<ProductDto[]> {
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
                    result200!.push(ProductDto.fromJS(item));
            }
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<ProductDto[]>(<any>null);
    }

    /**
     * @param id (optional) 
     * @return Success
     */
    getProductById(_0: string, id?: number | null | undefined): Promise<ProductDto> {
        let url_ = this.baseUrl + "/api/Product/GetProductById/{0}?";
        if (_0 === undefined || _0 === null)
            throw new Error("The parameter '_0' must be defined.");
        url_ = url_.replace("{0}", encodeURIComponent("" + _0)); 
        if (id !== undefined)
            url_ += "id=" + encodeURIComponent("" + id) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetProductById(_response);
        });
    }

    protected processGetProductById(response: AxiosResponse): Promise<ProductDto> {
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
            result200 = ProductDto.fromJS(resultData200);
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<ProductDto>(<any>null);
    }

    /**
     * @param _model (optional) 
     * @return Success
     */
    createProduct(_model?: ProductDto | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Product/CreateProduct";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(_model);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processCreateProduct(_response);
        });
    }

    protected processCreateProduct(response: AxiosResponse): Promise<void> {
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
     * @param _model (optional) 
     * @return Success
     */
    editProduct(_model?: ProductDto | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Product/EditProduct";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(_model);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "PUT",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processEditProduct(_response);
        });
    }

    protected processEditProduct(response: AxiosResponse): Promise<void> {
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
     * @param categoryIds (optional) 
     * @return Success
     */
    getNumberOfProductsInCategory(categoryIds?: number[] | null | undefined): Promise<number> {
        let url_ = this.baseUrl + "/api/Product/GetNumberOfProductsInCategory";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(categoryIds);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "GET",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetNumberOfProductsInCategory(_response);
        });
    }

    protected processGetNumberOfProductsInCategory(response: AxiosResponse): Promise<number> {
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
            result200 = resultData200 !== undefined ? resultData200 : <any>null;
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<number>(<any>null);
    }

    /**
     * @param categoryId (optional) 
     * @param limit (optional) 
     * @return Success
     */
    getAllProductsOnCategory(categoryId?: number | null | undefined, limit?: number | null | undefined): Promise<ProductDto[]> {
        let url_ = this.baseUrl + "/api/Product/GetAllProductsOnCategory?";
        if (categoryId !== undefined)
            url_ += "categoryId=" + encodeURIComponent("" + categoryId) + "&"; 
        if (limit !== undefined)
            url_ += "limit=" + encodeURIComponent("" + limit) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "GET",
            url: url_,
            headers: {
                "Accept": "application/json"
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processGetAllProductsOnCategory(_response);
        });
    }

    protected processGetAllProductsOnCategory(response: AxiosResponse): Promise<ProductDto[]> {
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
                    result200!.push(ProductDto.fromJS(item));
            }
            return result200;
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<ProductDto[]>(<any>null);
    }
}