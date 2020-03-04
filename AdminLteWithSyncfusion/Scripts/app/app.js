var app = app || {};

app.get = function (url, scb, errcb) {

    $.ajax({
        type: "GET",
        url: url
    }).done(function (result) {
        if (scb) { scb(result); }
    }).fail(function (jqXHR, status) {
        if (errcb) { errcb(status); }
    });
};

app.submit = function (url, data, scb, errcb) {
    $.ajax({
        url: url,
        type: "POST",
        data: JSON.stringify(data),
        dataType: "json",
        contentType: "application/json"
    }).done(function (status) {
        if (status.success) {
            if (scb) { scb(status); }
        } else {
            if (errcb) { errcb(status); }
        }
    }).fail(function (jqXHR, status) {
        if (errcb) { errcb(status); }
    });
};


app.modal = app.modal || {};

app.modal.show = function (url, returnurl) {
    var container = $(cfg.modal.container);
    var content = $(cfg.modal.content);
    var urlcontainer = $(cfg.modal.url);
    var returnurlcontainer = $(cfg.modal.returnurl);

    urlcontainer.text(url);
    if (returnurl) { returnurlcontainer.text(returnurl); }

    container.modal({
        backdrop: 'static',
        keyboard: false
    });
    app.get(url, (html) => { content.html(html); });
};

app.modal.close = function () {
    var container = $(cfg.modal.container);
    var content = $(cfg.modal.content);

    content.empty();
    container.modal('hide');
};


