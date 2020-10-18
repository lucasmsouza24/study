//declaração literal
const valores = [7.7, 8.9, 6.3, 9.2];
valores[1] = 'lUCAS'; //ISSO AQUI É BIZZARO;
console.log(valores);
console.log(valores[0], valores[1], valores[2], valores[3]);
console.log(valores[99]); // bizarramente isso não dá erro (retorna undefined)

console.log(valores.length); // retorna a quantidade de index que o array possui

console.log(valores.push('loquinhas', 19, true)); // adiciona novos itens ao final do array e retorna o novo comprimento.
console.log(valores.unshift('primeiro valor'));   // adiciona novos itens ao começo do array
console.log(valores);

console.log(valores.pop()); // apaga o último valor do array e o retorna;
delete valores[1]; // apaga o valor

console.log(typeof valores); //um array é um object!