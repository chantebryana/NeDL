//get quote length from user, make API call, then print corresponding quote to web page
async function addToList() {
	//01) declare variables
	//API URL
	let apiString = "https://api.quotable.io";

	//get table reference; make sure to set to HTMLTableElement for later on
	let tableRef = <HTMLTableElement>document.getElementById("myList1");
	
	//get quote length from user
	var quoteLength = "";
	quoteLength = document.forms["myForm"][0].value;

	//02) make API call (depending on quote length) and print quote to web page
	//if short
	if (quoteLength == "Short") {
		//select short quote
		console.log(quoteLength);
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
	//else if medium
	else if (quoteLength == "Medium") {
		//select medium quote
		console.log(quoteLength);
	}
	//else if long
	else {
		//select long quote
		console.log(quoteLength);
		
		//print word on ToDo column
		//let tableRef : any = {};
		/* var tableRef = document.getElementById("myList1");
		(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
		//erase the form field
		document.forms["myForm"]["newWord"].value = ""; */
	}
}

