// num should to be integer
let factorial = (num) => {
    if (num != 0) {
        let fac =1 
        for (let i=1; i < num + 1; i++) {
            fac *= i
        }
        return fac
    } else {return 0}
}

console.log(factorial(4))