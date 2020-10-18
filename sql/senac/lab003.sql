use dbLab;

-- 1 Escreva uma consulta que que exiba os dados da tabela PRODUTOS na forma crescente pelo campo NOME.

select * from tbprodutos order by nome;

-- 2 Escreva uma consulta que exiba o NOME dos produtos ordenado de forma decrescente e o VALOR de forma crescente

select * from tbprodutos order by nome desc, valor asc;

-- 3 Escreva uma consulta que exiba os três produtos mais caros.

select * from tbprodutos order by valor desc limit 3;

-- 4 Escreva uma consulta que exiba o VALOR do produto mais barato;

select valor from tbprodutos order by valor limit 1;