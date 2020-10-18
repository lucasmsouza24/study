// o "this" pode variar de acordo de como uma função é definida e chamada
// porém, quando uma arrow function é definida, seu this nunca varia

// arrow function syntax:
const soma = (a, b) => {
    return a + b;
}

console.log(soma(2, 3))