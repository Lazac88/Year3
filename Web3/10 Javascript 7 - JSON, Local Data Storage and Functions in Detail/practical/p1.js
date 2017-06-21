function httpGet(theUrl) //ignore the inner workings of this function
{
    var xmlHttp = new XMLHttpRequest();
    xmlHttp.open( "GET", theUrl, false ); // false for synchronous request
    xmlHttp.send( null );
    return xmlHttp.responseText;
}

var url = 'https://dl.dropboxusercontent.com/u/10089854/Web3/data.json'
var response = httpGet(url);

