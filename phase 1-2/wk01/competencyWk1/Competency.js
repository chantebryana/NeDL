//validate form entry and add to list
function addToList() {
    var theNewWord = "";
    theNewWord = document.forms["myForm"]["newWord"].value;
    //validation
    //check if word is empty string
    if (theNewWord == "") {
        alert("Oops! Your string's empty. Try again.");
    }
    //passes validation
    //add the word to the correct column
    else {
        //print word on ToDo column
        //let tableRef : any = {};
        var tableRef = document.getElementById("myList1");
        (tableRef.insertRow(tableRef.rows.length)).innerHTML = theNewWord;
        //erase the form field
        document.forms["myForm"]["newWord"].value = "";
    }
}
//validate form entry and delete from list
function deleteFromList() {
    //get new word from form
    var wordToDelete = document.forms["myForm"]["newWord"].value;
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
        var matchFound = false;
        var tableRef = document.getElementById("myList1");
        console.log(tableRef);
        //loop thru todo list
        for (var i = 0; i < tableRef.rows.length; i++) {
            //if match is found
            if ((tableRef.rows[i].innerHTML).toLowerCase() == (wordToDelete).toLowerCase()) {
                //flag to true
                matchFound = true;
                //remove matching element from list
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
function clearWholeList() {
    var tableRef = document.getElementById("myList1");
    tableRef.innerHTML = "";
    return true;
}
