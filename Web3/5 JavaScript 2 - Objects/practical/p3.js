function randomNumber(input)
{
	var random = Math.random();
	var newNumber = random * input;
	return Math.floor(newNumber);
}

function return2DArray(r, c)
{
	var newArray = [];
	for(var i = 0; i < r; i++)
	{
		newArray[i] = [];
		for(var j = 0; j < c; j++)
		{
			newArray[i][j] = randomNumber(10);			
		}
		
	}
	return newArray;
}

alert(return2DArray(5,10));
//var myArray = return2DArray(2,2);
