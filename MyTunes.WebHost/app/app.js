var app = angular.module("myTunes", ["ngRoute", "angular-loading-bar"]);

app.config(function ($routeProvider) {
    $routeProvider
        .when("/tracks", {
            templateUrl: "tracks/tracksList.html",
            controller: "tracksController"
        })
        .when("/trackdetails/:id", {
            templateUrl: "tracks/trackDetails.html",
            controller: "trackDetailsController"
        })
        .when("/about", {
            templateUrl: "about/about.html"
        })
        .otherwise({ redirectTo: "/tracks" });
});