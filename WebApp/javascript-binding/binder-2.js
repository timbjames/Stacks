/* model */

    var defaults = {
        selectors: {
            fullname: "#fullname",
            firstname: "#firstname",
            lastname: "#lastname"
        }
    };

    var nameConcatenater = function (options) {

        var self = this;

        self.options = $.extend({}, defaults, options);
        
        self.setBindings = function () {

            var self = this;
            
            $(self.options.selectors.firstname).on('keyup', function () {
                self.updateFullname();
            });

        };

        self.updateFullname = function () {
            var self = this;
            var firstname = $(self.options.selectors.firstname).val();
            $(self.options.selectors.fullname).text(firstname);
        };
                
        self.setBindings();

    };


    $(function () {  
        var instance = new nameConcatenater();
    });