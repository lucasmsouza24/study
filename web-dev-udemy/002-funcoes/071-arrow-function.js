// arrow function

let dobro = function(a){
    return 2 * a;
}

dobro2 = (a) => 2 * a;

function soma() {
    let soma = 0;
    for (let i of arguments) {
        soma += i;
    }
    return soma;
}

soma2 = (argumentos) => {
    let somareturn = 0;
    for (let i of argumentos) {
        somareturn += i;
    }
    return somareturn;
}
console.log(soma2([1, 4, 5]));
