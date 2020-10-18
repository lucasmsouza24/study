function soma() {
    let soma = 0;
    for (let i of arguments) {
        soma += i;
    }
    return soma;
}
console.log(soma())
console.log(soma(2, 3))
console.log(soma(10, 30))
console.log(soma(75, 25))

