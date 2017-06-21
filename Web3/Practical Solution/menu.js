var stateVegetarian = false;

$(document).ready(function()
{

	$('#btnVegetarian').click(toggleVegetarian);
	$('#btnRestore').click(toggleVegetarian);
	
});	/* end document.ready */

function toggleVegetarian()
{
	if (stateVegetarian == false)
	{
		stateVegetarian = true;
		detachFish();
		replaceHamburgers();
		replaceMeat();
	}
	else
	{
		stateVegetarian = false;
		restoreFish();
		restoreHamburgers();
		restoreMeat();
	}
}

function detachFish()
{
	/* Detach() doesn't dispose of the selected elements, as remove() does. Thus we can store them and put them back in later */
	
	/*$('.fish').detach();					/* This removes all the ingredient <li> of class fish, but we want to remove the whole containing <li>.... */ 
	/* $('.fish').parent().detach(); 		/* This removes the ul containing the <li> of class fish, but we want to remove the  li containing that ul......*/
	
	/* The $ in the variable name is a jQuery convention, signifying that the variable contains a jQuery return */
	$allFishEntrees = $('.fish').parent().parent().detach();  /* Yay! */
	
	// Just FYI...
	//alert($allFishEntrees[0]);  						/*[object HTMLLIElement] */	
	//alert($allFishEntrees[0].firstChild);				/*[object Text] */
	//alert($allFishEntrees[0].firstChild.textContent);	/*Poached Salmon */
	
}

function replaceHamburgers()
{	
	/* Because there is a one-to-one replacement of hamburger with mushrooms, we can do this. We will be able to restore by just reversing the operation */
	$('.hamburger').replaceWith('<li class="replacedHamburger">portobello mushrooms</li>');
}

function replaceMeat()
{
	/* Because this involves replacing multiple classes, we will need to identify and detach. We will have to create new nodes for the DOM to replace the
		ones we are temporarily removing */
		
		
	/* Insert the new ones... */
	$('.meat').before("<li class='tofu'>tofu</li>");
	$('.tofu').parent().parent().addClass('leaf');
	
	/* Detach and store...How will we know where to put them back? Loop through the tofu elements and replace parallel*/
	$allMeatIngredients = $('.meat').detach();
}

function restoreFish()
{
	/* The stored fish entree nodes conveniently belong at the front <ul class="menu_entrees">. That is, before the first <li> in that <ul> */
	$('.menu_entrees li').first().before($allFishEntrees);
}

function restoreHamburgers()
{	
	$('.replacedHamburger').replaceWith('<li class="hamburger">hamburger</li>');
}

function restoreMeat()
{
	$('.tofu').parent().parent().removeClass('leaf');
	$('.tofu').each(function(i)
					{
						$(this).after($allMeatIngredients[i]);
					});
	$('.tofu').remove();
}




