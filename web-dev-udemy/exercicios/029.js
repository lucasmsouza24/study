const analyze = (vet) => {
    let _in = Array()
    let _out = Array()
    for (let i in vet) {
        if (vet[i] >= 10 &&  vet[i] <= 20) {
            _in.push(vet[i])
        } else {
            _out.push(vet[i])
        }
    }
    return Array(_in.length, _out.length)
}

let vet1 = [1, 2, 11, 14, 16, 23, 30]
let vet2 = [0, 32, 42, 25, 13, 2, 71]
let vet3 = [0,3, 5, 32, 23, 13, 21, 20, 19]
let vet4 = [23, 21, 75, 134, 12, 11, 9]
let vet5 = [16, 16, 16, 17]
console.log(`in: ${analyze(vet1)[0]}\nout: ${analyze(vet1)[1]}\n==============`)
console.log(`in: ${analyze(vet2)[0]}\nout: ${analyze(vet2)[1]}\n==============`)
console.log(`in: ${analyze(vet3)[0]}\nout: ${analyze(vet3)[1]}\n==============`)
console.log(`in: ${analyze(vet4)[0]}\nout: ${analyze(vet4)[1]}\n==============`)
console.log(`in: ${analyze(vet5)[0]}\nout: ${analyze(vet5)[1]}\n==============`)