app.controller("humanCtrl", function ($scope, humanAJService) {
    $scope.divHuman = false;
    GetAllHumans();
    //To Get all human records  
    function GetAllHumans() {
        debugger;
        var getHumanData = humanAJService.getHumans();
        getHumanData.then(function (human) {
            $scope.humans = human.data;
        }, function () {
            alert('Error in getting human records');
        });
    }

    $scope.editHuman = function (human) {
        var getHumanData = humanAJService.getHuman(human.Id);


        getHumanData.then(function (_human) {
            $scope.human = _human.data;
            $scope.humanId = human.Id;
            $scope.humanName = human.Name;
            $scope.humanAddress = human.Address;
            $scope.humanAge = human.Age;
            $scope.humanHair = human.Hair;
            $scope.humanInterests = human.Interests;
            $scope.humanFileName = human.FileName;
            $scope.Action = "Update";
            $scope.divHuman = true;
            
        }, function () {
            alert('Error in getting human records');
        });
    }

    $scope.AddUpdateHuman = function () {
        var Human = {
            Name: $scope.humanName,
            Address: $scope.humanAddress,
            Age: $scope.humanAge,
            Hair: $scope.humanHair,
            Interests: $scope.humanInterests,
            FileName: $scope.humanFileName
        };
        var getHumanAction = $scope.Action;

        if (getHumanAction == "Update") {
            Human.Id = $scope.humanId;
            var getHumanData = humanAJService.updateHuman(Human);
            getHumanData.then(function (msg) {
                GetAllHumans();
                alert(msg.data);
                $scope.divHuman = false;
            }, function () {
                alert('Error in updating human record');
            });
        } else {
            var getHumanData = humanAJService.AddHuman(Human);
            getHumanData.then(function (msg) {
                GetAllHumans();
                alert(msg.data);
                $scope.divHuman = false;
            }, function () {
                alert('Error in adding human record');
            });
        }
    }

    $scope.AddHumanDiv = function () {
        ClearFields();
        $scope.Action = "Add";
        $scope.divHuman = true;
    }

    $scope.deleteHuman = function (human) {
        var getHumanData = humanAJService.DeleteHuman(human.Id);
        getHumanData.then(function (msg) {
            alert(msg.data);
            GetAllHumans();
        }, function () {
            alert('Error in deleting human record');
        });
    }

    function ClearFields() {
        $scope.human = "";
        $scope.humanId = "";
        $scope.humanName = "";
        $scope.humanAddress = "";
        $scope.humanAge = "";
        $scope.humanHair = "";
        $scope.humanInterests = "";
        $scope.humanFileName = "";
    }
    $scope.Cancel = function () {
        $scope.divHuman = false;
    };
});