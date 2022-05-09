function greetings() {
	var newName = document.getElementById("fName").value;
	document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}