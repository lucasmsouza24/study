const escola = 'Cod3r'
const fruits = 'Banana, Apple, Orange'

// Properties

    //string.length -> retorna o comprimento de uma string
    console.log(escola.length) //Output: 5

// Methods

    //string.indexOf('a') -> retorna o índice da primeira ocorrência de um texto especificado em uma string 
    //(se o valor passado não existir, return -1)
    console.log(escola.indexOf('C'))

    //string.lastIndexOf('a') -> retorna o índice da última ocorrência de um texto especificado em uma string
    //(se o valor passado não existir, return -1)
    console.log(fruits.lastIndexOf('e'))

    //string.slice(start, end) -> extrai uma parte de uma string e retorna a parte extraída em uma nova string.
    //O método utiliza 2 parâmetros: a posição inicial e a posição final (final não incluído).
    console.log(fruits.slice(8, 13))

    //string.charAt(x) -> retorna o caractere de indice x na string. (Number.isInteger(x) == true)
    //se x não for um valor fora do indice da string, uma string vazia é retornada.
    console.log(escola.charAt(0)) //Output: 'C'
    console.log(escola.charAt(10)) //Output: ''

    //string.charCodeAt(x) -> retorna valor na tabela ASCI do indice x da string. (Number.isInteger(x) == true)
    console.log(escola.charCodeAt(0)) //Output: 67

    //string.substring(start, end) -> Extrai parte da string a partir de start até end e retorna a string extraída.
    //(Number.isInteger(start, end) == true)
    console.log(escola.substring(1, 4))

    //string1.concat(string2) -> concatena strings
    console.log('Escola '.concat(escola).concat('!')) //Output: 'Escola Cod3r!'

    //string.replace(value, value2) -> Substitui value por value2 na string.
    //o argumento value aceita indice, variavel ou strings.
    console.log(escola.replace('3', 'e'))

    //string.split(separador) -> Retorna array definido de acordo com o separador.
    console.log(fruits.split(', '))

    //string.toUpperCase() -> retorna a string com letras maiúsculas.
    console.log(escola.toUpperCase())

    //string.toLowerCase() -> retorna a string com letra minúsculas.
    console.log(escola.toLowerCase())

    //string.trim() -> remove espaços em branco dos dois lados de uma string.gv