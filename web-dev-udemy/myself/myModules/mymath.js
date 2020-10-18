// This is a refactored version from myMath.js

// range() return a Array with wished range and step

const range = (start = 0, end, step = 1) => {
    const _array = Array()
    for (let i = start; i === start || _array[_array.length - 1] + step <= end; i += step) {
        _array.push(i)
    } return _array
}

// positiveDivisors() returns the number of divisors of a number
const positiveDivisors = (number) => {
    return range(0, number).reduce((acc, crr) => {
        if (number % crr === 0) acc++
        return acc
    })
}

console.log(positiveDivisors(5))

// console.log(positiveDivisors(3))

// return positive divisors list of a number
const listPositiveDivisors = (number) => {
    const _divisors = Array()
    for (let i = 1; _divisors.length != positiveDivisors(number); i++){
        if (number % i === 0) _divisors.push(i)
    } return _divisors
}

//This function receive a numeric value, if this value is a prime number return true, else return false.
const isPrime = (number) => {
     if (positiveDivisors(number) === 2 ) return true
     else return false
}

//This function reveive a value maximus param and return a array with the prime numbers until max value
const listPrimesUntil = (max) => {
    let primos = Array();
    for (let i = 2; i <= max; i++){
        if (isPrime(i)) primos.push(i)
    } return primos;
}

// return list primes based on wished length 
const listPrimes = (length) => {
    let _primes = Array()
    for (let i = 2; _primes.length != length; i++){
        if (isPrime(i)) _primes.push(i)
    }
    return _primes
}

module.exports = {
    isPrime,
    listPrimesUntil,
    listPrimes,
    positiveDivisors,
    listPositiveDivisors,
    range
}