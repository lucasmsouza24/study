// plan: 
// a, b, c -> 0.1, 0.15, 0.2
let verifyPlan = (plan) => {
    switch (plan) {
        case "a": case "A":
            return 0.1
        case "b": case "B":
            return 0.15
        case "c": case "C":
            return 0.2
        default:
            return "Invalid"
    }
}

// params
// oldSalary: Number
// plan: a, b or c
let calcSalary = (oldSalary=0, plan) => {
    if (verifyPlan(plan) != "Invalid") {
        return oldSalary + (oldSalary * verifyPlan(plan))
    }
}

console.log(calcSalary(1630, "c"))