// função sem retorno
function imprimirSoma(a, b){
    console.log(a + b)
}

imprimirSoma(2, 3); // imprime 5, como esperado
imprimirSoma(2);    // javascript é bizzaro, a var b é undefined. função "retorna" um NaN
imprimirSoma(2, 3, 5, 1, 3, 6, 2, 4, 12) // os argumentos adicionais são desconsiderados (vida que segue)

// função com retorno e declarando valor padrão
function soma(a, b = 1) {
    return a + b;
}

console.log(soma(10));