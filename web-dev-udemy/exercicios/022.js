const anuidade = (month, value) => {
    if (month > 0 && month < 13) {
        return (value * (1 + 0.05) ** calcAtraso(month)).toFixed(2)
    }
}

const calcAtraso = (month) => month - 1

console.log(anuidade(4, 100))