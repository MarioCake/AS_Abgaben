class Popup extends BasicViewModel {

    static upMoveRange = 200;
    static sideMoveRange = 50;

    constructor(text, minPosition, maxPosition) {
        this.text = ko.observable(text);

        let randomX = Math.random() * (maxPosition.x - minPosition.x) + minPosition.x;
        let randomY = Math.random() * (maxPosition.y - minPosition.y) + minPosition.y;

        this.position = ko.observable({ x: randomX, y: randomY });

        runAnimation();
    }

    runAnimation() {
        addElement();

        this.css({
            "popup-hide": false
        });
        this.css({
            "popup-hide": true
        });

        this.position().y -= Math.random() * upMoveRange + upMoveRange / 4;
        this.position().x += Math.random() * sideMoveRange - sideMoveRange / 2;
    }

}