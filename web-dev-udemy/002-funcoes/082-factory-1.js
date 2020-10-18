// factory simples = função que retorna um objeto
function criarPessoa(nome, idade) {
    return {
        nome: nome,
        idade: idade
    }
}

const pessoa1 = criarPessoa('Ana', 20);

console.log(pessoa1);
console.log(pessoa1.nome);
console.log(pessoa1.idade);