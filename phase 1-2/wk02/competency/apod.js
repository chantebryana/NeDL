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
//get quote length from user, make API call, then print corresponding quote to web page
function displayImg() {
    return __awaiter(this, void 0, void 0, function () {
        var apiString, tableRef1, tableRef2, date, response, jsonData, urlRow, titleRow, hdUrlRow, longDescriptionRow;
        return __generator(this, function (_a) {
            switch (_a.label) {
                case 0:
                    apiString = "https://api.nasa.gov/planetary/apod?api_key=d2VP3j0H9CX6rTtCLLpEHRKjHfjXf4SEsh3JaCPo";
                    tableRef1 = document.getElementById("myList1");
                    tableRef2 = document.getElementById("myList2");
                    date = "";
                    date = document.forms["myForm"][0].value;
                    //02) make API call (depending on date selected)
                    apiString = apiString + "&date=" + date;
                    console.log(apiString);
                    return [4 /*yield*/, fetch(apiString)];
                case 1:
                    response = _a.sent();
                    return [4 /*yield*/, response.json()];
                case 2:
                    jsonData = _a.sent();
                    //03) print image + info to web page
                    //clear any old info and print new one
                    tableRef1.innerHTML = "";
                    tableRef2.innerHTML = "";
                    urlRow = "<tr><td><img src=" + jsonData.url + "></tr></td>";
                    titleRow = "<tr><td>Title: " + jsonData.title + "</td></tr>";
                    hdUrlRow = "<tr><td><a href=\"" + jsonData.hdurl + "\">HD Image Link</a></td></tr>";
                    longDescriptionRow = "<tr><td><br /><em>" + jsonData.explanation + "</em></td></tr>";
                    //display new image + extra info on individual table rows
                    tableRef1.innerHTML = urlRow;
                    tableRef2.innerHTML = titleRow + hdUrlRow + longDescriptionRow;
                    return [2 /*return*/];
            }
        });
    });
}
