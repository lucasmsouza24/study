function falarDepoisDe(segundos, frase) {
    return new Promise((resolve, reject) => {
        setTimeout(() => {
            resolve(frase);
            // reject('Erro!');
        }, segundos * 1000)
    })
}

falarDepoisDe(3, "luquinha").then(frase => console.log(frase)).catch(frase => console.log(frase));