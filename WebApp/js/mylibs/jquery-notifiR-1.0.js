(function ($) {

    $.notifiR = function (options) {
        options = $.extend(true, {
            msg: '',
            title: '',
            modal: true,
            autoOpen: true,
            position: 'center',
            zIndex: 99999,
            showSpeed: 250,
            stopOnHover: false,
            duration: 2000,
            autoClose: true,
            fadeOutSpeed: 9000,
            type: 'error'
        }, options);

        var wHeight = $(window).height();
        var wWidth = $(window).width();

        var modal = $('<div class=\"notifiR-modal\" />');
        var icon = $('<span class=\"ui-icon\" style=\"float: left; margin-right: .3em\" />');
        var title = $('<strong />');
        title.text(options.title);
        var notifiR = $('<div class=\"notifiR\" />'); //.text(options.msg);
        if (options.modal) {
            modal.appendTo('body')
            modal.css({ width: wWidth, height: wHeight }).addClass('ui-widget-overlay');
        };
        notifiR.appendTo('body');
        notifiR.addClass('ui-corner-all');
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
        notifiR.append(icon).append(title).append(' ' + options.msg);

        if (options.autoClose) {
            notifiR.fadeOut(options.fadeOutSpeed, function () { $('.notifiR-modal').remove(); $(this).remove() });
        }
    };

})(jQuery);