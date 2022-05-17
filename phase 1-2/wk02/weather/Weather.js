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





//get US region from user, make API call, then print corresponding forecast to web page table
async function addToList() {
	//01) declare variables
	//API URL
	var apiString = "https://api.weather.gov/";

	//get table reference
	let tableRef = document.getElementById("myList1");
	
	//get US region from user
	var wxRegion = "";
	wxRegion = document.forms["myForm"][0].value;

	//02) make API call (depending on quote length) and print forecast to web page table
	//if Omaha/Valley
	if (wxRegion == "Omaha/Valley") {
		//initialize GPS coordinates for OMA area
		let gpsX = "41";
		let gpsY = "96";
		
		//select OMA region
		console.log(wxRegion);
		//apiString = apiString + "gridpoints/" + wxRegion + "/" + gpsX + "," + gpsY + "/forecast";
		apiString = "https://api.weather.gov/gridpoints/OAX/41,96/forecast";
		console.log(apiString);
		
		//make API call and parse json
		let response = await fetch(apiString);
		let jsonData = await response.json();

		//CE debug tools
		console.log(tableRef.innerHTML);
		//console.log(tableRef.rows[0]);
		console.log(jsonData);

		/* //clear any old quotes and print new one
		tableRef.innerHTML = "";
		//tableRef.rows[0].remove();
		(tableRef.insertRow(tableRef.rows.length).innerHTML) = jsonData.content + " --" + jsonData.author; */
	}
	//else if Denver - Boulder
	else if (wxRegion == "Denver - Boulder") {
		//select medium quote
		console.log(wxRegion);
	}
	//else if Kansas City/Pleasant Hil
	else {
		//select long quote
		console.log(wxRegion);
		
		//print word on ToDo column
		//let tableRef : any = {};
		/* var tableRef = document.getElementById("myList1");
		(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
		//erase the form field
		document.forms["myForm"]["newWord"].value = ""; */
	}
}

