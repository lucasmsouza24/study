// a: number
// b: number
// operator: "+", "-", "/" or "*"
let calc = (a = 0, operator = "+", b = 0) => {
    switch (operator) {
        case "+":
            return a + b
        case "-":
            return a - b
        case "*":
            return a * b
        case "/":
            if (b != 0){
                return  a / b
            } else {return "cant divide by zero"}
        default:
            return "invalid operator"
    }
}

console.log(calc(0, "+", 4))
console.log(calc(7, "-", 2))
console.log(calc(3, "*", 4))
console.log(calc(12, "/", 3))