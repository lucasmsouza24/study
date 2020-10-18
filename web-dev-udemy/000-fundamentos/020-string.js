const escola = 'Cod3r';

//retorna caractere contido no index 4 da variavel escola;
console.log(escola.charAt(4));

//retorna o código da tabela ASCI referente ao valor (index) passado;
console.log(escola.charCodeAt(0));

//retorna o index na qual o valor passado se encontra (-1 para valor não encontrado);
console.log(escola.indexOf('C'));

//extrai os caracteres de uma string, entre dois índices especificados, e retorna a nova subcadeia
//(não considera o último indice);
console.log(escola.substring(1, 4));
console.log(escola.substring(2));

//é usado para juntar duas ou mais strings.
console.log("Escola ".concat(escola).concat("!"));

//retorna uma nova string onde os valores especificados são substituídos.
console.log(escola.replace('3', 'e'));


//split () retorna uma matriz da string a partir de um separador;
console.log("apple,bananna,pineapple".split(','));