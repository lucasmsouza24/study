const notas = [1, 8, 5, 6, 5.9];

// without callback
let baixas1 = [];
for (let i in notas) {
	if (notas[i] < 6) {
		baixas1.push(notas[i]);
	}
}

console.log(baixas1);

// with callback
let baixas2 = notas.filter(function (a) {
	return a < 6
});

console.log(baixas2);

//with callback and arrow function
let baixas3 = notas.filter(n => n < 6);
console.log(baixas3);