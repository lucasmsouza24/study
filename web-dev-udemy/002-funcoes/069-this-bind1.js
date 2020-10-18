const pessoa = {
    saudacao: "Bom dia",
    falar() {
        console.log(this.saudacao)
    }
}

pessoa.falar();
const myvar = pessoa.falar
myvar();    // conflito entre paradigmas: funcional e OO

// O método bind() cria uma nova função que, quando chamada,
// tem sua palavra-chave this definida com o valor fornecido,
// com uma sequência determinada de argumentos precedendo quaisquer
// outros que sejam fornecidos quando a nova função é chamada.

const falarPessoa = pessoa.falar.bind(pessoa);
falarPessoa();