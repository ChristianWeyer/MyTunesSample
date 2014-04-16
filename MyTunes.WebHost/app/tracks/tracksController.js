app.controller("tracksController", function ($scope, $http, $location) {

    $http.get("../tracks").then(function(result) {
        $scope.tracks = result.data;
    }, function(error) {
        alert(error);
    });

    $scope.selectTrack = function (track) {
        $location.path("/trackdetails/" + track.Id);
    };
});