/*global angular*/
(function () {
    angular
        .module('simplAdmin.core')
        .factory('configurationService', configurationService);

    /* @ngInject */
    function configurationService($http) {
        var service = {
            getSettings: getSettings,
            updateSetting: updateSetting
        };
        return service;

        function getSettings() {
            return $http.get('api/AppSettingss');
        }

        function updateSetting(settings) {
            return $http.put('api/AppSettingss/', settings);
        }
    }
})();