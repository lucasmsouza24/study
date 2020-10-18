const chang = (vet1, vet2) => {
    let temp = Array()
    for (let i = 0; i < vet1.length; i++) {
        vet1[i] = vet1[i] + vet2[i]
        vet2[i] = vet1[i] - vet2[i]
        vet1[i] = vet1[i] - vet2[i]
    }
    console.log(`vet1: ${vet1}\nvet2: ${vet2}`)
}

let vet1 = [1, 2, 3]
let vet2 = [10, 20, 30]

chang(vet1, vet2)