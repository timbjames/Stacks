(function (window, $) {

    var defaults = {
        id: '#one',
        selectors: {
            fullname: ".fullname",
            firstname: ".firstname",
            lastname: ".lastname"
        }
    };

    var nameConcatenater = function (options) {
        /* see http://api.jquery.com/jQuery.extend/ regarding extend merge defaults and options  */
        this.options = $.extend({}, defaults, options);
        this.setBindings();
    };

    nameConcatenater.prototype.setBindings = function () {

        var self = this;

        $(self.options.id + ' ' + self.options.selectors.firstname).on('keyup', function () {
            self.updateFullname();
        });

    };

    nameConcatenater.prototype.updateFullname = function () {
        var self = this;
        var firstname = $(self.options.id + ' ' + self.options.selectors.firstname).val();
        $(self.options.id + ' ' + self.options.selectors.fullname).text(firstname);
    };

    window.NameConcatenater = nameConcatenater;

})(window, jQuery);

$(function () {
    //var instance = new NameConcatenater({ id: '#one' });
    //var instance2 = new NameConcatenater({ id: '#two' });
});