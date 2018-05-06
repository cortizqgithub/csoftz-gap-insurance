// File:     INSURANCE-POLICY.JS
// Created:  May.06/2018
// Modified: May.06/2018

function loadInfo() {
    var options = {};
    options.url = urlInsurancePolicy;
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        var info = "";
        $("#insurance-policy-list").empty();
        info = "<table style='width:100%'>";
        info += "<tr><td>ID</td><td>Name</td><td>Description</td>";
        info += "<td>Coverage Type</td><td>Start Date</td><td>Coverage Period</td>";
        info += "<td>Price</td><td>Risk Type</td>";
        info += "</tr>";
        
        data.forEach(function (element) {
            info += "<tr>";
            info += "<td>" + element.id + "</td>";
            info += "<td>" + element.name + "</td>";
            info += "<td>" + element.description + "</td>";
            info += "<td>" + element.coverageTypeName + "</td>";
            info += "<td>" + element.startDate + "</td>";
            info += "<td>" + element.coveragePeriod + "</td>";
            info += "<td>" + element.price + "</td>";
            info += "<td>" + element.riskTypeName + "</td>";
            info += "</tr>";
        });
        info += "</table>";
        $('#insurance-policy-list').append(info);
    };

    options.error = function () {
        $("#msg").html("Error while calling the Web API!");
    };
    $.ajax(options);
}

$(document).ready(function () {
    $("#insert").click(function () {
        var addressName = $("#name").val();
        var stateName = $("#states option:selected").text();
        var cityName = $("#cities option:selected").text();
       
        if (stateName === ""){
            alert("You must select one State.");
            $("#states").focus();
            return;
        }

        if (cityName === "") {
            alert("You must select one City.");
            $("#cities").focus();
            return;
        }

        if (addressName === "") {
            alert("You must type a name for the Address.");
            $("#name").focus();
        }
        else {
            var options = {};
            options.url = urlInsurancePolicy;
            options.type = "POST";

            var obj = {};
            obj.addressName = addressName;
            obj.idCountry = $("#countries option:selected").val();
            obj.countryName = $("#countries option:selected").text();
            obj.idState = $("#states option:selected").val();
            obj.stateName = $("#states option:selected").text();
            obj.idCity = $("#cities option:selected").val();
            obj.cityName = $("#cities option:selected").text();

            options.data = JSON.stringify(obj);
            console.log(options.data);
            options.contentType = "application/json";
            options.dataType = "json";

            options.success = function (msg) {
                $("#msg").html(msg);
                loadInfo();
            };
            options.error = function () {
                $("#msg").html("Error while calling the Web API!");
            };
            $.ajax(options);
        }
    });

    $("#update").click(function () {
        var idAddress = $("#id").val();
        var addressName = $("#name").val();
        var isValid = true;

        if (!isANumber(idAddress)) {
            alert("Required ID is not a number");
            $("#id").focus();
            isValid = false;
        }

        if (addressName === "") {
            alert("You must type a name for the Address.");
            $("#name").focus();
            isValid = false;
        }

        if (isValid) {
            var options = {};
            options.url = urlInsurancePolicy + "/" + idAddress;
            options.type = "PUT";

            var obj = {};
            obj.idAddress = idAddress;
            obj.addressName = addressName;
            obj.idCountry = $("#countries option:selected").val();
            obj.countryName = $("#countries option:selected").text();
            obj.idState = $("#states option:selected").val();
            obj.stateName = $("#states option:selected").text();
            obj.idCity = $("#cities option:selected").val();
            obj.cityName = $("#cities option:selected").text();

            options.data = JSON.stringify(obj);
            console.log(options.data);
            options.contentType = "application/json";
            options.dataType = "json";
            options.success = function (msg) {
                $("#msg").html(msg);
                loadInfo();
            };
            options.error = function (a, b, c) {
                $("#msg").html("Error while calling the Web API!");
            };
            $.ajax(options);
        }
    });

    $("#delete").click(function () {
        var idAddress = $("#id").val();

        if (isANumber(idAddress)) {
            var options = {};
            options.url = urlInsurancePolicy + "/" + idAddress;
            options.type = "DELETE";
            options.datatype = "json";
            options.success = function (msg) {
                $("#msg").html(msg);
                loadInfo();
            };
            options.error = function (a, b, c) {
                $("#msg").html("Error while calling the Web API!");
            };
            $.ajax(options);
        }
        else {
            alert("Required ID is not a number");
            $("#id").focus();
        }
    });
    loadCoverageTypes();
    loadRiskTypes();
    loadInfo();
});