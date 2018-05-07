﻿// File:     GLOBAL.JS
// Created:  May.06/2018
// Modified: May.06/2018

var urlInsurancePolicy = "http://localhost:5000/insurance/api/v1/insurancepolicy";
var urlCoverageType = "http://localhost:5000/insurance/api/v1/coveragetype";
var urlRiskType = "http://localhost:5000/insurance/api/v1/risktype";

function isANumber(s) {
    var numbers = /^[0-9]+$/;
    var isNum = s.match(numbers);
    return isNum;
}

function loadCoverageTypes() {
    var options = {};
    options.url = urlCoverageType + '/all';
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        $("#coverageTypes").empty();
        data.forEach(function (element) {
            $("#coverageTypes").append("<option value=" + element.coverageTypeId + ">" + element.name + "</option>");
        });
    };
    options.error = function () {
        $("#msg").html("Error while calling the Web API!");
    };
    $.ajax(options);
}

function loadRiskTypes(idCountry) {
    var options = {};
    options.url = urlRiskType + '/all';
    options.type = "GET";
    options.dataType = "json";
    options.success = function (data) {
        $("#riskTypes").empty();
        data.forEach(function (element) {
            $("#riskTypes").append("<option value=" + element.riskTypeId + ">" + element.name + "</option>");
        });
    };
    options.error = function () {
        $("#msg").html("Error while calling the Web API!");
    };
    $.ajax(options);
}
