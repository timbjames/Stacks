
var run1 = (function () {
    "use strict";

    return {
        after: function (milliseconds, action) {
            setTimeout(action, milliseconds);
        },
        every: function (milliseconds, action) {
            setInterval(action,milliseconds);
        }
    };

}());

var run1Instance = run1;
console.log(run1Instance);

var run2 = function () {

    var self = this;
    self.after = function (milliseconds, action) {
        setTimeout(action, milliseconds);
    };
    self.every = function (milliseconds, action) {
        setInterval(action, milliseconds);
    }

};

var run2Instance = new run2();
console.log(run2Instance);

(function (window, $) {

    var run3 = function () {

    };

    run3.prototype.after = function (milliseconds, action) {
        setTimeout(action, milliseconds);
    };

    run3.prototype.every = function (milliseconds, action) {
        setInterval(action, milliseconds);
    };

    window.Run3 = run3;

})(window, jQuery);

var run3Instance = new Run3();
console.log(run3Instance);

