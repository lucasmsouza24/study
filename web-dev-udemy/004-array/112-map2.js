// exercício: criando array com valores de um JSON

const carrinho = [
    '{ "nome": "Borracha", "preco": 3.45 }',
    '{ "nome": "Caderno", "preco": 13.90 }',
    '{ "nome": "Kit de Lápis", "preco": 41.22 }',
    '{ "nome": "Caneta", "preco": 7.50 }',
]

const precos = carrinho.map(function (item){
    return JSON.parse(item)['preco']
})

console.log(precos)