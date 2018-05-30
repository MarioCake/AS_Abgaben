class CookieViewModel extends BaseViewModel {

    constructor(amountCookies = 0) {
        super();

        this.amountCookies = ko.observable(amountCookies);
        this.cookieClickAmount = 1;

        this.popups = ko.observableArray([]);
    }

    addCookie() {
        this.amountCookies(this.amountCookies() + this.cookieClickAmount);

        let newPopup = new Popup(this.cookieClickAmount + "+", { x: 0, y: 0 }, { x: 200, y: 200 });
        this.popups.push(newPopup);

        setTimeout(this.popups.remove.bind(popups, popup), 2500);
    }
}