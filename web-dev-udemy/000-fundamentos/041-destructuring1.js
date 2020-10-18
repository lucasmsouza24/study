// novo recurso do ES2015
// destructuring

const pessoa = {
    nome: 'Ana',
    idade: 5,
    endereco: {
        logradouro: 'Rua ABC',
        numero: 1000
    }
}
// o destructuring é usado para "extrarir" valores de dentro de uma estrutura, criando variáveis com seus valores
// possui a seguinte notação:

// objeto
const {nome, idade} = pessoa;
console.log(nome, idade)

const {nome: n, idade: i} = pessoa;
console.log(n, i);

const {endereco: {logradouro, numero, cep}}
console.log(logradouro, numero, cep)

// caso o atributo não exista dentro do objeto, retornará undefined
// também é possível definir um valor padrão para caso o atributo não exista dentro do objeto
const {sobrenome, bemHumorada = true} = pessoa;
console.log(sobrenome, bemHumorada);