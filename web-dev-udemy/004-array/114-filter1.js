// filter(callback) é literalmente um filtro de valores de array
// necessita de um retorno com valor true ou false
// if true {element estará no novo array}

// array.filter(callback(element, index, array) {return true})

const idades = [1, 5, 20, 32, 14, 16, 18, 22]

const adultos = idades.filter(function (element) {
    return element >= 18
})

console.log(adultos)