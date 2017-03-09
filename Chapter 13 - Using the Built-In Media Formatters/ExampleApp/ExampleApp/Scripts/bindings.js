var viewModel = ko.observable({ first: 4, second: 7 });
var response = ko.observable("Ready");
var gotError = ko.observable(false);

var sendRequest = function() {
    $.ajax("/api/bindings/sumnumbers"  ,
    {
        type: "POST",
        data: viewModel(),
        success: function(data) {
            gotError(false);
            response("Total: " + data);
        },
        error: function(jqXHR) {
            gotError(true);
            response(jqXHR.status + "(" + jqXHR.statusText + ")");
        }
    });
};

$(document).ready(function() {
    ko.applyBindings();
});