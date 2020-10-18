let pedido = (cod, qtd) => {
    if (consultarCod(cod) === "Invalid") {
        console.log("Produto não existente! Refaça o pedido")
        return null
    } else {
        console.log(`Produto: ${consultarCod(cod)[0]}`)
        console.log(`Valor único: R$ ${(consultarCod(cod)[1]).toFixed(2)}`)
        console.log(`Quantidade: ${qtd}`)
        console.log(`Valor total: R$ ${(consultarCod(cod)[1] * qtd).toFixed(2)}`)
    }
}

let consultarCod = (cod) => {
    switch (cod) {
        case 100:
            return ["Cachorro Quente", 3]
        case 200:
            return ["Hamburger Simples", 4]
        case 300:
            return ["Cheeseburguer", 5.5]
        case 400:
            return ["Bauru", 7.4]
        case 500:
            return ["Refrigerante", 3.5]
        case 600:
            return ["Suco", 2.8]
        default:
            return "Invalid"
    }
}

pedido(200, 5)