// reduce() mantem valores acumulados a cada iteração
// array.reduce(callback(acumulador, valor_atual, index, array){return acc, crr})

const notas = [1, 9, 10, -1, 6, 4]
const soma = notas.reduce((accumulator, currentValue) => accumulator + currentValue)
console.log(soma)

// o reduce facilita o calculo de fatoriais
const numeros = [1, 2, 3, 4, 5]
const factorial = numeros.reduce(function (acc, crr) {return acc * crr})
console.log(factorial)

// menor valor em notas
const menor = notas.reduce((acc, crr) => {
    if (crr < acc) acc = crr
    return acc
})


console.log(menor)