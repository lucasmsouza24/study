function workOrNo(value, errorChance) {
    return new Promise(function (resolve, reject) {
        const rand = Number(Math.random().toFixed(1))
        // console.log(rand, rand > errorChance )
        if(rand < errorChance) {
            reject('Erro!')
        } else {
            resolve(value)
        }
    })
}

let qtd = 0

for(let i = 0; i <= 100; i++) {
    workOrNo('Funcionou!', 0.5)
        .then(function(value) {
            qtd++
            console.log(value, i)
        })
        .catch(function(err){
            console.log(err, i)
        })
}

setTimeout(function() {
    console.log(`Acertos: ${qtd}\nErros: ${100-qtd}`)
}, 500)