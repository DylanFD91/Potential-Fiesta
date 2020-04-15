"use strict";


function helloWorld(){

	console.log("Hello world!");
	alert("Hello world!");
	let response = prompt("Hello what?");

	if (response === "world"){
		document.getElementById("demoDiv").innerHTML = "Hey there!";
	}
	else if (response === "there"){
		document.getElementById("demoDiv").style.display = "none";
	}
}

function addTen(){
	let response = parseInt(prompt("What number to add to ten?"));
	document.getElementById("demoDiv").innerHTML = 10 + response;
}

