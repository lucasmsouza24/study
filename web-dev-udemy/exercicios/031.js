const negatives = (vet) => {
    let n = 0
    for (let i in vet) {
        if (vet[i] < 0) {
            n++
        }
    }
    console.log(`${n} números negativos`)
}


let vet1 = Array(-8, 3, 2, 5, 3)
let vet2 = Array(20, -429, -12, -41, -429, -12, -41)
let vet3 = Array(25, -2, 15, -320, 52, 162, 0)

negatives(vet1)
negatives(vet2)
negatives(vet3)