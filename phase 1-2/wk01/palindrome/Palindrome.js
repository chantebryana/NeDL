//first palindrome checker
//from https://www.freecodecamp.org/news/two-ways-to-check-for-palindromes-in-javascript-64fea8191fd7/
function palindrome1(str) {
  // Step 1. Lowercase the string and use the RegExp to remove unwanted characters from it
  var re = /[\W_]/g; // or var re = /[^A-Za-z0-9]/g;
  var lowRegStr = str.toLowerCase().replace(re, '');
     
  // Step 2. Use the same chaining methods with built-in functions from the previous article 'Three Ways to Reverse a String in JavaScript'
  var reverseStr = lowRegStr.split('').reverse().join(''); 
   
  // Step 3. Check if reverseStr is strictly equals to lowRegStr and return a Boolean
  return reverseStr === lowRegStr;
}

//second palindrome checker
function palindrome2(str) {
	var re = /[^A-Za-z0-9]/g;
	str = str.toLowerCase().replace(re, '');
	var len = str.length;
	for (var i = 0; i < len/2; i++) {
		if (str[i] !== str[len - 1 - i]) {
				return false;
		}
	}
	return true;
 }

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
	//check if string is palindrome and
	//add the word to the correct column
	else {
		//use first palindrome algorithm
		if (theNewNum == 1) {
			//palindrome method
			var trueOrFalse = palindrome1(theNewWord);

			//print word on first column and report whether it's a palindrome
			var tableRef = document.getElementById("myList1");
				(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + trueOrFalse;
			
		} 
		//use second palindrome logic
		else {
			var trueOrFalse = palindrome2(theNewWord);
			
			var tableRef = document.getElementById("myList2");
			(tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord + ": " + trueOrFalse;
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