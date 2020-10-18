let pessoa = {
    name: "Lucas",
    sobrenome: "Mesquita de Souza",
    idade: 19,
    nome_completo: this.name + " " + this.sobrenome,
    atribuirNota(a) {
        if (a >= 7) {
            this.aprovado = true
        }
        else {
            this.aprovado = false
        }
    }
}

pessoa.atribuirNota(8)
console.log(pessoa.aprovado)
