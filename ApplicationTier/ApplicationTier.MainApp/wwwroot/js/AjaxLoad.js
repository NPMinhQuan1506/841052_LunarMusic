function AjaxLoad(url, data, async, error, success, sender, before, complete) {
    return $.ajax({
        url: url,
        type: "POST",
        data: data,
        contentType: 'application/x-www-form-urlencoded',
        async: async,
        error: function (XMLHttpRequest, textStatus, errorThrown) {
            if (error != undefined && error != null && error.length != 0) error();
        },
        success: function (result) {
            if (result != undefined)
                if (success != undefined && success != null && success.length != 0) success(result);
        },
        beforeSend: function (xhr) {
            xhr.setRequestHeader("XSRF-TOKEN",
                $('input:hidden[name="__RequestVerificationToken"]').val());
            if (before != undefined && before != null && before.length != 0) before();
            if (sender != undefined && sender != null && sender.length != 0)
                sender.css('pointer-events', 'none');
        },
        complete: function (e) {
            if (complete != undefined && complete != null && complete.length != 0) complete(e);
            if (sender != undefined && sender != null && sender.length != 0)
                sender.css('pointer-events', 'auto');
        }
    });
}