(function () {

    "use strict";

    codeNameBravo.controller("homeController", ["$window", "storeService", homeController]);

    function homeController($window, storeService) {

        var vm = this;
        var _answer = "Yes";

        vm.Answer = _answer;
        vm.GetStores = _getStores;

        _init();

        function _init() {
            storeService.LoadStores();
        }

        function _getStores() {
            return storeService.GetStores();
        }

    }

})();