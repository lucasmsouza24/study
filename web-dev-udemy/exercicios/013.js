// day should to be a week day, integer
// dom: 1, seg: 2, ...
let isDay = (day) => {
    switch (day) {
        case 1:
            return "fim de semana"
        case 2: case 3: case 4: case 5: case 6:
            return "util"
        case 7:
            return "fim de semana"
        default:
            return "dia inválido";
    }
}

console.log(isDay(0))