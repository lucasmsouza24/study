
//This function receive a numeric value, if this value is a prime number return true, else return false.
let primeNumber = (number) => {
    let divisors = 0;
    for (let i = 1; i <= number; i++) {
        if (number % i === 0) {
            divisors++;
        }
    }
    if (divisors === 2) {
        return true
    }
    else {
        return false
    }
}

//This function reveive a value maximus param and return a array with the prime numbers until max value
let listaPrimos = (max) => {
    let primos = Array();
    for (let i = 2; i <= max; i++){
        if (this.primeNumber(i)){
            primos.push(i)
        }
    }
    return primos;
}

module.exports = {
    primeNumber,
    listaPrimos
}