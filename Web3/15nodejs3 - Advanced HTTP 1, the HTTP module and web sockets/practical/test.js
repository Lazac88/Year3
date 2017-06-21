var http = require("http");

//create a Web server
http.createServer(function (request, response) { //anonymous callback function
   // Send the HTTP response with a HTTP Status: 200 : OK
   // Content Type: text/html
   response.writeHead(200, {'Content-Type': 'text/html'});
   
   // Send the response body as "Hello World"
   response.end('<h1>Hello World\n</h1>');
}).listen(8000);

// Console will print the message
console.log('Server running at http://127.0.0.1:8000/');