// notação literal
const obj1 = {
    atributo1: 'valor1',
    method1: function(){
        //
    }
}

// Object em JS
const obj2 = new Object()

// funcoes construtoras
function Produto(nome, preco, desc) {
    this.nome = nome
    this.getPrecoComDesconto = () => {
        return preco * (1 - desc)
    }
}

const obj3 = new Produto('Caneta', 2, 0.1)
const obj4 = new Produto('Notebook', 3599.99, 0.3)

// console.log(obj4.getPrecoComDesconto())

// factory function (PADRÃO)         <------------- USE ISSO
function criarFuncionario(nome, salarioBase, faltas) {
    return {
        nome,
        salarioBase,
        faltas,
        getSalario() {
            return salarioBase - ((salarioBase / 30) * faltas)
        }
    }
}

const obj5 = criarFuncionario('João', 7980, 4)
const obj6 = criarFuncionario('Maria', 11400, 1)
// console.log(obj5.getSalario(), obj6.getSalario())

// Object.create
const filha = Object.create(null) 
filha.nome = 'Mei'
console.log(filha)

// funcao famosa q retorna objeto... (JSON)
const fromJSON = JSON.parse('{"info": "Sou um JSON"}')
console.log(fromJSON.info)