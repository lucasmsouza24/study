// ecxeption treatment
function tratarErro(err) {
    console.log(err.name);
	console.log(err.message);
}

// return all positive divisors of number param
function absDivisors(number = 0) {
    // verification if param is a numeric value
    if (isNaN(number) || number == null){
        console.log('Invalid param, try a numeric value different of zero')
        return NaN;
    }  else if (number == 0) {
        console.log('Invalid param, try a numeric value different of zero')
    } else { 
        // analyse each value and store in array the corrects
        let divisors = Array()
        for (let i = 1; i <= number; i++) {
            if (number % i === 0) {
                divisors.push(i);
            }
        }
        return divisors;
    }
}

// return all (include negatives) divisors of param number 
function allDivisors(number) {
    // verification if param is a numeric value
    if (isNaN(number) || number == null){
        console.log('Invalid param, try a numeric value different of zero')
        return NaN;
    }  else if (number == 0) {
        console.log('Invalid param, try a numeric value different of zero')
    } else {
        // required code if param > 0
        if (number > 0) {
            let divisors = Array();
            for (let i = -number; i <= number; i++) {
                if (number % i == 0) {
                    divisors.push(i);
                }
            }
            return divisors;
        } else {
            // required code if param < 0
            let divisors = Array();
            for (let i = number; i <= -number; i++) {
                if (number % i == 0) {
                    divisors.push(i)
                }
            }
            return divisors;
        }
    }
}

// return multiples of number param in range between number and length
// return Infinity if param == 0
function multiples(number, length = 1) {
    // verification if number and length is a valid value
    if (isNaN(number) || isNaN(length) || number == null || length == null) {
        console.log('Invalid param, try a numeric value');
        return NaN;
    } else if (number == 0) {
        return Infinity;
    } else if (length < 0){
        console.log('length param cannot be less than 0');
    } else {
        let multiples = Array();
        for (let i = 1; i <= length; i++) {
            multiples.push(number * i);
        }
        return multiples;
    }
}

// return boolean value, based in number param
function isPrime(number) {
    if (isNaN(number) || number == null) {
        console.log('invalid param, try a numeric value');
        return NaN;
    } else if (number < 2) {
        return false;
    } else if (absDivisors(number).length == 2) {   
        return true;
    } else {
        return false;
    }
}

// return a array with prime numbers in a range determined by length param
function primeList(length = 1) {
    if (isNaN(length) || length == null) {
        console.log('invalid param, try a biggest than 0 numeric value');
        return NaN;
    } else if (length == 0) {
        return []
    } else if (length < 0) {
        console.log('invalid param, try a biggest than 0 numeric value')
    } else {
        let primeList = Array();
        let i = 0
        while (primeList.length < length){
            if (isPrime(i)) {
                primeList.push(i);
            }
            i++;
        }
        return primeList;
    }
}

// return a array with fibonacci sequence in a range determined by length param
function fibonacciList(length = 1) {
    if (isNaN(length) || length == null) {
        console.log('invalid param, try a biggest than 0 numeric value');
        return NaN;
    } else if (length < 0) {
        console.log('invalid param, try a biggest than 0 numeric value');
    } else {
        let fibonacci = Array();
        let n1 = 0;
        let n2 = 1;
        let n3 = n1 + n2;
        let m1, m2, m3
        let i = 0;
        while (fibonacci.length <= length) {
            if (i != 0 && i != 1 && i){
                fibonacci.push(n3);
                m1 = n1, m2 = n2, m3 = n3;
                n1 = m2, n2 = m3, n3 = m2 + m3;
                i++;
                console.log('nº execução')

            } else if (i == 0) {
                fibonacci.push(0);
                console.log('primeira execução')
                i++;
            } else if (i == 1) {
                fibonacci.push(1);
                console.log('segunda execução')
                i++;
            }
        }
        return fibonacci;
    }
}

console.log(fibonacciList(14))
