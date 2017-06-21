
var flags = require("node-flag");

if(flags.isset('fname') && flags.isset('lname'))
{
	var fname = flags.get('fname');
	var lname = flags.get('lname');

	var sfn = "Welcome " + fname + " " +  lname;

	process.stdout.write(sfn);
	process.exit();
}

else
{
	process.stdout.write('You Blew It');
	process.exit();
}


