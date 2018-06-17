class CookieViewModel extends BaseViewModel {

    constructor(amountCookies = 0) {
        super();

        this.gameState = ko.observable(null);
        self = this;

        $.ajax({
            url: "/GameState/GetLast",
            method: "GET",
            success: function (gameState) {
                console.log(gameState)
                self.gameState(ko.mapping.fromJS(gameState));
            }
        });

        this.popups = ko.observableArray([]);
    }

    addCookie() {
        this.gameState().money(this.gameState().money() + this.gameState().clickAmount());

        let newPopup = new Popup(this.gameState().clickAmount() + "+", { x: 0, y: 50 }, { x: 200, y: 250 });
        
        this.popups.push(newPopup);

        setTimeout(this.popups.remove.bind(this.popups, newPopup), 2000);
    }

    saveGameState() {

    }
}