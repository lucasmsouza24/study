function analise(pontuacoes) {
    let pontos = pontuacoes.split(" ")
    let menor_ponto, maior_ponto, qtd_recorde, ponto, i_menor_ponto
    for (let i in pontos) {
        ponto = Number.parseInt(pontos[i])
        if (i != 0) {
            if (ponto < menor_ponto) {
                menor_ponto = ponto
                i_menor_ponto = Number.parseInt(i)
            }
            if (ponto > maior_ponto) {
                maior_ponto = ponto
                qtd_recorde += 1
            }
        } else {
            menor_ponto = ponto
            maior_ponto = ponto
            qtd_recorde = 0
        }
    }
    return [qtd_recorde, i_menor_ponto + 1]
}

let ex1 = "10 20 2 30 4 43"
console.log(analise(ex1))