{
    // var cria uma variável que foge do escopo do bloco
    var nome = 'lucas';
}

function myfunc(){
    // apesar do comentário anterior, se uma var for declarada dentro de uma função
    // tal variável estará visível apenas no escopo da função
    var nome2 = 'alice';
}

myfunc();

console.log(nome);
console.log(nome2);