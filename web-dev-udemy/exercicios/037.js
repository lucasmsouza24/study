const pa = (n, a1, r) => {
    let myArray = Array()
    for (let i = 0; i <= n; i++) {
        if (i !== 0) {
            myArray.push(myArray[i - 1] + r)
        } else {
            myArray.push(a1)
        }
    }
    return myArray
}

const pg = (n, a1, r) => {
    let myArray = Array()
    for (let i = 0; i <= n; i++) {
        if (i !== 0) {
            myArray.push(myArray[i - 1] * r)
        } else {
            myArray.push(a1)
        }
    }
    return myArray
}

console.log(pa(5, 1, 3))
console.log(pg(5, 1, 3))