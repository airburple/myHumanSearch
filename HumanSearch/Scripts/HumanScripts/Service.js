app.service("humanAJService", function ($http) {

    //get All Humans
    this.getHumans = function () {
        return $http.get("Home/GetAllHumans");
    };

    // get Human by humanId
    this.getHuman = function (humanId) {
        var response = $http({
            method: "post",
            url: "Home/GetHumanById",
            params: {
                id: JSON.stringify(humanId)
            }
        });
        return response;
    }

    // Update Human 
    this.updateHuman = function (human) {
        var response = $http({
            method: "post",
            url: "Home/UpdateHuman",
            data: JSON.stringify(human),
            dataType: "json"
        });
        return response;
    }

    // Add Human
    this.AddHuman = function (human) {
        var response = $http({
            method: "post",
            url: "Home/AddHuman",
            data: JSON.stringify(human),
            dataType: "json"
        });
        return response;
    }

    //Delete Human
    this.DeleteHuman = function (humanId) {
        var response = $http({
            method: "post",
            url: "Home/DeleteHuman",
            params: {
                HumanId: JSON.stringify(humanId)
            }
        });
        return response;
    }
});