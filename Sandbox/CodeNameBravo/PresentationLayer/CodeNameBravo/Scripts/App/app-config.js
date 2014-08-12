(function () {
    "use strict";
    var _baseUrl = "/CodeNameBravo/";

    codeNameBravo.value("appSettings", {
        BaseUrl: _baseUrl,
        Title: "Code Name Bravo"
    });

    codeNameBravo.config(["$routeProvider", appConfig]);


    function appConfig($routeProvider) {

        $routeProvider.when("/", {
            templateUrl: _baseUrl + "Scripts/App/Views/Home.html",
            controller: "homeController as vm"
        });

    }

})();