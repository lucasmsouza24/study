const imprimirResultado = function(nota) {
    if (!isNaN(nota) && nota !== ""){
        if(nota >= 7) {
            console.log('Aprovado!')
        }
        else {
            console.log('Reprovado!')
        }
    }
    else {
        console.log("Valor inválido: " + nota);
    }
}

imprimirResultado("l")