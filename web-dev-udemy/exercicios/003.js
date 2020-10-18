const pow = function(base, expoente){
	if (!isNaN(base) && !isNaN(expoente)) {
		let k = 1;
		for (var i = 1; i <= expoente; i++) {
			k *= base;
		}
		return k;
	} else {
		return NaN;
	}
}

console.log(pow(9, "s"))
console.log(Math.pow(9, "o"));