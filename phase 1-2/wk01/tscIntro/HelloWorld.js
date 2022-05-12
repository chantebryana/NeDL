function greetings() {
    var newName = "";
    //newName = (<HTMLInputElement>document.getElementById("fName")).value;
    newName = document.getElementById("fName").value;
    document.getElementById("greeting").innerHTML = "Hello " + newName + "!";
}
