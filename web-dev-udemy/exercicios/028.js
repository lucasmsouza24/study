const evenAndOdd = (vet) => {
    let evens = []
    let odds = []
    for (let i in vet) {
        if (vet[i] % 2) {
            evens.push(vet[i])
        } else {
            odds.push(vet[i])
        }
    }
    console.log(`evens: ${evens.length}`)
    console.log(`odds: ${odds.length}`)
}

evenAndOdd([1, 2, 3, 4, 5, 6, 7])