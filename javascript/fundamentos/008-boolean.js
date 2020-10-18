let x

console.log('Verdadeiros ...')

console.log(!!5)
console.log(!!-5)
console.log(!!' ')
console.log(!!'texto')
console.log(!![])
console.log(!!{})
console.log(!!Infinity)
console.log(!!(x = true))


console.log('Falsos ...')

console.log(!!0)
console.log(!!'')
console.log(!!null)
console.log(!!NaN)
console.log(!!undefined)
console.log(!!(x = false))

let name = 'Lucas'
console.log(name || 'Desconhecido')
