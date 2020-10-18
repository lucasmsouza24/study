const name = 'Lucas'
const concatenacao = 'Olá ' + name + '!'
const concatenacao2 = 'Olá '.concat(name).concat('!')

//Vaiáveis/constantes podem ser inseridas entre ${}
const template = `Olá ${name}!`

console.log(concatenacao)
console.log(concatenacao2)
console.log(template)
