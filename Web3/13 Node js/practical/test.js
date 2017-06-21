process.stdout.write("what is your favorite movie?");

process.stdin.on('data', function(data) {
    answer = data.toString().trim();
    process.stdout.write(`${answer} is a great movie!!`);
    process.exit();
});