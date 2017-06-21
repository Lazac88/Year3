function returnArray(input)
{
	var newArray = [];
	for(var i = 0; i < input; i++)
	{
		newArray.push(Math.floor(Math.random() * 10));
	}
	return newArray;
}

alert(returnArray(10));