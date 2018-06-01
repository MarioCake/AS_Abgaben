class Popup extends BaseViewModel {

    static get upMoveRange() { return 200; }
    static get sideMoveRange() { return 50; }

    constructor(text, minPosition, maxPosition) {
        super();

        this.text = ko.observable(text);

        let randomX = Math.random() * (maxPosition.x - minPosition.x) + minPosition.x;
        let randomY = Math.random() * (maxPosition.y - minPosition.y) + minPosition.y;

        this.position = ko.observable({ x: randomX, y: randomY });

        this.runAnimation();
    }

    runAnimation() {


        this.css({
            "popup-show": true
        });

        this.style({
            left: this.position().x + "px",
            top: this.position().y + "px"
        });

        setTimeout(() => {
            this.css({
                "popup-hide": true
            });

            this.position().y -= Math.random() * Popup.upMoveRange + Popup.upMoveRange / 4;
            this.position().x += Math.random() * Popup.sideMoveRange - Popup.sideMoveRange / 2;

            this.style({
                left: this.position().x + "px",
                top: this.position().y + "px"
            });
        }, 100);

    }

}