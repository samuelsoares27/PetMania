var urlPath = window.location.pathname;
$(function () {
    ko.applyBindings(ListaCliente);
    ListaCliente.GetCliente();
});

var ListaCliente = {
    Cliente: ko.observableArray([]),
    GetCliente: function () {
        var self = this;
        $.ajax({
            type: "GET",
            url: '/Cliente/GetCliente',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                self.Cliente(data);
            },
            error: function (err) {
                alert(err.status + " : " + err.statusText);
            }
        });
    },
};

self.editCliente = function (cliente) {
    window.location.href = '/Cliente/Edit/' + cliente.ID;
};