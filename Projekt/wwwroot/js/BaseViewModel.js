class BaseViewModel {

    constructor() {
        this.css = ko.observable(null);
        this.click = ko.observable(() => { });
        this.style = ko.observable({});
    }

}