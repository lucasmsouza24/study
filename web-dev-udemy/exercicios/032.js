const geraVetor = (min, max, length) => {
    let vet = Array()
    for (let i = 0; vet.length < length; i++) {
        vet.push(getRandomInt(min, max))
    }
    return vet
}

const getRandomInt = (min, max) => {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

const somaVet = (vet) => {
    let sum = 0
    for (let i in vet) {
        sum += vet[i]
    }
    return sum
}

const media = (vet) => somaVet(vet) / vet.length

// just i enjoying with random datas

let medias = Array()

let perfect = 0
let great = 0
let ok = 0
let podre = 0

for (let i = 0; i <= 10000000; i++) {
    let vet = geraVetor(1, 10, 5)
    let sit
    medias.push(media(vet))
    if (medias[i] == 10) {
        sit = "PERFECT"
        perfect++
    } else if (medias[i] >= 8){ 
        sit = "great"
        great++
    } else if (medias[i] < 8 && medias[i] > 5) {
        sit = "ok"
        ok++
    } else {
        sit = "podre"
        podre++
    }
    console.log(i, vet, media(vet), sit)
}

console.log(`media total: ${media(medias)}`)
console.log(`PERFECT: ${perfect}`)
console.log(`great: ${great}`)
console.log(`ok: ${ok}`)
console.log(`podre: ${podre}`)