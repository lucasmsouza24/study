const filterMoney = (value) => {
    let rest = value
    // define as cedulas disponíveis ( também modifique na função show_results)
    let cedulas = [200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.10, 0.05]
    let qtd_cedulas = []
    for (let i in cedulas) {
        qtd_cedulas.push(filterCed(rest, cedulas[i]))
        rest -= filterCed(rest, cedulas[i]) * cedulas[i]
    }
    return qtd_cedulas
}

const filterCed = (value, ced) => {
    let rest = value
    let qtd_ced = 0
    while(rest - ced >= 0) {
        rest -= ced
        qtd_ced += 1
    }
    return qtd_ced
}

const show_results = (value) => {
    let cedulasArray = filterMoney(value)
    for (let i in cedulasArray) {
        // define as cédulas disponíveis (também modifique a função filterMoney)
        let cedulas = [200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.25, 0.10, 0.05]
        if(cedulasArray[i] != 0) {
            console.log(`Cedulas de R$ ${cedulas[i].toFixed(2).replace(".", ",")}: ${cedulasArray[i]}`)
        }
    }
}

show_results(377.88)