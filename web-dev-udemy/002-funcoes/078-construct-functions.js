function Carro(maxSpeed = 200, delta = 5) {
	// atributo privado
	let actualSpeed = 0;

	// metodo público
	this.acelerar = function () {
		if (actualSpeed + delta <= maxSpeed) {
			actualSpeed += delta;
		} else {
			actualSpeed = maxSpeed;
		}
	}

	// metodo publico
	this.getActualSpeed = function () {
		return actualSpeed;
	}
}

let corola = new Carro(100, 3);
for (let i = 0; i < 3; i++) {
	corola.acelerar();
}
console.log(corola.getActualSpeed());