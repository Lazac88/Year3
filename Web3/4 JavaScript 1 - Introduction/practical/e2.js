function drawChess()
{
	for(var i = 0; i < 8; i++)
	{
		for(var j = 0; j < 8; j++)
		{
			var y = i % 2;
			console.log("y = " + y);
			if(y == 0)
			{
				var z = j % 2;

				if(z == 0)
				{
					document.write('&nbsp;&nbsp;&nbsp;');
				}
				else
				{
					document.write('&block;');
				}
			}
			else
			{
				var x = j % 2;
				console.log("x = " + x);
				if(x == 0)
				{
					document.write('&block;');
				}
				else
				{
					document.write('&nbsp;&nbsp;&nbsp;');
				}
			}			
		}
		document.write('<br>');
	}
};