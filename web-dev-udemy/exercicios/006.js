const simples = (cap_ini, tax_jur, time) => {
    return cap_ini + (cap_ini * tax_jur * time)
}

const composto = (cap_ini, tax_jur, time) => {
    return cap_ini * (1 + tax_jur) ** time
}

console.log(composto(300, 0.1, 2))