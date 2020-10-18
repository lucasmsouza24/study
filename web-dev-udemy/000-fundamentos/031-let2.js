let numero = 1;
{
    // de forma intuitiva, o comando let cria uma variável apenas no escopo local
    let numero = 2;
    console.log(numero);
}
console.log(numero);

// podem existir mútiplas variáveis com nomes iguais, desde que estejam em escopos diferentes