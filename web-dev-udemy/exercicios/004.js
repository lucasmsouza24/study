const razao = function(dividendo, divisor){
	if (!isNaN(dividendo) && !isNaN(divisor)){
		console.log(`Razão: ${Math.floor(dividendo / divisor}`)
		console.log(`Resto: ${dividendo % divisor}`)
	} else {
		return NaN;
	}
}

razao(5, 2)