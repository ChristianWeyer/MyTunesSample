app.controller("trackDetailsController", function($routeParams, $scope, $http) {
    var id = $routeParams.id;

    $http.get(app.baseUrl + "tracks?id=" + id).then(function(result) {
        $scope.track = result.data;
    }, function(error) {
        alert(error);
    });
});