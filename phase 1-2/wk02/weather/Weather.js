//get US region from user, make API call, then print corresponding forecast to web page table
async function addToList() {
	//01) declare variables
	//API URL
	let apiString = "https://api.weather.gov/";

	//get table reference
	let tableRef = document.getElementById("myList1");
	
	//get US region from user
	let wxRegion = "";
	wxRegion = document.forms["myForm"][0].value;

	//02) make API call (depending on quote length) and print forecast to web page table
	//if Omaha/Valle
	if (wxRegion == "Omaha/Valley") {
		//select short quote
		console.log(wxRegion);
		apiString = apiString + "/random";
		
		//make API call and parse json
		let response = await fetch(apiString);
		let jsonData = await response.json();

		//CE debug tools
		console.log(tableRef.innerHTML);
		//console.log(tableRef.rows[0]);
		console.log(jsonData);

		//clear any old quotes and print new one
		tableRef.innerHTML = "";
		//tableRef.rows[0].remove();
		(tableRef.insertRow(tableRef.rows.length).innerHTML) = jsonData.content + " --" + jsonData.author;
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

