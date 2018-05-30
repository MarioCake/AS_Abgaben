class CookieViewModel extends BaseViewModel {

    constructor(amountCookies = 0) {
        this.amountCookies = ko.observable(amountCookies);
        this.cookieClickAmount = 1;
    }

    addCookie() {
        this.amountCookies(this.amountCookies() + this.cookieClickAmount);
    }
}