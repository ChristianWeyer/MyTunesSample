app.controller("trackDetailsController", function($routeParams, $scope, $http, $location) {
    var id = $routeParams.id;

    $http.get(app.baseUrl + "tracks?id=" + id).then(function(result) {
        $scope.track = result.data;
    }, function(error) {
        alert(error);
    });

    $scope.navigateBack = function() {
        $location.path("/tracks");
    };
});