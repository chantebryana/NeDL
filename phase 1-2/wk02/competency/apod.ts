//get quote length from user, make API call, then print corresponding quote to web page
async function displayImg() {
	//01) declare variables
	//API URL; includes unique api key (allows something like 1000 hits per day)
	let apiString = "https://api.nasa.gov/planetary/apod?api_key=d2VP3j0H9CX6rTtCLLpEHRKjHfjXf4SEsh3JaCPo";

	//get table reference; make sure to set to HTMLTableElement for later on
	let tableRef1 = <HTMLTableElement>document.getElementById("myList1");
	let tableRef2 = <HTMLTableElement>document.getElementById("myList2");
	
	//get date from user; formatted as text YYYY-MM-DD; this matches API format
	var date = "";
	date = document.forms["myForm"][0].value;

	//02) make API call (depending on date selected)
	apiString = apiString + "&date=" + date;
	console.log(apiString);

	//make API call and parse json
	let response = await fetch(apiString);
	let jsonData = await response.json();

	//03) print image + info to web page
	//clear any old info and print new one
	tableRef1.innerHTML = "";
	tableRef2.innerHTML = "";

	//define variables for each table row (for easier reading)
	let urlRow = "<tr><td><img src=" + jsonData.url + "></tr></td>";
	let titleRow = "<tr><td>Title: " + jsonData.title + "</td></tr>";
	let hdUrlRow = "<tr><td><a href=\"" + jsonData.hdurl + "\">HD Image Link</a></td></tr>";
	let longDescriptionRow = "<tr><td><br /><em>" + jsonData.explanation + "</em></td></tr>";

	//display new image + extra info on individual table rows
	tableRef1.innerHTML = urlRow;
	tableRef2.innerHTML = titleRow + hdUrlRow + longDescriptionRow;
}

