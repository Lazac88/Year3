var express = require('express');
var app = express();

var birds = require('./birds');

//GET requests
//app.get('/', function (req, res) 
//{
	//res.send('Hello World!');
//});

app.set('view engine', 'pug');

app.get('/', function (req, res) 
{
  console.log("Hits get / function");
  res.render('index.pug', { title: 'Hey', message: 'Hello there!' });
});


//Below is an example of pre-declaring functions to be used in a route
var cb0 = function (req, res, next) 
{
  console.log('CB0');
  next();
}

var cb1 = function (req, res, next) 
{
  console.log('CB1');
  next();
}

//app.get tries function cb0, gets passed to cb1, gets passed to the function below
//Finally the function below then passes it to the function below that.
app.get('/example/d', [cb0, cb1], function (req, res, next) 
{
  console.log('the response will be sent by the next function ...');
  next();
}, 
function (req, res) 
{
  res.send('Hello from D!');
});

//Can ceate chainable route handlers for a route using the below layout
app.route('/book')
  .get(function (req, res) {
    res.send('Get a random book');
  })
  .post(function (req, res) {
    res.send('Add a book');
  })
  .put(function (req, res) {
    res.send('Update the book');
  });

//POST requests
app.post('/', function (req, res) 
{
	res.send('Got a POST request');
});

//PUT requests
app.put('/user', function (req, res) 
{
  res.send('Got a PUT request at /user');
});

//DELETE Requests
app.delete('/user', function (req, res) 
{
  res.send('Got a DELETE request at /user');
});

//Give express the directory to look in to serve static assess
//You can do more than 1 app.use
app.use(express.static('public'));

app.use('/birds', birds);



//To create a virtual path prefix (something that goes in front of /images/kitten.jpg)
//app.use can take another parameter ... app.use('/static', express.static('public'));
//Now you could use the path http://localhost:3000/static/images/kitten.jpg


//Can collect all requests (GET, POST, PUT, etc) from a specified path and have them executed elsewhere
app.all('/secret', function(req, res, next)
{
	console.log("Accessing the secret section ....");
	next(); //Pass control to the next handler
})


app.listen(3000, function () 
{
  console.log('Example app listening on port 3000!');
});