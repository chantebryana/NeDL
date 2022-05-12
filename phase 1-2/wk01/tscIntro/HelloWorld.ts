function greetings() {
	var newName : string = "";
	//newName = (<HTMLInputElement>document.getElementById("fName")).value;
	newName = (document.getElementById("fName") as HTMLInputElement).value;
	document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}