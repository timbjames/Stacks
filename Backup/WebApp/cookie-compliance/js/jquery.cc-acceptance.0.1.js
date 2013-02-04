/*
* jQuery EU Cookie Compliance Message Plugin
* By: Tim James [http://timjames.me]
* Version 0.1
* Last Modified: 29/05/2012
*
* Copyright 2012 Tim James
* Dual licensed under the MIT and GPL licenses.
* http://timjames.me/eucc/GPL-LICENSE.txt
* http://timjames.me/eucc/Impromptu/MIT-LICENSE.txt
*/
(function ($) {
    $.euCookieCompliance = function (options) {
        if ($.cookie('_eucc') === null) {
            var msg = '<h1>Our Cookie Policy</h1><p>By closing this message, you consent to our use of cookies in accordance with our cookie policy.</p>';
            if (options) { if (options.msg) { msg = options.msg; } }
            msg += '<div class=\"wrapper\"><a class=\"cancel close\" href=\"#\">close<span></span></a></div>';
            var modal = $('<div />');
            $(modal).addClass('modal-window');
            $(modal).attr('id', 'dialog');
            var overlay = $('<div />');
            $(overlay).addClass('mask').attr('id', 'mask');
            $(modal).append(msg).appendTo('body');
            $(overlay).appendTo('body');
            var maskHeight = $(document).height();
            var maskWidth = $(window).width();
            var winH = $(window).height();
            var winW = $(window).width();
            $('#mask')
                .css({ 'width': maskWidth, 'height': maskHeight })
                .fadeIn(500).fadeTo("slow", 0.8);
            $('.modal-window')
                .css('top', (winH / 2) - ($('.modal-window').height() / 2))
                .css('left', (winW / 2) - ($('.modal-window').width() / 2))
                .fadeIn(2000);
            $('.modal-window .close').click(function (e) { e.preventDefault(); $.cookie('_eucc', guidGenerator(), { path: '/', expires: 30 }); $('#mask').hide(); $('.modal-window').hide(); });
        }
    };
    function guidGenerator() {
        var S4 = function () { return (((1 + Math.random()) * 0x10000) | 0).toString(16).substring(1); };
        return (S4() + S4() + "-" + S4() + "-" + S4() + "-" + S4() + "-" + S4() + S4() + S4());
    }
    $.aaaaaaaghCookies = function () {
        var x = (Math.random() * ($(document).width() - 80)).toFixed();
        var y = (Math.random() * ($(document).height() - 80)).toFixed();
        var i = (Math.random() * 2).toFixed();
        var cookies = ['c-1', 'c-2', 'c-3'];
        var cHolder = $('<div />').css({ 'position': 'absolute', 'left': x + 'px', 'top': y + 'px' }).append('<img src="img/' + cookies[i] + '.png" />');
        $('body').append(cHolder);
        setTimeout($.aaaaaaaghCookies, 3000);
    };
})(jQuery);