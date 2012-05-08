(function ($) {

    $.blabbR = function (options) {

        /* connect to client */
        var $chat = $.connection.blabbR;

        $chat.addMessage = function (msg) {
            var $e = $('<li />').html(msg).appendTo($('#blabbR-messages'));
        };

        $chat.addUser = function (user, exists) {
            console.log('user entered: ', user.name);
            updateCookie();
        };

        var blabbRExpand = function () {
            $(this).effect('bounce', { times: 3 }, 300, function () {
                $(this).toggleClass('collapsed');
            });
        };

        var sendMessage = function () {
            var $command = $('#msg').val();
            $chat.send($command).fail(msgFailure);
        };

        var msgFailure = function (e) {
            alert(e);
        };

        /* testing */
        $('#btn-send').click(sendMessage);

        function updateCookie() {
            console.log('userid: ', $chat.id);
            $.cookie('userid', chat.id, { path: '/', expires: 30 });
        }

        function getQueryVariable(variable) {
            var query = window.location.search.substring(1);
            var vars = query.split("&");
            for (var i = 0; i < vars.length; i++) {
                var pair = vars[i].split("=");
                if (pair[0] == variable) {
                    return unescape(pair[1]);
                }
            }
        }

        var activeTransport = getQueryVariable('transport') || 'auto';

        $.connection.hub.start({ transport: activeTransport }, function () {
            $chat.join()
            .done(function (success) {
                if (success === false) {
                    console.log('failed to join');
                }
                else {
                    /* add chat window to page */
                    var $chatWindow = $('<div />');
                    $chatWindow.attr('id', 'blabbR');
                    $chatWindow.addClass('collapsed');
                    $chatWindow.click(blabbRExpand);
                    var $messages = $('<ul/>');
                    $messages.attr('id', 'blabbR-messages');
                    $chatWindow.append($messages);
                    $chatWindow.appendTo('body');
                }
            });
        });

    };


})(jQuery);