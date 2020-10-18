const multVet = (vet, factor) => {
    let vet1 = Array()
    for (let i in vet) {
        vet1.push(vet[i] * factor)
    }
    return vet1
}

const multVetIf = (vet, factor) => {
    let vet1 = Array()
    for (let i in vet) {
        if (vet[i] > 5) {
            vet1.push(vet[i] * factor)
        } else {
            vet1.push(vet[i])
        }
    }
    return vet1
}

console.log(multVetIf([1, 2, 3, 4, 5, 6], 2))