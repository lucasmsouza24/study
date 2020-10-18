//Declarando array de forma simples
let fruits = ['bananna', 'apple', 'orange']
fruits    //Return: ['bananna', 'apple', 'orange']
fruits[0] //Return: 'bananna'
fruits[1] //Return: 'apple'
fruits[2] //Return: 'orange'
fruits[3] = 'blueberry' 

//Declarando array igual corno
let songs = new Array('Bronken Boy', 'Morph', 'Circles')

//array.length retorna a quantidade de índices de um array
console.log(fruits.length, songs.length)

//array.push(a, b, c, ..., n) Cria um novo indice a atribui o valor (a, b, c, ..., n) ao mesmo.
songs.push('Fear of the Dark', 'Face to Face', 'Stressed Out')

//array.pop() Exclui o último índice do array e retorna o valor do mesmo.
console.log(songs.pop())
console.log(songs)

//delete array[index] Exclui o valor de indice index.