// File:     USER-INSURANCE-POLICY.JS
// Created:  May.07/2018
// Modified: May.07/2018

function loadInfo() {
    var options = {};
    options.url = urlInsurancePolicy + '/all';
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        var info = "";
        $("#insurance-policy-list").empty();
        info = "<table style='width:100%'>";
        info += "<tr><td>&nbsp;</td><td><b>ID</b></td><td><b>Name</b></td><td><b>Description</b></td>";
        info += "<td><b>Coverage Type</b></td><td><b>Start Date</b></td><td><b>Coverage Period</b></td>";
        info += "<td><b>Price</b></td><td><b>Risk Type</b></td>";
        info += "</tr>";

        data.forEach(function (element) {
            info += "<tr>";
            info += "<td><input type='radio' name='rdId' value='" + element.id + "'></td>";
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

    $("#edit").click(function () {
        var rdSel = $('input[name=rdId]:checked').val();
        if (rdSel == undefined) {
            alert('You must select a record line to edit.');
            return;
        }
        var options = {};
        options.url = urlInsurancePolicy + '/' + rdSel;
        options.type = "GET";
        options.dataType = "json";
        options.success = function (data) {
            $('#id').val(data.id);
            $("#name").val(data.name);
            $("#description").val(data.description);
            $("#coverageTypes").val(data.coverageType);
            $("#startDate").val(data.startDate);
            $("#coveragePeriod").val(data.coveragePeriod);
            $("#price").val(data.price);
            $('#riskTypes').val(data.riskType); 
        };

        options.error = function () {
            $("#msg").html("Error while calling the Web API!");
        };
        $.ajax(options);
    });

    $("#clear").click(function () {
        $('#id').val('');
        $("#name").val('');
        $("#description").val('');
        $("#coverageTypes").val('1');
        $("#startDate").val('');
        $("#coveragePeriod").val('');
        $("#price").val('');
        $('#riskTypes').val('1');
    });

    loadCoverageTypes();
    loadRiskTypes();
    loadInfo();
});