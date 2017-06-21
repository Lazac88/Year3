var isMeat = true;

$(document).ready(function()
{
	//$('#btnVegetarian').click(toggleVegetarian);
	//$('#btnRestore').click(toggleVegetarian);
	$("#btnVegetarian").click(function(event)
	{
		console.log("Button Clicked");
		if(isMeat)
		{
			toggleVegetarian();
		}
		else
		{
			toggleMeat();
		}
	});
	
});	/* end document.ready */

$("#btnVegetarian").click(function(event)
{
	console.log("Button Clicked");
	if(isMeat)
	{
		toggleVegetarian();
	}
	else
	{
		toggleMeat();
	}
});


function toggleVegetarian()
{
	detachFish();
	replaceHamburgers();
	replaceMeat();
	isMeat = false;
}

function toggleMeat()
{
	restoreFish();
	restoreHamburgers();
	restoreMeat();
	isMeat = true;
}

function detachFish()
{
	$(".fish").remove();
}

function replaceHamburgers()
{
	
}

function replaceMeat()
{
	
}

function restoreFish()
{
	
}

function restoreHamburgers()
{
	
}

function restoreMeat()
{
	
}
