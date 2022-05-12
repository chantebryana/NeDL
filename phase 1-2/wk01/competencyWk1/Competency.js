function validateANDadd() {
	var theNewWord = document.forms["myForm"]["newWord"].value;

	//validation
	//check if word is empty string
	if (theNewWord == "") {
		alert("Oops! Your string's empty. Try again.");
		return false;
	} 
	//passes validation
	//check if string is palindrome and
	//add the word to the correct column
	else {
		//CE ADD METHOD

		//print word on first column and report whether it's a palindrome
		var tableRef = document.getElementById("myList1");
			(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
			
		//erase the form fields
		document.forms["myForm"]["newWord"].value = "";
		return true;
	}
}

//clears our contents of list
function clearList1() {
	var tableRef = document.getElementById("myList1");
	tableRef.innerHTML = "";
	return true;
}
