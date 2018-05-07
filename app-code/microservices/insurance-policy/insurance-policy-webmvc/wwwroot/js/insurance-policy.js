// File:     INSURANCE-POLICY.JS
// Created:  May.06/2018
// Modified: May.06/2018

function loadInfo() {
    var options = {};
    options.url = urlInsurancePolicy + '/all';
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
        var name = $("#name").val();
        var description = $("#description").val();
        var coverageType = $("#coverageTypes option:selected").val();
        var startDate = $("#startDate").val();
        var coveragePeriod = $("#coveragePeriod").val();
        var price = $("#price").val();
        var riskType = $('#riskTypes option:selected').val();

        if (name === "") {
            alert("You must select a name.");
            $("#name").focus();
            return;
        }

        if (description === "") {
            alert("You must select a Description.");
            $("#description").focus();
            return;
        }

        if (startDate === "") {
            alert("You must select start date (yyyy-mm-dd)");
            $('#startDate').focus();
            return;
        }

        if (coveragePeriod === "") {
            alert("You must select a Coverage Period (numeri)");
            $('#coveragePeriod').focus();
            return;
        }
        else {
            if (!isANumber(coveragePeriod)) {
                alert("Coverage Period must be numeric");
                $('#coveragePeriod').focus();
                return;
            }
        }

        if (price === "") {
            alert("You must select a price. (Numeric)");
            $('#price').focus();
            return;
        }
        else {
            if (!isANumber(price)) {
                alert("Price must be numeric");
                $('#price').focus();
                return;
            }
        }

        var options = {};
        options.url = urlInsurancePolicy;
        options.type = "POST";

        var obj = {};
        obj.name = name;
        obj.description = description;
        obj.coverageType = coverageType;
        obj.startDate = startDate;
        obj.coveragePeriod = coveragePeriod;
        obj.price = price;
        obj.riskType = riskType;
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
    });

    $("#update").click(function () {
        var id = $('#id').val();
        var name = $("#name").val();
        var description = $("#description").val();
        var coverageType = $("#coverageTypes option:selected").val();
        var startDate = $("#startDate").val();
        var coveragePeriod = $("#coveragePeriod").val();
        var price = $("#price").val();
        var riskType = $('#riskTypes option:selected').val();

        if (id === "") {
            alert("You must have a valid id.");
            $('#id').focus();
            return;
        }
        else {
            if (!isANumber(id)) {
                alert("Id must be numeric");
                $('#id').focus();
                return;
            }
        }
        if (name === "") {
            alert("You must select a name.");
            $("#name").focus();
            return;
        }

        if (description === "") {
            alert("You must select a Description.");
            $("#description").focus();
            return;
        }

        if (startDate === "") {
            alert("You must select start date (yyyy-mm-dd)");
            $('#startDate').focus();
            return;
        }

        if (coveragePeriod === "") {
            alert("You must select a Coverage Period (numeri)");
            $('#coveragePeriod').focus();
            return;
        }
        else {
            if (!isANumber(coveragePeriod)) {
                alert("Coverage Period must be numeric");
                $('#coveragePeriod').focus();
                return;
            }
        }

        if (price === "") {
            alert("You must select a price. (Numeric)");
            $('#price').focus();
            return;
        }
        else {
            if (!isANumber(price)) {
                alert("Price must be numeric");
                $('#price').focus();
                return;
            }
        }

        var options = {};
        options.url = urlInsurancePolicy + '/' + id;
        options.type = "PUT";

        var obj = {};
        obj.id = id;
        obj.name = name;
        obj.description = description;
        obj.coverageType = coverageType;
        obj.startDate = startDate;
        obj.coveragePeriod = coveragePeriod;
        obj.price = price;
        obj.riskType = riskType;
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
    });

    $("#delete").click(function () {
        var id = $('#id').val();

        if (isANumber(id)) {
            var options = {};
            options.url = urlInsurancePolicy + "/" + id;
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