function areaRect(width, height)
{
	try
	{
		var area = width * height;
		console.log(area);
	}
	catch(err)
	{
		console.log("hit exception");
	}	
}

//console.log(areaRect(2, 10));


try
{
	zzzzz();
}
catch(err)
{
	document.write(err.message);
}


function recur(int)
{
	var endRecur = int;
	if(!isNaN(endRecur))
	{
		for (var i = int - 1; i > 0; i--)
		{
			endRecur *= i;
		}
		document.write(endRecur);
	}
	else
	{
		throw "Not a number";
	}
	
}

try
{
	recur(prompt("Please enter a number"));
}
catch(err)
{
	console.log(err);
}



