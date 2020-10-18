const verifyPlan = (yearOld) => {
    if (yearOld < 10) {
        return `R$ ${(100 + 80).toFixed(2).replace(".", ",")}`
    } else if (yearOld >= 10 && yearOld <= 30) {
        return `R$ ${(100 + 50).toFixed(2).replace(".", ",")}`
    } else if (yearOld > 30 && yearOld <= 60 ) {
        return `R$ ${(100 + 95).toFixed(2).replace(".", ",")}`
    } else if (yearOld > 60) {
        return `R$ ${(100 + 130).toFixed(2).replace(".", ",")}`
    }
}

console.log(verifyPlan(8))
console.log(verifyPlan(12))
console.log(verifyPlan(35))
console.log(verifyPlan(65))