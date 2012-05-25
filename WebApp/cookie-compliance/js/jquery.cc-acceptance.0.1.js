(function ($) {
    $.euCookieCompliance = function (options) {
        //if ($.cookie('eucc') === null) {
        var msg = '<h1>Our Cookie Policy</h1><p>By closing this message, you consent to our use of cookies in accordance with our cookie policy.</p>';
        if (options) { if (options.msg) { msg = options.msg; } }
        msg += '<div class=\"wrapper\"><a class=\"cancel close\" href=\"#\">close<span></span></a></div>';
        var modal = $('<div />');
        $(modal).addClass('modal-window');
        $(modal).attr('id', 'dialog');
        var overlay = $('<div />');
        $(overlay).addClass('mask');
        $(overlay).attr('id', 'mask');
        $(modal).append(msg)
        $(modal).appendTo('body');
        $(overlay).appendTo('body');
        var maskHeight = $(document).height();
        var maskWidth = $(window).width();
        var winH = $(window).height();
        var winW = $(window).width();
        $('#mask').css({ 'width': maskWidth, 'height': maskHeight });
        $('#mask').fadeIn(500);
        $('#mask').fadeTo("slow", 0.8);
        $('.modal-window').css('top', (winH / 2) - ($('.modal-window').height() / 2));
        $('.modal-window').css('left', (winW / 2) - ($('.modal-window').width() / 2));
        $('.modal-window').fadeIn(2000);
        $('.modal-window .close').click(function (e) { e.preventDefault(); $.cookie('eucc', 'yes', { path: '/', expires: 30 }); $('#mask').hide(); $('.modal-window').hide(); });
        //}
    };
})(jQuery);