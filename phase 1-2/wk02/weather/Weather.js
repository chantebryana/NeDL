var __awaiter = (this && this.__awaiter) || function (thisArg, _arguments, P, generator) {
    function adopt(value) { return value instanceof P ? value : new P(function (resolve) { resolve(value); }); }
    return new (P || (P = Promise))(function (resolve, reject) {
        function fulfilled(value) { try { step(generator.next(value)); } catch (e) { reject(e); } }
        function rejected(value) { try { step(generator["throw"](value)); } catch (e) { reject(e); } }
        function step(result) { result.done ? resolve(result.value) : adopt(result.value).then(fulfilled, rejected); }
        step((generator = generator.apply(thisArg, _arguments || [])).next());
    });
};
var __generator = (this && this.__generator) || function (thisArg, body) {
    var _ = { label: 0, sent: function() { if (t[0] & 1) throw t[1]; return t[1]; }, trys: [], ops: [] }, f, y, t, g;
    return g = { next: verb(0), "throw": verb(1), "return": verb(2) }, typeof Symbol === "function" && (g[Symbol.iterator] = function() { return this; }), g;
    function verb(n) { return function (v) { return step([n, v]); }; }
    function step(op) {
        if (f) throw new TypeError("Generator is already executing.");
        while (_) try {
            if (f = 1, y && (t = op[0] & 2 ? y["return"] : op[0] ? y["throw"] || ((t = y["return"]) && t.call(y), 0) : y.next) && !(t = t.call(y, op[1])).done) return t;
            if (y = 0, t) op = [op[0] & 2, t.value];
            switch (op[0]) {
                case 0: case 1: t = op; break;
                case 4: _.label++; return { value: op[1], done: false };
                case 5: _.label++; y = op[1]; op = [0]; continue;
                case 7: op = _.ops.pop(); _.trys.pop(); continue;
                default:
                    if (!(t = _.trys, t = t.length > 0 && t[t.length - 1]) && (op[0] === 6 || op[0] === 2)) { _ = 0; continue; }
                    if (op[0] === 3 && (!t || (op[1] > t[0] && op[1] < t[3]))) { _.label = op[1]; break; }
                    if (op[0] === 6 && _.label < t[1]) { _.label = t[1]; t = op; break; }
                    if (t && _.label < t[2]) { _.label = t[2]; _.ops.push(op); break; }
                    if (t[2]) _.ops.pop();
                    _.trys.pop(); continue;
            }
            op = body.call(thisArg, _);
        } catch (e) { op = [6, e]; y = 0; } finally { f = t = 0; }
        if (op[0] & 5) throw op[1]; return { value: op[0] ? op[1] : void 0, done: true };
    }
};
//get US region from user, make API call, then print corresponding forecast to web page table
function getWeatherData() {
    return __awaiter(this, void 0, void 0, function () {
        var apiString, tableRef, wxRegion, gpsCoordinates, response, jsonData, jsonPeriodsArr, i, tr, rows;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiString = "https://api.weather.gov/gridpoints/";
                    tableRef = document.getElementById("myList1");
                    wxRegion = document.forms["myForm"][0].value;
                    gpsCoordinates = {
                        "OAX": "41,96",
                        "BOU": "40,105",
                        "EAX": "38,94"
                    };
                    //set API string w user-selected region info
                    apiString = "https://api.weather.gov/gridpoints/" + wxRegion + "/" + gpsCoordinates[wxRegion] + "/forecast";
                    return [4 /*yield*/, fetch(apiString)];
                case 1:
                    response = _a.sent();
                    return [4 /*yield*/, response.json()];
                case 2:
                    jsonData = _a.sent();
                    jsonPeriodsArr = jsonData.properties.periods;
                    //clear old table data
                    tableRef.innerHTML = "<tr><th>Day of Week</th><th>Weather Report</th><th>Temp (F)</th><th>Wind Speed</th></tr>";
                    //Loop through jsonPeriodsArr to print weather data on page table
                    for (i = 0; i < jsonData.properties.periods.length; i++) {
                        tr = document.createElement("tr");
                        rows = "";
                        //define what should be printed
                        rows += "<tr><td>" + jsonPeriodsArr[i].name + "</td><td>" + jsonPeriodsArr[i].shortForecast + "</td><td>" + jsonPeriodsArr[i].temperature + " F</td><td>" + jsonPeriodsArr[i].windSpeed + "</td></tr>";
                        //print new table data
                        tr.innerHTML = rows;
                        tableRef.appendChild(tr);
                    }
                    return [2 /*return*/];
            }
        });
    });
}
