const money = function(value) {
	if (!isNaN(value)){
		let moneyvalue = "R$ " + value.toFixed(2);
		return moneyvalue.replace(".", ",")
	}
	else {
		return NaN;
	}
}

console.log(money(2.5e+3));
console.log(money(0.1 + 0.2));