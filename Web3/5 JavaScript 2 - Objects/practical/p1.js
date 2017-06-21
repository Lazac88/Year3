function randomNumber(input)
{
	var random = Math.random();
	var newNumber = random * input;
	return Math.floor(newNumber);
}

function output(number)
{

}

alert(randomNumber(10));