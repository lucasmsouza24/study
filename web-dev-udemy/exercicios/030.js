const maxAndMin = (vet) => {
    let max, min
    for (let i in vet) {
        if (typeof vet[i] != 'number' && isNaN(vet[i])) {
            return null
        }
        if(i != 0) {
            if (vet[i] > max) {
                max = vet[i]
            } else if (vet[i < min]) {
                min = vet[i]
            }
        } else {
            max = vet[i]
            min = vet[i]
        }
    }
    return Array(max, min)
}


let vet1 = Array(-8, 3, 2, 5, 3)
let vet2 = Array(20, -429, 12, 41)
let vet3 = Array(25, 2, 15, 320, 52, 162, 0)

console.log(maxAndMin(vet1))
console.log(maxAndMin(vet2))
console.log(maxAndMin(vet3))