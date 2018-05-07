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
    options.url = urlUserInsurancePolicy + '/all/' + userId;
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        var info = "";
        $("#policy-list").empty();
        info = "<table style='width:100%'>";
        info += "<tr><td>&nbsp;</td><td><b>ID</b></td><td><b>Name</b></td><td><b>Description</b></td>";
        info += "<td><b>Coverage Type</b></td><td><b>Start Date</b></td><td><b>Coverage Period</b></td>";
        info += "<td><b>Price</b></td><td><b>Risk Type</b></td>";
        info += "</tr>";

        data.forEach(function (element) {
            info += "<tr>";
            info += "<td><input type='checkbox' name='chkId' value='" + element.id; + "' ";
            if (element.selected === 1) {
               info += " checked "
            }
            info += "'></td>";
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
        var selected = [];
        $('#checkboxes input:checked').each(function() {
            selected.push($(this).val());
        });
        console.log(selected);
    });

    loadInfo();
});