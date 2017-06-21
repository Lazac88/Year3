var myGlobalObject;


function ajaxRequest() 
		{
			var returnJSON;
  			var xhttp = new XMLHttpRequest();
  			xhttp.open("GET", "https://dl.dropboxusercontent.com/u/10089854/Web3/ajaxPractical2/athletes.json", true);
  			xhttp.onreadystatechange = function() {
    			if ((xhttp.readyState == 4) && (xhttp.status == 200)) 
    			{
     				var responseText = xhttp.responseText;
            console.log("Response JSON: " + responseText);
     				returnObject = JSON.parse(responseText);
            //console.log("Parsed JSON: " + returnJSON.Michael);

            myGlobalObject = returnObject;

            myFunction(myGlobalObject);



            var firstName = document.getElementById("userInputText").value;

            if (firstName in returnObject)
            {
                console.log("Did you mean " + firstName + " " + returnObject[firstName]);
                var output = document.getElementById("output");
                output.innerHTML = "Did you mean " + firstName + " " + returnObject[firstName] + "?";

            }
            else
            {
              console.log("no");
              var output = document.getElementById("output");
              output.innerHTML = "Sorry! I do not know that athlete";
            }            
    			}
  			};  			
  			xhttp.send();  			
		}



    console.log("GLOBAL OBJECT:" + myGlobalObject);

    //External Function to Grab data.
    function myFunction(x)
    {
      console.log("Return" + x);
    }