const usuario = {
    nome: 'luqinha',
    idade: 19,
    endereco: {
        cidade: 'São Paulo',
        estado: 'SP'
    }
}

const {nome, endereco} = usuario;

console.log(endereco.estado);