let vetorPilha = Array(1, 2, 3, 4, 5)
let vetorAdiciona = Array(6, 7, 8, 9, 10)

for (let i in vetorAdiciona) {
    vetorPilha.push(vetorAdiciona[i])
}

console.log(vetorPilha)