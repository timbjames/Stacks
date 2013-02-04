(function ($) {

    $.notifiR = function (options) {
        options = $.extend(true, {
            msg: '',
            title: '',
            modal: false,
            autoOpen: true,
            position: 'center',
            zIndex: 99999,
            showSpeed: 250,
            stopOnHover: false,
            duration: 2000,
            autoClose: true,
            delay: 3000,
            fadeOutSpeed: 3000,
            type: 'error'
        }, options);

        var wHeight = $(window).height();
        var wWidth = $(window).width();

        var modal = $('<div class=\"notifiR-modal\" />');
        var icon = $('<span class=\"ui-icon\" style=\"float: left; margin-right: .3em\" />');
        var notifiR = $('<div class=\"notifiR\" />');

        var title = $('<strong />');
        title.text(options.title);
        
        /* if modal, then apply */
        if (options.modal) {
            modal.appendTo('body')
            modal.css({ width: wWidth, height: wHeight }).addClass('ui-widget-overlay');
        };

        /* append elements to notifiR and append to body */
        notifiR.append(icon).append(title).append(' ' + options.msg).appendTo('body');
        notifiR.addClass('ui-corner-all');

        /* switch style based on type */
        switch (options.type) {
            case "error":
                notifiR.addClass('ui-state-error');
                icon.addClass('ui-icon-alert');
                break;
            case "instruct":
                notifiR.addClass('ui-state-highlight');
                icon.addClass('ui-icon-info');
                break;
        }
        
        /* set the delay and fadeout if autoClose */
        if (options.autoClose) {
            notifiR.delay(options.delay).fadeOut(options.fadeOutSpeed, function () { $('.notifiR-modal').remove(); $(this).remove() });
        }
    };

})(jQuery);