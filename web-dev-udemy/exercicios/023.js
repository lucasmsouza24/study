const sitAluno = (cod, not1, not2, not3) => {
    if (trataNota(not1) && trataNota(not2) && trataNota(not3)) {
        let nota_ponderada = calcNotaPonderada(maiorNota(not1, not2, not3))
        let situacao
        if (nota_ponderada >= 5) {
            situacao = "Aprovado"
        } else {
            situacao = "Reprovado"
        }
        console.log("========================")
        console.log(`cod: ${cod}`)
        console.log(`nota 1: ${not1.toFixed(1)}`)
        console.log(`nota 2: ${not2.toFixed(1)}`)
        console.log(`nota 3: ${not3.toFixed(1)}`)
        console.log(`média: ${nota_ponderada.toFixed(1)}`)
        console.log(`situacao: ${situacao}`)
        console.log("========================")
        if (situacao === "Aprovado") {
            return true
        }
    }
    else {
        console.log("valores inválidos")
    }
}

const calcNotaPonderada = (notas) => ((notas[0] * 4) + (notas[1] * 3) + (notas[2] * 3)) / 10

const maiorNota = (a, b, c) => {
    if (a >= b && a >= c) {
        return [a, b, c]
    } else if (b >= a && b >= c) {
        return [b, a, c]
    } else if (c >= a && c >= b) {
        return [c, a, b]
    }
}

const trataNota = (nota) => {
    if (typeof nota == "number" && nota <= 10 && nota >= 0){
            return true
        } else {
            return false
        }
}

function getRandom(min, max) {
    return Math.random() * (max - min) + min
}


// gerando dados aleatórios
let aprovados = 0
let aluno
for (let i = 0; i <= 100; i++) {
    aluno = sitAluno(i, getRandom(0, 10), getRandom(0, 10), getRandom(0, 10))
    if (aluno) {
        aprovados++
    }
}

console.log("Aprovados: ", aprovados)
console.log("Reprovados: ", 100 - aprovados)