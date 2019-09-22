import axios, { AxiosInstance, AxiosRequestConfig, AxiosResponse } from 'axios';
import { SignInVm } from '../models/identity/SignInVm';
import { SignUpVm } from '../models/identity/SignUpVm';
import { ResetPasswordViewModel } from '../models/identity/ResetPasswordViewModel';
import { ForgotPasswordViewModel } from '../models/identity/ForgotPasswordViewModel';
import { throwException } from '../models/apiException';
export interface IAuthenticationClient {
    /**
     * @param signInVm (optional) 
     * @return Success
     */
    login(signInVm?: SignInVm | null | undefined): Promise<void>;
    /**
     * @param signUpVm (optional) 
     * @return Success
     */
    register(signUpVm?: SignUpVm | null | undefined): Promise<void>;
    /**
     * @param email (optional) 
     * @param code (optional) 
     * @return Success
     */
    confirmEmail(email?: string | null | undefined, code?: string | null | undefined): Promise<void>;
    /**
     * @param model (optional) 
     * @return Success
     */
    resetPassword(model?: ResetPasswordViewModel | null | undefined): Promise<void>;
    /**
     * @param model (optional) 
     * @return Success
     */
    forgotPassword(model?: ForgotPasswordViewModel | null | undefined): Promise<void>;
}

export class AuthenticationClient implements IAuthenticationClient {
    private instance: AxiosInstance;
    private baseUrl: string;
    protected jsonParseReviver: ((key: string, value: any) => any) | undefined = undefined;

    constructor(baseUrl?: string, instance?: AxiosInstance) {                    
        this.baseUrl = baseUrl ? baseUrl : "https://localhost:443";
        this.instance = instance ? instance : axios.create();
    }

    /**
     * @param signInVm (optional) 
     * @return Success
     */
    login(signInVm?: SignInVm | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Authentication/login";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(signInVm);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processLogin(_response);
        });
    }

    protected processLogin(response: AxiosResponse): Promise<void> {
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
     * @param signUpVm (optional) 
     * @return Success
     */
    register(signUpVm?: SignUpVm | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Authentication/register";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(signUpVm);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processRegister(_response);
        });
    }

    protected processRegister(response: AxiosResponse): Promise<void> {
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
     * @param email (optional) 
     * @param code (optional) 
     * @return Success
     */
    confirmEmail(email?: string | null | undefined, code?: string | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Authentication/ConfirmEmail?";
        if (email !== undefined)
            url_ += "email=" + encodeURIComponent("" + email) + "&"; 
        if (code !== undefined)
            url_ += "code=" + encodeURIComponent("" + code) + "&"; 
        url_ = url_.replace(/[?&]$/, "");

        let options_ = <AxiosRequestConfig>{
            method: "POST",
            url: url_,
            headers: {
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processConfirmEmail(_response);
        });
    }

    protected processConfirmEmail(response: AxiosResponse): Promise<void> {
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
     * @param model (optional) 
     * @return Success
     */
    resetPassword(model?: ResetPasswordViewModel | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Authentication/ResetPassword";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(model);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processResetPassword(_response);
        });
    }

    protected processResetPassword(response: AxiosResponse): Promise<void> {
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
            return Promise.resolve<any>(<any>_responseText);
        } else if (status !== 200 && status !== 204) {
            const _responseText = response.data;
            return throwException("An unexpected server error occurred.", status, _responseText, _headers);
        }
        return Promise.resolve<void>(<any>null);
    }

    /**
     * @param model (optional) 
     * @return Success
     */
    forgotPassword(model?: ForgotPasswordViewModel | null | undefined): Promise<void> {
        let url_ = this.baseUrl + "/api/Authentication";
        url_ = url_.replace(/[?&]$/, "");

        const content_ = JSON.stringify(model);

        let options_ = <AxiosRequestConfig>{
            data: content_,
            method: "POST",
            url: url_,
            headers: {
                "Content-Type": "application/json", 
            }
        };

        return this.instance.request(options_).then((_response: AxiosResponse) => {
            return this.processForgotPassword(_response);
        });
    }

    protected processForgotPassword(response: AxiosResponse): Promise<void> {
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