function validateANDadd() {
	var theNewWord = document.forms["myForm"]["newWord"].value;

	//validation
	//check if word is empty string
	if (theNewWord == "") {
		alert("Oops! Your string's empty. Try again.");
		return false;
	} 
	//passes validation
	//add the word to the correct column
	else {
		//print word on ToDo column
		var tableRef = document.getElementById("myList1");
		(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
			
		//erase the form field
		document.forms["myForm"]["newWord"].value = "";
		return true;
	}
}

function validateANDdelete() {
	//get new word from form
	var wordToDelete = document.forms["myForm"]["newWord"].value;
	console.log("wordToDelete: " + wordToDelete);

	//validation
	//check if word is empty string
	if (wordToDelete == "") {
		alert("Oops! Your string's empty. Try again.");
		return false;
	}
	//passes validation
	//see if new word matches any in list
	else {
		//initialize variables
		let matchFound = false;
		var tableRef = document.getElementById("myList1");
		
		//loop thru todo list
		for (let i = 0; i < tableRef.rows.length; i++) {
			//if match is found
			if ((tableRef.rows[i].innerHTML).toLowerCase() == (wordToDelete).toLowerCase()) {
				//flag to true
				matchFound = true;
				
				//remove matching element from list
				console.log("Match! " + tableRef.rows[i].innerHTML);
				tableRef.rows[i].remove();
			}
		}

		//alert if no match found
		if (matchFound == false) {
			alert("Oops! No match found in list. Try again.");
		}
		
		//remove word from form field
		document.forms["myForm"]["newWord"].value = "";
	}
}

//clears our contents of list
function clearList1() {
	var tableRef = document.getElementById("myList1");
	tableRef.innerHTML = "";
	return true;
}
