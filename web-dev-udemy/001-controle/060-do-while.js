function getRandomInt(min, max){
	const value = Math.random() * (max - min) + min;
	return Math.floor(value);
}

let opcao = 0

do {
	opcao = getRandomInt(-1, 10)
	console.log(opcao)
} while(opcao != -1)