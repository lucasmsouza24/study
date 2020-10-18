// map(callback) retorna um novo array, com as alterações desejadas
// a callback precisa ter um retorno para criar o novo array

// array.map(function callback(element, index, array){ return new_item }) 

const numeros = [1, 2, 3, 4, 5]

const numeros2 = numeros.map(function (e){
    return e * 2
})

console.log(numeros2)

// brincando com maps consecutivos
const triplo = value => value * 3
const plusplus = value => value + 1
const toMoney = value => value.toFixed(2).toString().replace('.', ',')

const resultado = numeros.map(triplo).map(plusplus).map(toMoney)
console.log(resultado)