class CookieViewModel extends BaseViewModel {

    constructor(amountCookies = 0) {
        super();

        this.gameState = ko.observable(null);

        $.ajax({
            url: "/GameState/GetLast",
            method: "GET",
            success: function (gameState) {
                this.gameState(ko.mapping.fromJS(gameState));
            }
        });

        this.popups = ko.observableArray([]);
    }

    addCookie() {
        this.amountCookies(this.amountCookies() + this.cookieClickAmount);

        let newPopup = new Popup(this.cookieClickAmount + "+", { x: 0, y: 0 }, { x: 200, y: 200 });
        
        this.popups.push(newPopup);

        setTimeout(this.popups.remove.bind(this.popups, newPopup), 2000);
    }
}