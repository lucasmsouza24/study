let arredondaNota = (realScore) => {
    if(realScore < 38) {
        return realScore
    } else if(((Number.parseInt(realScore / 5) + 1) * 5) - realScore < 3) {
        return (Number.parseInt(realScore / 5) + 1) * 5
    } else {
        return realScore
    }
}

let situacao = (nota) => {
    if(arredondaNota(nota) < 40) {
        return "reprovado"
    } else {return "aprovado"}
}


console.log(situacao(38))