const peso1 = 1.0
const peso2 = Number('2.0')
const avaliacao1 = 9.871
const avaliacao2 = 6.871
const total = avaliacao1 * peso1 + avaliacao2 * peso2
const media = total / (peso1 + peso2)
let x = 43

//Number.isInteger(Object) retorna true if (typeof object) == Integer
console.log(Number.isInteger(peso1)) //Output: true
console.log(Number.isInteger(peso2)) //Output: true

//object.toFixed(x) -> retorna object com o número x de casas decimais. (typeof object: Number)
console.log(media.toFixed(2)) //Output: 7.87

// x.toString(y) Retorna o equivalente a x na base y. (typeof x, y: Number) (x precisa ser uma variável ou constante)
console.log(x.toString(2)) //Output: 101011
