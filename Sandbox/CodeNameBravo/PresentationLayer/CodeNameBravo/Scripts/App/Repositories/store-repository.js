(function () {


    "use strict";
    angular.module("codeNameBravo").factory("storeRepository", ["$http", "$q", "appSettings", storeRepository]);

    function storeRepository($http, $q, appSettings) {

        var url = "api/Store/";

        function _get() {

            var deferred = $q.defer();

            $http.get(url)
                .success(function (result) {
                    deferred.resolve(result);
                })
            .error(function (error) {
                deferred.reject(error);
            });

            return deferred.promise;
        }

        return {
            Get: _get
        };


    }


})();