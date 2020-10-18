const criarProduto = function(nome, preco) {
    return {
        nome: nome,
        preco: preco,
        desconto: 0.1
    }
}

const prod1 = criarProduto('Livro', 20);

console.log(prod1.nome);
console.log(prod1.preco);
console.log(prod1.desconto);