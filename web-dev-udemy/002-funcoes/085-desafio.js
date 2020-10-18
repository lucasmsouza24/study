class Pessoa {
    constructor(nome) {
        this.nome = nome;
    }

    falar() {
        console.log(`Meu nome é ${this.nome}`)
    }
}

function Pessoa2(nome) {
    this.nome = nome
    this.falar = () => {
        console.log(`Meu nome é ${this.nome}!`);
    }
}

const p1 = new Pessoa2('Lucrecio')
p1.falar()