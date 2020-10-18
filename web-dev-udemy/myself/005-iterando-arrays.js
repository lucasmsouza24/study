// iterando arrays
let myarray = ["loquinhas", "mesquitola", "lulinhas", "luquitas", "podre"]

// i variable receive index of myarray
/*for (let i in myarray){
    console.log(`[${i}]: ${myarray[i]}`);
}

// i variable receive value item of myarray
for (let item of myarray){
    console.log(item);
}

let i = 0
while (i < myarray.length) {
	console.log(`[${i}]: ${myarray[i]}`);
	i++;
}*/


const range = function(min, max, increment = 1) {
	const myarray = Array();
	for (let i = min; i <= max; i += increment){
		myarray.push(i);
	}
	return myarray
}


console.log("starting ping pong");
console.log("===========================");

for (let i in range(0, 100)) {
	if (i % 3 && i % 5){
		console.log(i, "PING PONG")
	} else {
		console.log(i)
	}
}

console.log("===========================");
console.log("ending ping pong");