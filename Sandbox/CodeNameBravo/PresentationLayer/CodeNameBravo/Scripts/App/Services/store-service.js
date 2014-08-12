(function () {
    "use strict";
    angular.module("codeNameBravo").factory("storeService", ["$q", "storeRepository", storeService]);

   function storeService($q, storeRepository) {

        var _stores = [];

        function _getStores() {
            return _stores;
        }

        function _loadStores() {
            var deffered = $q.defer();

            storeRepository.Get()
            .then(function (data) {
                //Success
                _stores = data;
                deffered.resolve();
            }).catch(function (error) {
                //Fail
                console.log(error);
                deffered.reject(error);
            });

            return deffered.promise;

        }

        return {
            GetStores: _getStores,
            LoadStores: _loadStores
        };

    }


})();