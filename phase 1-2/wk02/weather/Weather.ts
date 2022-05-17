//get US region from user, make API call, then print corresponding forecast to web page table
async function getWeatherData() {
	//01 declare variables
	//API URL
	let apiString = "https://api.weather.gov/gridpoints/";

	//reference to html table
	let tableRef = document.getElementById("myList1");
	
	//get US region from user
	let wxRegion = document.forms["myForm"][0].value

	//object of gps coordinates, organized by region: to use in API string
	let gpsCoordinates = {
		"OAX": "41,96",
		"BOU": "40,105",
		"EAX": "38,94"
	};

	//set API string w user-selected region info
	apiString = "https://api.weather.gov/gridpoints/" + wxRegion + "/" + gpsCoordinates[wxRegion] + "/forecast";

	//make API call and parse json
	let response = await fetch(apiString);
	let jsonData = await response.json();
	let jsonPeriodsArr = jsonData.properties.periods;

	//clear old table data
	tableRef.innerHTML = "<tr><th>Day of Week</th><th>Weather Report</th><th>Temp (F)</th><th>Wind Speed</th></tr>";

	//Loop through jsonPeriodsArr to print weather data on page table
	for (let i = 0; i < jsonData.properties.periods.length; i++) {
		//thanks stack overflow
		//https://stackoverflow.com/questions/20562718/add-data-to-table-using-onclick-function-in-javascript
		
		//get table reference and define rows
		let tr = document.createElement("tr");
		let rows = "";

		//define what should be printed
		rows += "<tr><td>" + jsonPeriodsArr[i].name + "</td><td>" + jsonPeriodsArr[i].shortForecast + "</td><td>" + jsonPeriodsArr[i].temperature + " F</td><td>" + jsonPeriodsArr[i].windSpeed + "</td></tr>"

		//print new table data
		tr.innerHTML = rows;
		tableRef.appendChild(tr);
	}
}
