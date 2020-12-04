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

async function run() {
    let wins = 0

    for(let i = 0; i <= 100; i++) {
        await workOrNo('work', 0.5)
            .then(function(value) {
                wins++
                console.log(value)
            })
            .catch(console.log)
    }

    console.log('wins: ', wins)
}

run()