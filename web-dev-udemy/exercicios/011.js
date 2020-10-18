// ano should to be integer type
let isLeap = (ano) => {
    if ((ano % 4 === 0 && ano % 100 !== 0) || ano % 400 === 0) {
        return true
    } else {return false}
}

console.log(isLeap(2020))