function buttonClicked(btn)
{
	var url = "https://dl.dropboxusercontent.com/u/10089854/Web3/ajaxPractical/images/"
	var buttonNumber = btn.id;
	console.log(buttonNumber);
	var number = buttonNumber.charAt(6);
	console.log(number);
	url += buttonNumber;
	url += ".svg";
	console.log(url);

  	var xhttp = new XMLHttpRequest();
  	xhttp.open("GET", url, true);
  	xhttp.onreadystatechange = function() {
    	if ((xhttp.readyState == 4) && (xhttp.status == 200)) 
    	{
    		var responseImage = xhttp.responseText;
    		var output = document.getElementById("icon" + number);
    		output.innerHTML = responseImage;
    	}
    };
    xhttp.send();  
}