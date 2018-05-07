// File:     USER-INSURANCE-POLICY.JS
// Created:  May.07/2018
// Modified: May.07/2018

function loadInfo() {
    var options = {};
    options.url = urlUser + '/all';
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        var info = "";
        $("#users").empty();
        info = "<table style='width:100%'>";
        info += "<tr><td>&nbsp;</td><td><b>ID</b></td><td><b>Name</b></td><td><b>Last Name</b></td>";
        info += "</tr>";

        data.forEach(function (element) {
            info += "<tr>";
            info += "<td><input type='radio' name='rdId' value='" + element.userId + "'></td>";
            info += "<td>" + element.userId + "</td>";
            info += "<td>" + element.name + "</td>";
            info += "<td>" + element.lastName + "</td>";
            info += "</tr>";
        });
        info += "</table>";
        $('#users').append(info);
    };

    options.error = function () {
        $("#msg").html("Error while calling the Web API!");
    };
    $.ajax(options);
}

function loadPolicies(userId) {
var options = {};
    options.url = urlUserInsurancePolicy + '/' + userId;
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        var info = "";
        $("#policy-list").empty();
        info = "<table style='width:100%'>";
        info += "<tr><td>&nbsp;</td><td><b>User ID</b></td><td><b>InsurancePolicyId</b></td>";
        info += "</tr>";
        data.forEach(function (element) {
            info += "<tr>";
            info += "<td><input type='check' name='chkId' value='" + element.InsurancePolicyId + "'></td>";
            info += "<td>" + element.userId + "</td>";
            info += "<td>" + element.InsurancePolicyId + "</td>";
            info += "</tr>";
        });
        info += "</table>";
        $('#policy-list').append(info);
    };

    options.error = function () {
        $("#msg").html("Error while calling the Web API!");
    };
    $.ajax(options);
}

$(document).ready(function () {
    $("#loadPolicies").click(function () {
        var rdSel = $('input[name=rdId]:checked').val();
        if (rdSel == undefined) {
            alert('You must select a record user line to edit.');
            return;
        }
        loadPolicies(rdSel);

    });

    $("#link").click(function () {
        
    });

    loadInfo();
});