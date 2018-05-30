class BasicViewModel {


    constructor() {
        this.css = ko.observable(null);
        this.click = ko.observable(() => { });
    }
}