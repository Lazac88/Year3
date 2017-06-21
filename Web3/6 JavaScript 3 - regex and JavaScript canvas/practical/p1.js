function wordCheck(stringInput)
{
	//var myRegExp = /color|colour/;
	var myRegExp = /colou?r/gi;

	myString = (stringInput.match(myRegExp));
	console.log(myString);
}

function doubleCheck(stringInput)
{
	var myRegExp = /\b\d\.\d{1,2}\b/;

	myString = (stringInput.search(myRegExp));
	console.log(myString);
}

function numberSplit(stringInput)
{
	var myRegExp = /[^\d]+/gi;

	var myNumbersArray = stringInput.split(myRegExp);
	console.log(myNumbersArray);
}

function directMatch(stringInput)
{
	var myRegExp = /\bRandom\b/gi;
	myString = (stringInput.match(myRegExp));
	console.log(myString);
}

function findPostcode(stringInput)
{
	var myRegExp = /.*?(\d{4}).+?(\d{4}).*/;
	var x = stringInput.replace(myRegExp, "$2 $1");
	console.log(x);
}

var canvas =  document.getElementById("myCanvas");
var context = canvas.getContext("2d");
context.fillStyle = "red";
context.fillRect(10, 10, 100, 50);
