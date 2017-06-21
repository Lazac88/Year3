function fact(num)
{
    if (num === 0)
      { return 1; }
    else
      { return num * fact( num - 1 ); }
}


function doHeavyComputation(upperBound){
	for (var i=1; i <= upperBound; i++){
		for (var j=1; j <= upperBound; j++){
			var r = Math.round(Math.random()*1000);
			fact(r);
		}
	}
	//console.log(r);
	return r
}


addEventListener("message", function(event) {
	re = doHeavyComputation(event.data);
	postMessage("I'm Done!");
});
