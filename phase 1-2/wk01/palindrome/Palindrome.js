function validateANDadd() {
	var theNewWord = document.forms["myForm"]["newWord"].value;
	var theNewNum = document.forms["myForm"]["newNumber"].value;

	//validation
	//check if word is empty string
	if (theNewWord == "") {
		alert("Oops! Your string's empty. Try again.");
		return false;
	} 
	//check if number isn't 1 or 2
	else if (theNewNum < 1 || theNewNum > 2) {
		alert("Oops! Enter a 1 or a 2.");
		document.forms["myForm"]["newNumber"].value = "";
		return false;
	}
	//passes validation
	//add the word to the correct column
	else {
		if (theNewNum == 1) {
			var tableRef = document.getElementById("myList1");
			(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
		} else {
			var tableRef = document.getElementById("myList2");
			(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
		}
		//erase the form fields
		document.forms["myForm"]["newWord"].value = "";
		document.forms["myForm"]["newNumber"].value = "";
		return true;
	}
}

//clears our contents of list
function clearList1() {
	var tableRef = document.getElementById("myList1");
	tableRef.innerHTML = "";
	return true;
}

//clears our contents of list
function clearList2() {
	var tableRef = document.getElementById("myList2");
	tableRef.innerHTML = "";
	return true;
}